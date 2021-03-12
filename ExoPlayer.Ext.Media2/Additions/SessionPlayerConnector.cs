using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Android.Exoplayer2.Ext.Media2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer2/ext/media2/SessionPlayerConnector", DoNotGenerateAcw=true)]
	public sealed partial class SessionPlayerConnector : global::AndroidX.Media2.Common.SessionPlayer {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/android/exoplayer2/ext/media2/SessionPlayerConnector", typeof (SessionPlayerConnector));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal SessionPlayerConnector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public override unsafe global::AndroidX.Media.AudioAttributesCompat AudioAttributes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='getAudioAttributes' and count(parameter)=0]"
			[Register ("getAudioAttributes", "()Landroidx/media/AudioAttributesCompat;", "")]
			get {
				const string __id = "getAudioAttributes.()Landroidx/media/AudioAttributesCompat;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AndroidX.Media.AudioAttributesCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe long BufferedPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='getBufferedPosition' and count(parameter)=0]"
			[Register ("getBufferedPosition", "()J", "")]
			get {
				const string __id = "getBufferedPosition.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe int BufferingState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='getBufferingState' and count(parameter)=0]"
			[Register ("getBufferingState", "()I", "")]
			get {
				const string __id = "getBufferingState.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe global::AndroidX.Media2.Common.MediaItem CurrentMediaItem {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='getCurrentMediaItem' and count(parameter)=0]"
			[Register ("getCurrentMediaItem", "()Landroidx/media2/common/MediaItem;", "")]
			get {
				const string __id = "getCurrentMediaItem.()Landroidx/media2/common/MediaItem;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AndroidX.Media2.Common.MediaItem> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe int CurrentMediaItemIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='getCurrentMediaItemIndex' and count(parameter)=0]"
			[Register ("getCurrentMediaItemIndex", "()I", "")]
			get {
				const string __id = "getCurrentMediaItemIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe long CurrentPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='getCurrentPosition' and count(parameter)=0]"
			[Register ("getCurrentPosition", "()J", "")]
			get {
				const string __id = "getCurrentPosition.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "")]
			get {
				const string __id = "getDuration.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe int NextMediaItemIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='getNextMediaItemIndex' and count(parameter)=0]"
			[Register ("getNextMediaItemIndex", "()I", "")]
			get {
				const string __id = "getNextMediaItemIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe float PlaybackSpeed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='getPlaybackSpeed' and count(parameter)=0]"
			[Register ("getPlaybackSpeed", "()F", "")]
			get {
				const string __id = "getPlaybackSpeed.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe int PlayerState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='getPlayerState' and count(parameter)=0]"
			[Register ("getPlayerState", "()I", "")]
			get {
				const string __id = "getPlayerState.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe global::System.Collections.Generic.IList<global::AndroidX.Media2.Common.MediaItem> Playlist {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='getPlaylist' and count(parameter)=0]"
			[Register ("getPlaylist", "()Ljava/util/List;", "")]
			get {
				const string __id = "getPlaylist.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::AndroidX.Media2.Common.MediaItem>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::AndroidX.Media2.Common.MediaMetadata PlaylistMetadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='getPlaylistMetadata' and count(parameter)=0]"
			[Register ("getPlaylistMetadata", "()Landroidx/media2/common/MediaMetadata;", "")]
			get {
				const string __id = "getPlaylistMetadata.()Landroidx/media2/common/MediaMetadata;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AndroidX.Media2.Common.MediaMetadata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe int PreviousMediaItemIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='getPreviousMediaItemIndex' and count(parameter)=0]"
			[Register ("getPreviousMediaItemIndex", "()I", "")]
			get {
				const string __id = "getPreviousMediaItemIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe int RepeatMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='getRepeatMode' and count(parameter)=0]"
			[Register ("getRepeatMode", "()I", "")]
			get {
				const string __id = "getRepeatMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe int ShuffleMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='getShuffleMode' and count(parameter)=0]"
			[Register ("getShuffleMode", "()I", "")]
			get {
				const string __id = "getShuffleMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='addPlaylistItem' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='androidx.media2.common.MediaItem']]"
		[Register ("addPlaylistItem", "(ILandroidx/media2/common/MediaItem;)Lcom/google/common/util/concurrent/ListenableFuture;", "")]
		public override unsafe global::Google.Common.Util.Concurrent.IListenableFuture AddPlaylistItem (int index, global::AndroidX.Media2.Common.MediaItem item)
		{
			const string __id = "addPlaylistItem.(ILandroidx/media2/common/MediaItem;)Lcom/google/common/util/concurrent/ListenableFuture;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue ((item == null) ? IntPtr.Zero : ((global::Java.Lang.Object) item).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.Common.Util.Concurrent.IListenableFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (item);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()Lcom/google/common/util/concurrent/ListenableFuture;", "")]
		public override unsafe global::Google.Common.Util.Concurrent.IListenableFuture Pause ()
		{
			const string __id = "pause.()Lcom/google/common/util/concurrent/ListenableFuture;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.Common.Util.Concurrent.IListenableFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='play' and count(parameter)=0]"
		[Register ("play", "()Lcom/google/common/util/concurrent/ListenableFuture;", "")]
		public override unsafe global::Google.Common.Util.Concurrent.IListenableFuture Play ()
		{
			const string __id = "play.()Lcom/google/common/util/concurrent/ListenableFuture;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.Common.Util.Concurrent.IListenableFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='prepare' and count(parameter)=0]"
		[Register ("prepare", "()Lcom/google/common/util/concurrent/ListenableFuture;", "")]
		public override unsafe global::Google.Common.Util.Concurrent.IListenableFuture Prepare ()
		{
			const string __id = "prepare.()Lcom/google/common/util/concurrent/ListenableFuture;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.Common.Util.Concurrent.IListenableFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='removePlaylistItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removePlaylistItem", "(I)Lcom/google/common/util/concurrent/ListenableFuture;", "")]
		public override unsafe global::Google.Common.Util.Concurrent.IListenableFuture RemovePlaylistItem (int index)
		{
			const string __id = "removePlaylistItem.(I)Lcom/google/common/util/concurrent/ListenableFuture;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.Common.Util.Concurrent.IListenableFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='replacePlaylistItem' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='androidx.media2.common.MediaItem']]"
		[Register ("replacePlaylistItem", "(ILandroidx/media2/common/MediaItem;)Lcom/google/common/util/concurrent/ListenableFuture;", "")]
		public override unsafe global::Google.Common.Util.Concurrent.IListenableFuture ReplacePlaylistItem (int index, global::AndroidX.Media2.Common.MediaItem item)
		{
			const string __id = "replacePlaylistItem.(ILandroidx/media2/common/MediaItem;)Lcom/google/common/util/concurrent/ListenableFuture;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue ((item == null) ? IntPtr.Zero : ((global::Java.Lang.Object) item).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.Common.Util.Concurrent.IListenableFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (item);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='seekTo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seekTo", "(J)Lcom/google/common/util/concurrent/ListenableFuture;", "")]
		public override unsafe global::Google.Common.Util.Concurrent.IListenableFuture SeekTo (long position)
		{
			const string __id = "seekTo.(J)Lcom/google/common/util/concurrent/ListenableFuture;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (position);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.Common.Util.Concurrent.IListenableFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='setAudioAttributes' and count(parameter)=1 and parameter[1][@type='androidx.media.AudioAttributesCompat']]"
		[Register ("setAudioAttributes", "(Landroidx/media/AudioAttributesCompat;)Lcom/google/common/util/concurrent/ListenableFuture;", "")]
		public override unsafe global::Google.Common.Util.Concurrent.IListenableFuture SetAudioAttributes (global::AndroidX.Media.AudioAttributesCompat attr)
		{
			const string __id = "setAudioAttributes.(Landroidx/media/AudioAttributesCompat;)Lcom/google/common/util/concurrent/ListenableFuture;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((attr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attr).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.Common.Util.Concurrent.IListenableFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (attr);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='setControlDispatcher' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer2.ControlDispatcher']]"
		[Register ("setControlDispatcher", "(Lcom/google/android/exoplayer2/ControlDispatcher;)V", "")]
		public unsafe void SetControlDispatcher (global::Com.Google.Android.Exoplayer2.IControlDispatcher controlDispatcher)
		{
			const string __id = "setControlDispatcher.(Lcom/google/android/exoplayer2/ControlDispatcher;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((controlDispatcher == null) ? IntPtr.Zero : ((global::Java.Lang.Object) controlDispatcher).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (controlDispatcher);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='setMediaItem' and count(parameter)=1 and parameter[1][@type='androidx.media2.common.MediaItem']]"
		[Register ("setMediaItem", "(Landroidx/media2/common/MediaItem;)Lcom/google/common/util/concurrent/ListenableFuture;", "")]
		public override unsafe global::Google.Common.Util.Concurrent.IListenableFuture SetMediaItem (global::AndroidX.Media2.Common.MediaItem item)
		{
			const string __id = "setMediaItem.(Landroidx/media2/common/MediaItem;)Lcom/google/common/util/concurrent/ListenableFuture;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((item == null) ? IntPtr.Zero : ((global::Java.Lang.Object) item).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.Common.Util.Concurrent.IListenableFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (item);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='setPlaybackSpeed' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setPlaybackSpeed", "(F)Lcom/google/common/util/concurrent/ListenableFuture;", "")]
		public override unsafe global::Google.Common.Util.Concurrent.IListenableFuture SetPlaybackSpeed (float playbackSpeed)
		{
			const string __id = "setPlaybackSpeed.(F)Lcom/google/common/util/concurrent/ListenableFuture;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (playbackSpeed);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.Common.Util.Concurrent.IListenableFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='setPlaylist' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;androidx.media2.common.MediaItem&gt;'] and parameter[2][@type='androidx.media2.common.MediaMetadata']]"
		[Register ("setPlaylist", "(Ljava/util/List;Landroidx/media2/common/MediaMetadata;)Lcom/google/common/util/concurrent/ListenableFuture;", "")]
		public override unsafe global::Google.Common.Util.Concurrent.IListenableFuture SetPlaylist (global::System.Collections.Generic.IList<global::AndroidX.Media2.Common.MediaItem> playlist, global::AndroidX.Media2.Common.MediaMetadata metadata)
		{
			const string __id = "setPlaylist.(Ljava/util/List;Landroidx/media2/common/MediaMetadata;)Lcom/google/common/util/concurrent/ListenableFuture;";
			IntPtr native_playlist = global::Android.Runtime.JavaList<global::AndroidX.Media2.Common.MediaItem>.ToLocalJniHandle (playlist);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_playlist);
				__args [1] = new JniArgumentValue ((metadata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) metadata).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.Common.Util.Concurrent.IListenableFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_playlist);
				global::System.GC.KeepAlive (playlist);
				global::System.GC.KeepAlive (metadata);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='setRepeatMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRepeatMode", "(I)Lcom/google/common/util/concurrent/ListenableFuture;", "")]
		public override unsafe global::Google.Common.Util.Concurrent.IListenableFuture SetRepeatMode (int repeatMode)
		{
			const string __id = "setRepeatMode.(I)Lcom/google/common/util/concurrent/ListenableFuture;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (repeatMode);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.Common.Util.Concurrent.IListenableFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='setShuffleMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setShuffleMode", "(I)Lcom/google/common/util/concurrent/ListenableFuture;", "")]
		public override unsafe global::Google.Common.Util.Concurrent.IListenableFuture SetShuffleMode (int shuffleMode)
		{
			const string __id = "setShuffleMode.(I)Lcom/google/common/util/concurrent/ListenableFuture;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shuffleMode);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.Common.Util.Concurrent.IListenableFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='skipToNextPlaylistItem' and count(parameter)=0]"
		[Register ("skipToNextPlaylistItem", "()Lcom/google/common/util/concurrent/ListenableFuture;", "")]
		public override unsafe global::Google.Common.Util.Concurrent.IListenableFuture SkipToNextPlaylistItem ()
		{
			const string __id = "skipToNextPlaylistItem.()Lcom/google/common/util/concurrent/ListenableFuture;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.Common.Util.Concurrent.IListenableFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='skipToPlaylistItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skipToPlaylistItem", "(I)Lcom/google/common/util/concurrent/ListenableFuture;", "")]
		public override unsafe global::Google.Common.Util.Concurrent.IListenableFuture SkipToPlaylistItem (int index)
		{
			const string __id = "skipToPlaylistItem.(I)Lcom/google/common/util/concurrent/ListenableFuture;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.Common.Util.Concurrent.IListenableFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='skipToPreviousPlaylistItem' and count(parameter)=0]"
		[Register ("skipToPreviousPlaylistItem", "()Lcom/google/common/util/concurrent/ListenableFuture;", "")]
		public override unsafe global::Google.Common.Util.Concurrent.IListenableFuture SkipToPreviousPlaylistItem ()
		{
			const string __id = "skipToPreviousPlaylistItem.()Lcom/google/common/util/concurrent/ListenableFuture;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Google.Common.Util.Concurrent.IListenableFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.ext.media2']/class[@name='SessionPlayerConnector']/method[@name='updatePlaylistMetadata' and count(parameter)=1 and parameter[1][@type='androidx.media2.common.MediaMetadata']]"
		[Register ("updatePlaylistMetadata", "(Landroidx/media2/common/MediaMetadata;)Lcom/google/common/util/concurrent/ListenableFuture;", "")]
		public override unsafe global::Google.Common.Util.Concurrent.IListenableFuture UpdatePlaylistMetadata (global::AndroidX.Media2.Common.MediaMetadata metadata)
		{
			const string __id = "updatePlaylistMetadata.(Landroidx/media2/common/MediaMetadata;)Lcom/google/common/util/concurrent/ListenableFuture;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((metadata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) metadata).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Google.Common.Util.Concurrent.IListenableFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (metadata);
			}
		}

	}
}
