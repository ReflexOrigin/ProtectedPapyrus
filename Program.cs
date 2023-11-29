using System;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPapyrus
{
    internal static class Program
    {
        private static bool previousInternetConnection = true;
        private static bool messageSent = false;

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

            // Start the main loop asynchronously
            Task.Run(() => MainLoopAsync());

            Application.Run(new Login());
        }

        private static bool IsInternetAvailable()
        {
            return NetworkInterface.GetIsNetworkAvailable();
        }

        private static async Task MainLoopAsync()
        {
            while (true)
            {
                bool currentInternetConnection = await IsInternetAvailableAsync();

                if (!currentInternetConnection && previousInternetConnection)
                {
                    if (!messageSent)
                    {
                        DisplayInternetStatusMessage(false);
                        messageSent = true;
                    }
                }
                else if (currentInternetConnection && !previousInternetConnection)
                {
                    // Internet reconnected
                    DisplayInternetStatusMessage(true);
                    messageSent = false;
                }

                previousInternetConnection = currentInternetConnection;

                await Task.Delay(1000);
            }
        }

        private static async Task<bool> IsInternetAvailableAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage response = await client.GetAsync("https://www.google.com", HttpCompletionOption.ResponseHeadersRead))
                {
                    return response.IsSuccessStatusCode;
                }
            }
            catch
            {
                return false;
            }
        }

        private static void DisplayInternetStatusMessage(bool isConnected)
        {
            string statusMessage = isConnected
                ? "Internet connection is available."
                : "No internet connection. Please check your network.";

            MessageBox.Show(statusMessage, "Internet Status", MessageBoxButtons.OK, isConnected ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }
    }
}
