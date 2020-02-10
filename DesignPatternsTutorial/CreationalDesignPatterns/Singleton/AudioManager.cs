using System;

namespace DesignPatternsTutorial.CreationalDesignPatterns.Singleton
{
    public class AudioManager
    {
        private static AudioManager instance;
        private static readonly object padlock = new object();
        
        private AudioManager()
        {
            // audio manager initialization stuff
            Console.WriteLine("Audio Manager Initialized!");
        }

        public static AudioManager Instance
        {
            get
            {
                lock (padlock)
                {
                    return instance ?? (instance = new AudioManager());
                }
            }
        }

        public void PlayClip(String clipRef)
        {
            Console.WriteLine("Play Clip: " + clipRef);
        }

        public void StopClip(String clipRef)
        {
            Console.WriteLine("Stop Clip: " + clipRef);
        }
    }
}