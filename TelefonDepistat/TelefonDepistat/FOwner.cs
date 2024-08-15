using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;

namespace TelefonDepistat
{
    public partial class FOwner : Form
    {
        private MySqlConnection connection;
        public int idowner;
        public string nppowner;
        private WOwner wo;
        private ClOwner clo;

        public FOwner(MySqlConnection _connection)
        {
            InitializeComponent();
            connection = _connection;
            idowner = -1;
            nppowner = "";
            wo = new WOwner(connection);
            clo = new ClOwner();
        }

        private void FOwner_Load(object sender, EventArgs e)
        {
            textBoxNume.Text = "";
            textBoxPrenume.Text = "";
            textBoxPatronimic.Text = "";
            listViewRezultatCaut.Items.Clear();
        }

        private void buttonCautare_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxNume.Text) || !string.IsNullOrWhiteSpace(textBoxPrenume.Text))
            {
                listViewRezultatCaut.Items.Clear();
                idowner = -1;
                nppowner = "";

                clo.NAME = textBoxNume.Text.Trim();
                clo.PRENUME = textBoxPrenume.Text.Trim();
                clo.PATRONIMIC = textBoxPatronimic.Text.Trim();
                if (numericUpDownAnNastere.Value > 1940)
                    clo.ANULNASTERII = Convert.ToInt32(numericUpDownAnNastere.Value);

                List<ClOwner> ListOwner = wo.SelectOwner(clo);
                int j = 0;

                foreach (var owner in ListOwner)
                {
                    clo = owner;
                    var item = new ListViewItem(clo.NAME)
                    {
                        Name = clo.ID.ToString()
                    };
                    item.SubItems.Add(clo.PRENUME);
                    item.SubItems.Add(clo.PATRONIMIC);
                    item.SubItems.Add(clo.ANULNASTERII > 0 ? clo.ANULNASTERII.ToString() : "");

                    listViewRezultatCaut.Items.Add(item);
                    j++;
                }

                if (listViewRezultatCaut.Items.Count == 0)
                {
                    if (MessageBox.Show("In baza de date nu a fost gasita nici o coincidenta, \n Doriti sa inregistrati datele introduse ?", "Rezultatul Cautarii", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        clo.NAME = textBoxNume.Text.Trim();
                        clo.PRENUME = textBoxPrenume.Text.Trim();
                        clo.PATRONIMIC = textBoxPatronimic.Text.Trim();
                        if (numericUpDownAnNastere.Value > 1940)
                            clo.ANULNASTERII = Convert.ToInt32(numericUpDownAnNastere.Value);
                        clo.ID = wo.Insert(clo);

                        var item = new ListViewItem(clo.NAME)
                        {
                            Name = clo.ID.ToString()
                        };
                        item.SubItems.Add(clo.PRENUME);
                        item.SubItems.Add(clo.PATRONIMIC);
                        item.SubItems.Add(clo.ANULNASTERII > 0 ? clo.ANULNASTERII.ToString() : "");

                        listViewRezultatCaut.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("In baza de date sunt gasite: " + listViewRezultatCaut.Items.Count.ToString() + " coincidenta(e) !", "Rezultatul Cautarii", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Nu sunt suficiente date pentru cautare ", "Rezultatul Cautarii", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void listViewRezultatCaut_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewRezultatCaut.SelectedItems)
            {
                idowner = Convert.ToInt32(item.SubItems[0].Name);
                nppowner = item.SubItems[0].Text + " " + item.SubItems[1].Text + " " + item.SubItems[2].Text + " " + item.SubItems[3].Text;
                break;
            }
        }

        private void buttonAcceptare_Click(object sender, EventArgs e)
        {
            if (idowner <= 0)
            {
                MessageBox.Show("Nu este selectat nici un element din lista ", "Selectare Stapin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
