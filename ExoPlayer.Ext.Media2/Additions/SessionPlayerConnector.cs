using System;
using System.Collections.Generic;
using Android.Runtime;
using Google.Common.Util.Concurrent;
using Java.Interop;
using JavaObject = Java.Lang.Object;

namespace Com.Google.Android.Exoplayer2.Ext.Media2
{
    // NOTE We need to specify this using inside the namespace
    // since we have the generation of Com.Google.Android.Exoplayer2.MediaItem class
    // and with default using declaration that class will have higher priority than one from the AndroidX library
    using AndroidX.Media2.Common;

    // Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']"
    public sealed partial class SessionPlayerConnector
    {
        // Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='setPlaylist' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;androidx.media2.common.MediaItem&gt;'] and parameter[2][@type='androidx.media2.common.MediaMetadata']]"
        [Register("setPlaylist", "(Ljava/util/List;Landroidx/media2/common/MediaMetadata;)Lcom/google/common/util/concurrent/ListenableFuture;", "")]
        public override unsafe IListenableFuture SetPlaylist(IList<MediaItem> playlist, MediaMetadata metadata)
        {
            const string __id = "setPlaylist.(Ljava/util/List;Landroidx/media2/common/MediaMetadata;)Lcom/google/common/util/concurrent/ListenableFuture;";
            var native_playlist = JavaList<MediaItem>.ToLocalJniHandle(playlist);
            try
            {
                var __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue(native_playlist);
                __args[1] = new JniArgumentValue(metadata?.Handle ?? IntPtr.Zero);
                var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
                return JavaObject.GetObject<IListenableFuture>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_playlist);
                GC.KeepAlive(playlist);
                GC.KeepAlive(metadata);
            }
        }
    }
}
