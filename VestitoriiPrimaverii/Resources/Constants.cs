﻿using System;
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