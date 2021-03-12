using Android.Runtime;

namespace Com.Google.Android.Exoplayer2.Testutil
{
    public partial class FakeMediaSource
    {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.testutil']/class[@name='FakeMediaSource']/method[@name='getInitialTimeline' and count(parameter)=0]"
		[Register("getInitialTimeline", "()Lcom/google/android/exoplayer2/Timeline;", "GetGetInitialTimelineHandler")]
		public unsafe global::Com.Google.Android.Exoplayer2.Timeline? GetInitialTimeline()
		{
			const string __id = "getInitialTimeline.()Lcom/google/android/exoplayer2/Timeline;";
			try
			{
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer2.Timeline>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
	}
}
