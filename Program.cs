using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPapyrus
{
    internal static class Program
    {
        static bool previousInternetConnection = true;
        static bool messageSent = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!IsInternetAvailable())
            {
                MessageBox.Show("Internet connection is required to use this application. Please check your internet connection and try again.");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            while (true)
            {
                bool currentInternetConnection = CheckInternetConnection();

                if (currentInternetConnection != previousInternetConnection)
                {
                    if (!messageSent)
                    {
                        DisplayInternetStatusMessage(currentInternetConnection);
                        messageSent = true;
                    }
                }
                else
                {
                    messageSent = false;
                }

                previousInternetConnection = currentInternetConnection;

                Thread.Sleep(1000);
            }

        }

        static bool IsInternetAvailable()
        {
            return NetworkInterface.GetIsNetworkAvailable();
        }

        static bool CheckInternetConnection()
        {
            string targetHost = "google.com";
            Ping ping = new Ping();
            try
            {
                PingReply reply = ping.Send(targetHost);
                return reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                return false;
            }
        }

        static void DisplayInternetStatusMessage(bool isConnected)
        {
            string statusMessage = isConnected
                ? "Internet connection restored."
                : "Internet connection lost.";

            Console.WriteLine(statusMessage);
        }
    }
}
