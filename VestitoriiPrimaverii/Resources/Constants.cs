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
        public static string pathOmDeZapada = formAbsolutePath("Resources/povesteMediu/omul-de-zapada-cantec.mp4");
        public static string pathGhiocel = formAbsolutePath("Resources/povesteMediu/ghiocel-poezie.mp4");
        public static string pathPasariCalatoare = formAbsolutePath("Resources/povesteMediu/pasari-calatoare-poezie-scurta.mp4");
        public static string pathPrmavaraSchimbari = formAbsolutePath("Resources/povesteMediu/primavara-schimbari.mp4");

        //poveste mate...
    
        static string formAbsolutePath(string path)
        {
            return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), path);
        }
    }

}
