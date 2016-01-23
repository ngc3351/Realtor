using System;
using System.Diagnostics;
using System.IO;

namespace Realtor
{
    class DbRun
    {
        static Process _db;

        public static void Run()
        {
            if (IsRun)
                return;

            string file = "dbrun.exe";
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            if (!File.Exists(dir + file)) {
                dir += "../../db/";
            }

            ProcessStartInfo i = new ProcessStartInfo(dir + file);
            i.Arguments = string.Format(@"-u root -P 3309 -h {0}db\ --character-sets-dir={0}share\charsets\ --language={0}share\english\ --default-character-set=cp1251"
                 //+ "--log=db.log"
                , AppDomain.CurrentDomain.BaseDirectory);
            i.CreateNoWindow = true;
            i.UseShellExecute = false;
            i.WindowStyle = ProcessWindowStyle.Hidden;

            _db = Process.Start(i);
        }

        public static void Stop()
        {
            if (IsRun)
                _db.Kill();
        }

        public static bool IsRun
        {
            get
            {
                return (_db != null && !_db.HasExited);
            }
        }
    }
}
