using System;
namespace Com.Google.Android.Exoplayer2
{
    public abstract partial class BasePlayer
    {
        public virtual bool PlayWhenReady
        {
            get => GetPlayWhenReady ();
            set => SetPlayWhenReady (value);
        }

        public virtual int RepeatMode
        {
            get => GetRepeatMode ();
            set => SetRepeatMode (value);
        }

        public virtual bool ShuffleModeEnabled
        {
            get => GetShuffleModeEnabled ();
            set => SetShuffleModeEnabled (value);
        }
    }
}
