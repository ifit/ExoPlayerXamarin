﻿/*
 * Copyright (C) 2017 The Android Open Source Project
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Android.App;
using Android.Content;
using Android.OS;
using Android.Util;
using Com.Google.Android.Exoplayer2.Scheduler;
using Com.Google.Android.Exoplayer2.UI;
using Com.Google.Android.Exoplayer2.Util;
using static Com.Google.Android.Exoplayer2.Offline.DownloadManager;
using Com.Google.Android.Exoplayer2.Offline;
using Utils = Com.Google.Android.Exoplayer2.Util.Util;
using Android.Runtime;
using System;
using Java.Interop;
using System.Collections.Generic;

namespace Com.Google.Android.Exoplayer2.Demo
{
    /** A service for downloading media. */
    [Service(Exported = false, Name = "com.google.android.exoplayer2.demo.DemoDownloadService")]
    [IntentFilter(actions: new string[] { "com.google.android.exoplayer.downloadService.action.INIT" }, Categories = new string[] { "android.intent.category.DEFAULT" })]
    public class DemoDownloadService : DownloadService
    {
        public static readonly string CHANNEL_ID = "download_channel";
        private static readonly int JOB_ID = 1;
        public static readonly int FOREGROUND_NOTIFICATION_ID = 1;

        [Export(SuperArgumentsString = "1, 1000, \"download_channel\", 2131427508")]
        public DemoDownloadService() : this (FOREGROUND_NOTIFICATION_ID, DefaultForegroundNotificationUpdateInterval, CHANNEL_ID, Resource.String.exo_download_notification_channel_name)
        {
        }

        protected DemoDownloadService(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
            
        }

        protected DemoDownloadService(int foregroundNotificationId) : base(foregroundNotificationId)
        {
        }

        protected DemoDownloadService(int foregroundNotificationId, long foregroundNotificationUpdateInterval) : base(foregroundNotificationId, foregroundNotificationUpdateInterval)
        {
        }

        protected DemoDownloadService(int foregroundNotificationId, long foregroundNotificationUpdateInterval, string channelId, int channelName) : base(foregroundNotificationId, foregroundNotificationUpdateInterval, channelId, channelName)
        {
        }

        protected override Offline.DownloadManager DownloadManager
        {
            get
            {
                return ((DemoApplication)Application).GetDownloadManager();
            }
        }

        protected override IScheduler Scheduler
        {
            get
            {
                return Utils.SdkInt >= 21 ? new PlatformScheduler(this, JOB_ID) : null;
            }
        }

        //public override IBinder OnBind(Intent intent)
        //{
        //    // Return null because this is a pure started service. A hybrid service would return a binder that would allow communication back and forth
        //    return null;
        //}

        public override void OnCreate()
        {
            base.OnCreate();
            global::Android.Util.Log.Debug("DemoDownloadService", "Service started.");
        }

        protected Offline.DownloadManager GetDownloadManager()
        {
            return ((DemoApplication)Application).GetDownloadManager();
        }

        protected PlatformScheduler GetScheduler()
        {
            return Utils.SdkInt >= 21 ? new PlatformScheduler(this, JOB_ID) : null;
        }

        protected override Notification GetForegroundNotification(IList<Download> downloads)
        {
            return DownloadNotificationUtil.BuildProgressNotification(
                /* context= */ this,
                Resource.Drawable.exo_controls_play,
                CHANNEL_ID,
                /* contentIntent= */ null,
                /* message= */ null,
                downloads);
        }

        protected override void OnDownloadChanged(Download download)
        {
            if (download.IsTerminalState)
            {
                return;
            }
            Notification notification = null;

            byte[] bytes = new byte[download.ContentLength];
            download.Request.Data.CopyTo(bytes, 0);

            if (download.State == Download.StateCompleted)
            {
                notification =
                    DownloadNotificationUtil.BuildDownloadCompletedNotification(
                        /* context= */ this,
                        Resource.Drawable.exo_controls_play,
                        CHANNEL_ID,
                        /* contentIntent= */ null,
                        Utils.FromUtf8Bytes(bytes));
            }
            else if (download.State == Download.StateFailed)
            {
                notification =
                    DownloadNotificationUtil.BuildDownloadFailedNotification(
                        /* context= */ this,
                        Resource.Drawable.exo_controls_play,
                        CHANNEL_ID,
                        /* contentIntent= */ null,
                       Utils.FromUtf8Bytes(bytes));
            }
            int notificationId = FOREGROUND_NOTIFICATION_ID + 1 + download.Request.Id.GetHashCode();
            NotificationUtil.SetNotification(this, notificationId, notification);
        }
    }
}
