using System.Threading;
using VideoPlayerController;

namespace UnfuckMicrophone
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var handle = HandleYolo.GetConsoleWindow();
            HandleYolo.ShowWindow(handle, HandleYolo.SW_HIDE);

            while (true)
            {
                try
                {
                    var t = AudioManager.GetComMicVolume();
                    if (t == 40) // F*ck skype for business.
                        AudioManager.SetComMivVolume(100);
                }
                catch
                {
                    // Don't care. Happens if no microphone.
                }

                Thread.Sleep(1000 * 2);
            }
        }
    }
}
