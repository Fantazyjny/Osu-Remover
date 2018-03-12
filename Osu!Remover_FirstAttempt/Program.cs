using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Osu_Remover_FirstAttempt
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootFolderName = "C:\\Users\\damia\\Desktop\\TEST";
            string[] folderPaths = Directory.GetDirectories(rootFolderName);
            int folderPathsArraySize = folderPaths.Length;


            Console.WriteLine("Liczba folderów do skanowania: " + folderPathsArraySize);
            for (int i = 0; i < folderPathsArraySize; i++)
            {
                Console.WriteLine("Skanowanie folderu: " + folderPaths[i]);


                string[] softSoundFiles = Directory.GetFiles(folderPaths[i], "soft-*.wav");
                int softSoundFilesLength = softSoundFiles.Length;
                for (int j = 0; j < softSoundFilesLength; j++)
                {
                    Console.WriteLine(softSoundFiles[j]);
                }

                string[] drumSoundFiles = Directory.GetFiles(folderPaths[i], "drum-*.wav");
                int drumSoundFilesLength = softSoundFiles.Length;
                for (int k = 0; k < drumSoundFilesLength; k++)
                {
                    Console.WriteLine(k);
                    Console.WriteLine(drumSoundFiles[k]);
                }

                string[] normalSoundFiles = Directory.GetFiles(folderPaths[i], "normal-*.wav");
                int normalSoundFilesLength = normalSoundFiles.Length;
                for (int l = 0; l < normalSoundFilesLength; l++)
                {
                    Console.WriteLine(normalSoundFiles[l]);
                }





                Console.WriteLine("\n#######################################################\n");
            }
            Console.ReadKey();

            //string[] filePathsArray = Directory.GetFiles(@"C:\Users\damia\Desktop\test_folder\", "*", SearchOption.AllDirectories);
            //foreach (string str in filePathsArray) Console.WriteLine(str);
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
        }
    }
}
