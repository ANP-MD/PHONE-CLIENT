using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TelefonDepistat
{
    public partial class FormMainTelefon : Form
    {
        private ConnectorBD cbd;
        private MySqlConnection connection;
        private FTelefon ft;
        private WTelefon wt;
        private WSimCart wsc;
        private WBattery wbat;
        private WIncarcator winc;
        private FCautClasificator fcc;
        private int idpenitenciar;

        public FormMainTelefon()
        {
            InitializeComponent();
        }

        private void toolStripButtonAddTelefon_Click(object sender, EventArgs e)
        {
            ft = new FTelefon(connection);
            /* 
            wt = new WTelefon(connection);
            wsc = new WSimCart(connection);
            wbat = new WBattery(connection);
            winc = new WIncarcator(connection);

            SimCart smcrt = new SimCart();
            Battery batt = new Battery();
            Charger chrg = new Charger();
            */
            if (ft.ShowDialog() == DialogResult.OK)
            {
                /* 
                smcrt = ft.smcart;
                if (smcrt.IDPRISON > 0)
                {
                    ft.phone.IDSIMCART = smcrt.ID = wsc.Insert(smcrt);
                }

                batt = ft.batt;
                if (batt.IDPRISON > 0)
                {
                    ft.phone.IDBATTERY = batt.ID = wbat.Insert(batt);
                }

                chrg = ft.chrg;
                if (chrg.IDPRISON > 0)
                {
                    ft.phone.IDCHARGER = chrg.ID = winc.Insert(chrg);
                }

                ft.phone.ID = wt.Insert(ft.phone);
                */
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FLogare flog = new FLogare();
            if (flog.ShowDialog() == DialogResult.OK)
            {
                cbd = flog.GetConnectorBD();
                connection = cbd.GetConnectionBD();
            }
            else
            {
                this.Close();
                return;
            }
        }

        private void buttonPenitenciar_Click(object sender, EventArgs e)
        {
            fcc = new FCautClasificator(new CautClasificator(new WPenitenciar(connection)));
            if (fcc.ShowDialog() == DialogResult.OK)
            {
                idpenitenciar = fcc.GetIdClasificator();
                textBoxPenitenciar.Text = fcc.GetDenumireClasificator();
            }
        }

        private void buttonCautare_Click(object sender, EventArgs e)
        {
            listViewRezultatCaut.Items.Clear(); // Clear ListView items before populating

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            // Create command to fetch telephone records
            using (var cmdM = new MySqlCommand("SELECT phone.DATEFOUND, phone.ID, phone.MODEL, phone.COLOR, phone.IMEI, phone.TYPEOWNER, diviziune.NAME AS DIVIZIUNE " +
                                                "FROM Telephone AS phone " +
                                                "INNER JOIN Spr_Diviziune diviziune ON phone.IDPRISON = diviziune.ID " +
                                                "WHERE 1=1", connection))
            {
                // Clear previous parameters to avoid duplication issues
                cmdM.Parameters.Clear();

                // Add date range filter if needed
                if (dateTimePickerPer2.Checked)
                {
                    cmdM.CommandText += " AND phone.DATEFOUND BETWEEN @StartDate AND @EndDate";
                    cmdM.Parameters.AddWithValue("@StartDate", dateTimePickerPer1.Value.ToString("yyyy-MM-dd 00:00:00"));
                    cmdM.Parameters.AddWithValue("@EndDate", dateTimePickerPer2.Value.ToString("yyyy-MM-dd 23:59:59"));
                }
                else
                {
                    cmdM.CommandText += " AND phone.DATEFOUND = @StartDate";
                    cmdM.Parameters.AddWithValue("@StartDate", dateTimePickerPer1.Value.ToString("yyyy-MM-dd 00:00:00"));
                }

                // Add penitenciar filter if specified
                if (idpenitenciar > 0)
                {
                    cmdM.CommandText += " AND phone.IDPRISON = @IdPenitenciar";
                    cmdM.Parameters.AddWithValue("@IdPenitenciar", idpenitenciar);
                }

                // Add IMEI filter if specified
                if (!string.IsNullOrWhiteSpace(textBoxImei.Text))
                {
                    cmdM.CommandText += " AND phone.IMEI LIKE @Imei";
                    cmdM.Parameters.AddWithValue("@Imei", "%" + textBoxImei.Text.Trim() + "%");
                }

                // Finalize the query
                cmdM.CommandText += " ORDER BY phone.DATEFOUND";

                // Execute query and populate ListView
                using (var dr = cmdM.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        // Check for existing items with the same ID
                        bool alreadyAdded = false;
                        foreach (ListViewItem existingItem in listViewRezultatCaut.Items)
                        {
                            if (existingItem.Name == dr["ID"].ToString())
                            {
                                alreadyAdded = true;
                                break;
                            }
                        }

                        if (!alreadyAdded)
                        {
                            var item = new ListViewItem(Convert.ToDateTime(dr["DATEFOUND"]).Date.ToString("dd.MM.yyyy"))
                            {
                                Name = dr["ID"].ToString() // Store ID in Name property for later use
                            };
                            item.SubItems.Add("Model: " + dr["MODEL"].ToString() + " Color: " + dr["COLOR"].ToString() + " IMEI: " + dr["IMEI"].ToString());

                            int typeOwner = Convert.ToInt32(dr["TYPEOWNER"]);
                            if (typeOwner == 1)
                            {
                                item.SubItems.Add("Detinutul:");
                            }
                            else if (typeOwner == 2)
                            {
                                item.SubItems.Add("Persoana Civila:");
                            }
                            else
                            {
                                item.SubItems.Add("Fara Stapin");
                            }

                            item.SubItems.Add(dr["DIVIZIUNE"].ToString());
                            listViewRezultatCaut.Items.Add(item);
                        }
                    }
                }
            }

            // Fetch owner details for each item
            foreach (ListViewItem item in listViewRezultatCaut.Items)
            {
                using (var cmdOwner = new MySqlCommand("SELECT onpp.NAME AS NAME, onpp.PRENUME AS PRENUME, onpp.PATRONIMIC AS PATRONIMIC, onpp.ANULNASTERII AS ANULNASTERII " +
                                                        "FROM OwnerNPP AS onpp " +
                                                        "INNER JOIN Telephone AS phone ON phone.IDOWNER = onpp.ID " +
                                                        "WHERE phone.ID = @PhoneId", connection))
                {
                    cmdOwner.Parameters.Clear();
                    cmdOwner.Parameters.AddWithValue("@PhoneId", item.Name); // Use item.Name (which is the ID)

                    using (var drOwner = cmdOwner.ExecuteReader())
                    {
                        if (drOwner.Read())
                        {
                            // Append owner details to existing item
                            item.SubItems[2].Text += " " + drOwner["NAME"].ToString() + " " + drOwner["PRENUME"].ToString() + " " + drOwner["PATRONIMIC"].ToString() + " " + drOwner["ANULNASTERII"].ToString();
                        }
                    }
                }
            }

            connection.Close();
        }





        private void toolStripFindDuplicate_Click(object sender, EventArgs e)
        {
            listViewRezultatCaut.Items.Clear();

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            // Define the base query
            string query = @"
        SELECT phone.DATEFOUND, phone.ID, phone.MODEL, phone.COLOR, phone.IMEI, phone.TYPEOWNER, diviziune.NAME AS DIVIZIUNE
        FROM Telephone AS phone
        INNER JOIN Spr_Diviziune diviziune ON phone.IDPRISON = diviziune.ID
        WHERE 1 < (
            SELECT COUNT(*) FROM Telephone ph2
            WHERE phone.IMEI = ph2.IMEI AND phone.IMEI != ''
        )";

            // Add date filter if specified
            if (dateTimePickerPer2.Checked)
            {
                query += " AND phone.DATEFOUND BETWEEN @StartDate AND @EndDate";
            }
            else
            {
                query += " AND phone.DATEFOUND = @StartDate";
            }

            // Add penitenciar filter if specified
            if (idpenitenciar > 0)
            {
                query += " AND phone.IDPRISON = @IdPenitenciar";
            }

            // Add order by clause
            query += " ORDER BY phone.DATEFOUND";

            using (var cmdM = new MySqlCommand(query, connection))
            {
                // Add parameters for date filtering
                cmdM.Parameters.AddWithValue("@StartDate", dateTimePickerPer1.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                if (dateTimePickerPer2.Checked)
                {
                    cmdM.Parameters.AddWithValue("@EndDate", dateTimePickerPer2.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                }

                // Add parameter for penitenciar filter if specified
                if (idpenitenciar > 0)
                {
                    cmdM.Parameters.AddWithValue("@IdPenitenciar", idpenitenciar);
                }

                using (MySqlDataReader dr = cmdM.ExecuteReader())
                {
                    listViewRezultatCaut.Items.Clear();
                    int i = 0;
                    while (dr.Read())
                    {
                        var item = new ListViewItem(Convert.ToDateTime(dr["DATEFOUND"]).Date.ToString("dd.MM.yyyy"))
                        {
                            Name = dr["ID"].ToString()
                        };
                        item.SubItems.Add("model:" + dr["MODEL"].ToString() + " culoare:" + dr["COLOR"].ToString() + " IMEI:" + dr["IMEI"].ToString());

                        // Replace switch with if-else statements for TYPEOWNER
                        int typeOwner = Convert.ToInt32(dr["TYPEOWNER"]);
                        string ownerType = "";
                        if (typeOwner == 1)
                        {
                            ownerType = "Detinutul:";
                        }
                        else if (typeOwner == 2)
                        {
                            ownerType = "Persoana Civila:";
                        }
                        else
                        {
                            ownerType = "Fara Stapin";
                        }
                        item.SubItems.Add(ownerType);

                        item.SubItems.Add(dr["DIVIZIUNE"].ToString());
                        listViewRezultatCaut.Items.Add(item);
                        i++;
                    }
                }
            }

            for (int j = 0; j < listViewRezultatCaut.Items.Count; j++)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                var phoneId = listViewRezultatCaut.Items[j].Name;
                var queryOwner = @"
            SELECT onpp.NAME AS NAME, onpp.PRENUME AS PRENUME, onpp.PATRONIMIC AS PATRONIMIC, onpp.ANULNASTERII AS ANULNASTERII
            FROM Telephone AS phone
            INNER JOIN OwnerNPP AS onpp ON phone.IDOWNER = onpp.ID
            WHERE phone.ID = @PhoneId";

                using (var cmdOwner = new MySqlCommand(queryOwner, connection))
                {
                    cmdOwner.Parameters.AddWithValue("@PhoneId", phoneId);

                    using (MySqlDataReader drOwner = cmdOwner.ExecuteReader())
                    {
                        while (drOwner.Read())
                        {
                            listViewRezultatCaut.Items[j].SubItems[2].Text += $" {drOwner["NAME"]} {drOwner["PRENUME"]} {drOwner["PATRONIMIC"]} {drOwner["ANULNASTERII"]}";
                        }
                    }
                }
            }

            connection.Close();
        }


        private void toolStripButtonRaportToEmail_Click(object sender, EventArgs e)
        {
            FRaportToEmail fraptoe = new FRaportToEmail(connection);
            fraptoe.ShowDialog();
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewRezultatCaut.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listViewRezultatCaut.Items.Count; i++)
                {
                    if (listViewRezultatCaut.Items[i].Selected == true)
                    {
                        ft = new FTelefon(connection, Convert.ToInt32(listViewRezultatCaut.Items[i].SubItems[0].Name));
                        ft.ShowDialog();
                        break;
                    }
                }
            }
        }
    }
}
