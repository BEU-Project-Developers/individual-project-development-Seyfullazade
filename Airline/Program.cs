using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AddPassenger());
            //Application.Run(new ViewPassenger());
            // Application.Run(new FlightTbl());
            Application.Run(new Ticket());
            //Application.Run(new Form1());
            //Application.Run(new ViewFlights());
            //Application.Run(new Home());
            //Application.Run(new Login());
            //Application.Run(new CancellationTbl());
        }
    }
}
