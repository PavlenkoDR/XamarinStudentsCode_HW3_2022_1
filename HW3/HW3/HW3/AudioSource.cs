using Android.Media;

namespace VisualNowel
{
    public class AudioSource
    {
        const string audioDirectoryPath = "HW3.Assets.Audio";

        private MediaPlayer _player;

        public AudioSource()
        {
            _player = new MediaPlayer();
        }

        public void PlayMP3Audio(string audio)
        {
            //Now return exception
            //_player.Reset();
            //_player.SetDataSource($"{audioDirectoryPath}.{audio}.mp3");
            //_player.Prepare();
            //_player.Start();
        }
    }
}
