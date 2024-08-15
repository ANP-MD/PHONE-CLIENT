using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace TelefonDepistat
{
    public partial class FCautClasificator : Form
    {
        private string denumire;
        private int idCautareClasificator;
        private CautClasificator itemclasificator;

        public FCautClasificator(CautClasificator _cautclasificator)
        {
            InitializeComponent();
            idCautareClasificator = -1;
            denumire = "";
            itemclasificator = _cautclasificator;
        }

        private void SearchValue()
        {
            if (!string.IsNullOrEmpty(toolStripTextBoxCautCautareClasificator.Text))
            {
                denumire = toolStripTextBoxCautCautareClasificator.Text + "%";
                MySqlDataReader dr = itemclasificator.Search(denumire);

                int i = 0;
                listViewCautareClasificator.Items.Clear();
                while (dr.Read())
                {
                    listViewCautareClasificator.Items.Add(dr["denumire"].ToString());
                    listViewCautareClasificator.Items[i].SubItems.Add(dr["id"].ToString());
                    i++;
                }
                dr.Close();
                itemclasificator.CloseConnection();
                if (listViewCautareClasificator.Items.Count > 0)
                {
                    listViewCautareClasificator.Items[0].Selected = true;
                }
            }
            else
            {
                MessageBox.Show("Eroare ! - Nu este indicat nici un parametru de cautare.", "Cautare clasificator",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonCautCautareClasificator_Click(object sender, EventArgs e)
        {
            SearchValue();
        }

        public int GetIdClasificator()
        {
            return idCautareClasificator;
        }

        public string GetDenumireClasificator()
        {
            return denumire;
        }

        private void listViewCautareClasificator_Click(object sender, EventArgs e)
        {
            if (listViewCautareClasificator.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewCautareClasificator.SelectedItems)
                {
                    idCautareClasificator = Convert.ToInt32(item.SubItems[1].Text);
                    denumire = item.Text;
                    break;
                }
            }
        }

        private void listViewCautareClasificator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCautareClasificator.SelectedItems.Count <= 0)
            {
                idCautareClasificator = 0;
                denumire = "";
            }
            else
            {
                foreach (ListViewItem item in listViewCautareClasificator.SelectedItems)
                {
                    idCautareClasificator = Convert.ToInt32(item.SubItems[1].Text);
                    denumire = item.Text;
                    break;
                }
            }
        }

        private void buttonAcceptare_Click(object sender, EventArgs e)
        {
            if (idCautareClasificator <= 0)
            {
                MessageBox.Show("Eroare: nu a fost selectat nici un element din lista", "Cautare Clasificator",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void listViewCautareClasificator_DoubleClick(object sender, EventArgs e)
        {
            buttonAcceptare_Click(sender, e);
        }

        private void FCautClasificator_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            itemclasificator.Add();
            FCautClasificator_Load(sender, e);
        }

        private void toolStripTextBoxCautCautareClasificator_Click(object sender, EventArgs e)
        {
            toolStripTextBoxCautCautareClasificator.SelectAll();
        }

        private void toolStripTextBoxCautCautareClasificator_KeyUp(object sender, KeyEventArgs e)
        {
            SearchValue();
        }

        private void toolStripTextBoxCautCautareClasificator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                listViewCautareClasificator.Focus();
            }
        }

        private void listViewCautareClasificator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonAcceptare.Focus();
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (listViewCautareClasificator.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Sunteti sigur ca doriti sa stergeti Obiectul Selectat din Baza de Date?", "Stergerea Obiectului din Baza de Date",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (ListViewItem item in listViewCautareClasificator.SelectedItems)
                    {
                        idCautareClasificator = Convert.ToInt32(item.SubItems[1].Text);
                        itemclasificator.Delete(idCautareClasificator);

                        listViewCautareClasificator.Items.Remove(item);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Atentie ! - Nu este selectata nici un element din lista", "Stergerea unui Element din lista",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripEdit_Click(object sender, EventArgs e)
        {
            if (listViewCautareClasificator.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewCautareClasificator.SelectedItems)
                {
                    idCautareClasificator = Convert.ToInt32(item.SubItems[1].Text);
                    itemclasificator.Edit(idCautareClasificator);

                    FCautClasificator_Load_1(sender, e);
                    break;
                }
            }
            else
            {
                MessageBox.Show("Atentie ! - Nu este selectata nici un element din lista", "Stergerea unui Element din lista",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FCautClasificator_Load_1(object sender, EventArgs e)
        {
            listViewCautareClasificator.Items.Clear();

            // Selectarea tuturor CautareClasificatorelor si afisarea lor in lista
            MySqlDataReader dr = itemclasificator.GetValues();

            int i = 0;
            while (dr.Read())
            {
                listViewCautareClasificator.Items.Add(dr["denumire"].ToString());
                listViewCautareClasificator.Items[i].SubItems.Add(dr["id"].ToString());

                i++;
            }
            dr.Close();
            itemclasificator.CloseConnection();
        }
    }
}
