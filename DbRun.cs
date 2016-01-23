using System;
using System.Diagnostics;

namespace Realtor
{
    class DbRun
    {
        static Process _db;

        public static void Run()
        {
            if (IsRun)
                return;

            ProcessStartInfo i = new ProcessStartInfo(AppDomain.CurrentDomain.BaseDirectory + "dbrun.exe");
            i.Arguments = string.Format(@"-u root -P 3309 -h {0}db\ --character-sets-dir={0}share\charsets\ --language={0}share\english\ --default-character-set=cp1251"
                // --log=d:\_db.log"
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
