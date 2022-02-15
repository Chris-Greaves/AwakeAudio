using System.Media;

namespace AwakeAudio.Worker
{
    public class AwakeAudioService
    {
        private readonly SoundPlayer _player;

        public AwakeAudioService()
        {
            _player = new SoundPlayer();
#if DEBUG
            _player.SoundLocation = @"Sound\test.wav";
#else
            _player.SoundLocation = @"Sound\anti-sleep.wav";
#endif
        }

        public void PlayAwakeSound()
        {
            _player.Play();
        }
    }
}
