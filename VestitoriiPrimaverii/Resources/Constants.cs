using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VestitoriiPrimaverii.Resources
{
    static class Constants
    {
        //poveste mediu
        public static string pathOmDeZapada = buildAbsolutePath(@"Resources\povesteMediu\omul-de-zapada-cantec.mp4");
        public static string pathGhiocel = buildAbsolutePath(@"Resources\povesteMediu\ghiocel-poezie.mp4");
        public static string pathPasariCalatoare = buildAbsolutePath(@"Resources\povesteMediu\pasari-calatoare-poezie-scurta.mp4");
        public static string pathPrmavaraSchimbari = buildAbsolutePath(@"Resources\povesteMediu\primavara-schimbari.mp4");

        //poveste romana
        public static string pathCantecVinePrimavara = buildAbsolutePath(@"Resources\povesteRomana\cantecPovesteRomana.mp4");

        //poveste societate
        public static string pathPovesteSocietate = buildAbsolutePath(@"Resources\povesteSocietate\videoSocietate.mp4");

        //poveste mate
        public static string pathCantecel = buildAbsolutePath(@"Resources\povesteMate\cantecel.mp4");

        //joc mate
        public static string pathBuburuzaAudio = buildAbsolutePath(@"Resources\jocMate\Buburuza.mp3");
        public static string pathGhioceiAudio = buildAbsolutePath(@"Resources\jocMate\Ghiocei.mp3");
        public static string pathFluturiAudio = buildAbsolutePath(@"Resources\jocMate\Fluturi.mp3");

        //joc mediu
        public static string pathReguliMediu = buildAbsolutePath(@"Resources\jocMediu\Fulgi.mp3");

        //joc romana
        public static string pathPrimavara = buildAbsolutePath(@"Resources\Primavara.wav");
        public static string pathGhiocelul = buildAbsolutePath(@"Resources\Ghiocelul.wav");
        public static string pathRandunica = buildAbsolutePath(@"Resources\Randunica.wav");
        
        public static string pathIntro = buildAbsolutePath(@"Resources\Intro.mp4");

        public static string pathTachinare = buildAbsolutePath(@"Resources\povesteTachinare\tachinare.mp4");

        public static string pathVictory = buildAbsolutePath(@"Resources\povesteTachinare\victory.mp4");

        static string buildAbsolutePath(string path)
        {
            string absolutePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string buildPath = "";
            string[] pathList = absolutePath.Split('\\');
            int i = 0;
            while (!pathList[i].Equals("VestitoriiPrimaverii"))
                buildPath += pathList[i++] + "\\";
            buildPath += @"VestitoriiPrimaverii\";
            return Path.Combine(buildPath, path);
        }
    }

}
