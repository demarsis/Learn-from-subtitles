using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFromSubtitles
{
    class AccountLoader
    {
        public static Account load(string path)
        {
            if (!Directory.Exists(path)) return null;
            if (!File.Exists(path + "\\known.txt")) return null;
            if (!File.Exists(path + "\\trash.txt")) return null;

            return new Account(path + "\\trash.txt", path + "\\known.txt");
        }

        public static Account create(string path)
        {
            if (!Directory.Exists(path)) return null;
            FileStream known = File.Create(path + "\\known.txt");
            FileStream trash = File.Create(path + "\\trash.txt");
            known.Close();
            trash.Close();

            return new Account(path + "\\trash.txt", path + "\\known.txt");
        }
    }
}
