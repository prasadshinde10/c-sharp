// ============================================
// Program #185 — ExplicitInterface
// Category  : 19_Advanced_OOP
// Difficulty: [Intermediate]
// Description: Explicit interface implementation to resolve method conflicts
// ============================================

using System;

namespace CSharp30Programs.Advanced_OOP
{
    interface IAudioPlayer
    {
        void Play();
    }

    interface IVideoPlayer
    {
        void Play();
    }

    class MediaPlayer : IAudioPlayer, IVideoPlayer
    {
        void IAudioPlayer.Play() => Console.WriteLine("Playing audio track.");
        void IVideoPlayer.Play() => Console.WriteLine("Playing video stream.");
    }

    class Program_185_ExplicitInterface
    {
        static void Main(string[] args)
        {
            var player = new MediaPlayer();
            ((IAudioPlayer)player).Play();
            ((IVideoPlayer)player).Play();
        }
    }
}
