using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDStabilizer
{
    static class Program
    {
        static ComponentMain cmpMain;

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (cmpMain = new ComponentMain())
            {
                Application.Run();
            }

        }
    }
}
