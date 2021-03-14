namespace Com.Google.Android.Exoplayer2
{
    public partial interface IExoPlayer
    {
        bool PlayWhenReady
        {
            get => GetPlayWhenReady ();
            set => SetPlayWhenReady (value);
        }

        int RepeatMode
        {
            get => GetRepeatMode ();
            set => SetRepeatMode (value);
        }

        bool ShuffleModeEnabled
        {
            get => GetShuffleModeEnabled ();
            set => SetShuffleModeEnabled (value);
        }
    }

    internal partial class IExoPlayerInvoker
    {
        public bool GetPlayWhenReady()
        {
            return PlayWhenReady;
        }

        public int GetRepeatMode()
        {
            return RepeatMode;
        }

        public bool GetShuffleModeEnabled()
        {
            return ShuffleModeEnabled;
        }
    }
}
