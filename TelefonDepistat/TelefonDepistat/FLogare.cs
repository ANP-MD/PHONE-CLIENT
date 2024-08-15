using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace TelefonDepistat
{
    public partial class FLogare : Form
    {
        protected MySqlConnection connection;
        private ConnectorBD cbd;

        //update module
        private static readonly string client_version = "1.0.0";
        public static readonly string versionUrl = "https://raw.githubusercontent.com/ANP-MD/PHONE-CLIENT/main/version.txt";
        public static readonly string update = @"C:\PrisonPhone\update.exe";
        public static readonly string updateFlag = @"C:\PrisonPhone\update.txt";

        private void CheckUpdate(string version)
        {
            try
            {
                var metadata = new List<string>();
                using (WebClient client = new WebClient())
                {
                    string updateData = client.DownloadString(versionUrl);
                    metadata.AddRange(Regex.Split(updateData, "\r\n|\r|\n"));
                }

                if (version != metadata[0])
                {
                    using (WebClient client = new WebClient())
                    {
                        // Download the file synchronously
                        client.DownloadFile(new Uri(metadata[1]), update);
                    }

                    // After the file is downloaded, proceed with the update
                    File.WriteAllText(updateFlag, "INCOMING_UPDATE");
                    var process = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = update,
                            UseShellExecute = true // Ensure the file is executed correctly
                        }
                    };
                    process.Start();
                    Application.Exit();
                }
                else
                {
                    // Delete the update file if no update is needed
                    if (File.Exists(update))
                    {
                        File.Delete(update);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., logging)
                errorLabel.Text = $"Update Error: {ex.Message}";
            }
        }


        //end of update module

        public FLogare()
        {
            InitializeComponent();
            CheckUpdate(client_version);

            // Initialize the ConnectorBD with MySQL server details
            cbd = new ConnectorBD("", "", "", "");
        }

        public string GetUser()
        {
            return textBoxUser.Text;
        }

        public string GetPassword()
        {
            return maskedPassword.Text;
        }

        public ConnectorBD GetConnectorBD()
        {
            return cbd;
        }

        private void buttonAcceptare_Click(object sender, EventArgs e)
        {
            labelStatutLogare.Text = "";
            if (textBoxUser.Text.Length > 0)
            {
                if (maskedPassword.Text.Length <= 0)
                {
                    MessageBox.Show("Atentie! Nu ati introdus toate datele utilizatorului", "Logare",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.DialogResult = DialogResult.None;
                    return;
                }
                else
                {
                    cbd.SetPassword(maskedPassword.Text);
                    cbd.SetUser(textBoxUser.Text);
                    cbd.CreateConnectionBD();

                    if (VerifyConnection() == 0)
                    {
                        labelStatutLogare.ForeColor = Color.Red;
                        labelStatutLogare.Text = "Eroare: conectare imposibila.";
                        this.DialogResult = DialogResult.None;
                        return;
                    }
                    else
                    {
                        labelStatutLogare.ForeColor = Color.Green;
                        labelStatutLogare.Text = "Conectare cu Succes !!!";
                    }
                }
            }
            else
            {
                MessageBox.Show("Atentie! Nu ati introdus toate datele utilizatorului", "Logare",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.DialogResult = DialogResult.None;
                return;
            }
        }

        private int VerifyConnection()
        {
            connection = cbd.GetConnectionBD();
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                // Log or handle exception as needed
                return 0;
            }
            connection.Close();
            return 1;
        }

        private void maskedPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Use character comparison for Enter key
            {
                buttonAcceptare_Click(sender, e);
                this.DialogResult = DialogResult.OK;
                return;
            }
        }

        private void maskedPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // Handle any specific logic for rejected input if needed
        }
    }
}
