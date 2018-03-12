using System;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Osu_Remover
{
    class Program
    {
        static void Main(string[] args)
        {
            string appDirPath = Directory.GetCurrentDirectory();

            string[] filePatterns =
            {
                "*.mp4",
                "*.osb",
                "soft-*.wav",
                "normal-*.wav",
                "drum-*.wav",
                "taiko-soft-*.wav",
                "taiko-normal-*.wav",
                "taiko-drum-*.wav",
                "count1s.wav",
                "count2s.wav",
                "count3s.wav",
                "gos.wav",
                "readys.wav",
                "applause.wav",
                "comboburst.wav",
                "combobreak.wav",
                "failsound.wav",
                "sectionpass.wav",
                "sectionfail.wav",
                "pause-loop.wav",
                "spinnerspin.wav",
                "spinnerbonus.wav",
                "comboburst.png",
                "default-*.png",
                "approachcircle.png",
                "hitcircle.png",
                "hitcircleoverlay*.png",
                "followpoint.png",
                "lighting.png",
                "sliderstartcircle.png",
                "sliderstartcircleoverlay*.png",
                "sliderendcircle.png",
                "sliderendcircleoverlay*.png",
                "reversearrow.png",
                "sliderfollowcircle*.png",
                "sliderb*.png",
                "sliderb-nd.png",
                "sliderb-spec.png",
                "sliderpoint*.png",
                "sliderscorepoint.png",
                "spinner-background.png",
                "spinner-circle.png",
                "spinner-metre.png",
                "spinner-osu.png",
                "spinner-bottom.png",
                "spinner-glow.png",
                "spinner-middle.png",
                "spinner-top.png",
                "spinner-approachcircle.png",
                "spinner-rpm.png",
                "spinner-clear.png",
                "spinner-spin.png",
                "particle*.png"
            };

            for (int i = 0; i < filePatterns.Length; i++)
            {
                Parallel.ForEach(Directory.EnumerateFiles(appDirPath, filePatterns[i], System.IO.SearchOption.AllDirectories).AsParallel(), Item =>
                            {
                                File.Delete(Item);
                            });
                Console.WriteLine("Delete: " + filePatterns[i]);
            }

            string[] SBfolder = Directory.GetDirectories(appDirPath, "sb", System.IO.SearchOption.AllDirectories);
            for (int i = 0; i < SBfolder.Length; i++)
            {
                Directory.Delete(SBfolder[i], true);
                Console.WriteLine("Delete dir: " + SBfolder[i]);
            }
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
