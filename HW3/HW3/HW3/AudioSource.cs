using HW3;
using System.IO;
using System.Reflection;

namespace VisualNowel
{
    public class AudioSource
    {
        const string audioDirectoryPath = "HW3.Assets.Audio";
        Plugin.SimpleAudioPlayer.ISimpleAudioPlayer player;

        public void PlayMP3Audio(string audio)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream audioStream = assembly.GetManifestResourceStream($"{audioDirectoryPath}.{audio}.mp3");

            player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Stop();
            if (audioStream != null)
            {
                player.Load(audioStream);
                player.Play();
            }
        }
    }
}
