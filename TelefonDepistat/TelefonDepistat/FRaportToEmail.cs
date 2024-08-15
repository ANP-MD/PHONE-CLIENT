using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace TelefonDepistat
{
    public partial class FRaportToEmail : Form
    {
        private MySqlConnection connection;

        public FRaportToEmail(MySqlConnection _connection)
        {
            InitializeComponent();

            connection = _connection;

            toolStripStatusLabelNrTelefoane.Text = "0";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (listViewRezultatCaut.Items.Count > 0)
            {
                MailAddress from = new MailAddress("anp.application@anp.gov.md", "ANP-telefoane - obiecte interzise");
                MailAddress to;

                Regex regex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

                if (regex.IsMatch(textBoxTo.Text))
                {
                    to = new MailAddress(textBoxTo.Text);
                }
                else
                {
                    MessageBox.Show("Eroare - adresa destinatar este indicata gresit", "Expedierea listei de telefoane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MailMessage mail = new MailMessage(from, to);
                mail.Sender = from;

                mail.Subject = "no replay - Telefoane depistate la data: " + dateTimePicker1.Value.Date.ToString("dd.MM.yyyy");
                if (dateTimePicker2.Checked == true)
                {
                    mail.Subject += " - " + dateTimePicker2.Value.Date.ToString("dd.MM.yyyy");
                }

                mail.IsBodyHtml = true;
                string strbody = "Telefoane la data: " + dateTimePicker1.Value.Date.ToString("dd.MM.yyyy");

                if (dateTimePicker2.Checked == true)
                {
                    strbody += " - " + dateTimePicker2.Value.Date.ToString("dd.MM.yyyy");
                }

                strbody += "<br/><table border = \"1\"><tr><th>Data</th><th>IMEI</th><th>MODEL</th>";

                for (int i = 0; i < listViewRezultatCaut.Items.Count; i++)
                {
                    if (listViewRezultatCaut.Items[i].Text != "")
                        strbody += "<tr><td>" + listViewRezultatCaut.Items[i].SubItems[0].Text + "</td><td>" + listViewRezultatCaut.Items[i].SubItems[1].Text + "</td><td>" + listViewRezultatCaut.Items[i].SubItems[2].Text + "</td></tr>";
                }

                strbody += "</table>";
                mail.Body = strbody;

                SmtpClient client = new SmtpClient
                {
                    Host = "mail-anp.gov.md",
                    Port = 587,
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential("anp.application@anp.gov.md", "qiYktZY66SXhr41W83o8AB"),
                    Timeout = 3000
                };

                try
                {
                    client.Send(mail);
                }
                catch (SmtpFailedRecipientsException ex)
                {
                    for (int i = 0; i < ex.InnerExceptions.Length; i++)
                    {
                        SmtpStatusCode status = ex.InnerExceptions[i].StatusCode;
                        if (status == SmtpStatusCode.MailboxBusy ||
                            status == SmtpStatusCode.MailboxUnavailable || status == SmtpStatusCode.MailboxNameNotAllowed)
                        {
                            MessageBox.Show("Delivery failed - retrying in 5 seconds.");
                            System.Threading.Thread.Sleep(5000);
                            client.Send(mail);
                        }
                        else
                        {
                            MessageBox.Show(ex.InnerExceptions[i].FailedRecipient);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                MessageBox.Show("Mesajul a fost expediat cu succes", "Expedierea listei de telefoane", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Eroare - in lista nu este selectat nici un telefon mobil", "Expedierea listei de telefoane", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCautare_Click(object sender, EventArgs e)
        {
            listViewRezultatCaut.Items.Clear();

            if (connection.State != ConnectionState.Open)
                connection.Open();

            string query = "SELECT phone.DATEFOUND, phone.ID, phone.MODEL, phone.IMEI FROM Telephone AS phone WHERE ";
            string where = "";

            if (dateTimePicker2.Checked == true)
            {
                where += "phone.DATEFOUND BETWEEN @StartDate AND @EndDate ";
            }
            else
            {
                where += "phone.DATEFOUND = @StartDate ";
            }

            where += "AND phone.IMEI IS NOT NULL AND phone.IMEI <> '' ORDER BY phone.DATEFOUND";
            query += where;

            using (MySqlCommand cmdM = new MySqlCommand(query, connection))
            {
                cmdM.Parameters.AddWithValue("@StartDate", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
                if (dateTimePicker2.Checked == true)
                {
                    cmdM.Parameters.AddWithValue("@EndDate", dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"));
                }
                else
                {
                    cmdM.Parameters.AddWithValue("@EndDate", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
                }

                using (MySqlDataReader dr = cmdM.ExecuteReader())
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        listViewRezultatCaut.Items.Add(Convert.ToDateTime(dr["DATEFOUND"]).Date.ToString("dd.MM.yyyy"));
                        i = listViewRezultatCaut.Items.Count - 1;
                        listViewRezultatCaut.Items[i].SubItems[0].Name = dr["ID"].ToString();
                        listViewRezultatCaut.Items[i].SubItems.Add(dr["IMEI"].ToString());
                        listViewRezultatCaut.Items[i].SubItems.Add(dr["MODEL"].ToString());
                    }
                }
            }

            connection.Close();
            toolStripStatusLabelNrTelefoane.Text = listViewRezultatCaut.Items.Count.ToString();
        }
    }
}
