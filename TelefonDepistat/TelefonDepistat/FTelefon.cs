using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TelefonDepistat
{
    public partial class FTelefon : Form
    {
        private MySqlConnection connection;
        private FCautClasificator fcc;
        private Telephone phone;
        private SimCart smcart;
        private Charger chrg;
        private ClOwner clo;
        private Battery batt;
        private WTelefon wphone;

        public FTelefon(MySqlConnection _connection)
        {
            InitializeComponent();

            connection = _connection;

            phone = new Telephone();
            smcart = new SimCart();
            chrg = new Charger();
            batt = new Battery();
            clo = new ClOwner();

            wphone = new WTelefon(connection);
        }

        public FTelefon(MySqlConnection _connection, int _idtelefon)
        {
            InitializeComponent();

            connection = _connection;
            wphone = new WTelefon(connection);
            smcart = new SimCart();
            chrg = new Charger();
            batt = new Battery();
            clo = new ClOwner();

            phone = new Telephone();

            if (_idtelefon > 0)
            {
                phone = wphone.SelectPhoneById(_idtelefon);
            }

            InitForm();

        }

        private void InitForm()
        {
            dateTimePickerDateFound.Value = phone.DATEFOUND;
            textBoxModel.Text = phone.MODEL;
            textBoxColor.Text = phone.COLOR;
            textBoxImei.Text = phone.IMEI;
            checkBoxFunctioneaza.Checked = phone.FUNCTIONAL;

            // Set owner type based on phone's TYPEOWNER
            switch (phone.TYPEOWNER)
            {
                case 1:
                    radioButtondetinut.Checked = true;
                    break;
                case 2:
                    radioButtonPersCiv.Checked = true;
                    break;
                case 3:
                    radioButtonFaraStapin.Checked = true;
                    break;
            }

            // Set owner information if available
            if (phone.IDOWNER > 0)
            {
                try
                {
                    WOwner wown = new WOwner(connection);
                    clo = wown.SelectOwnerById(phone.IDOWNER);
                    textBoxNPPStapin.Text = $"{clo.NAME} {clo.PRENUME} {clo.PATRONIMIC} {clo.ANULNASTERII}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching owner details: {ex.Message}");
                }
            }

            textBoxLocDepistare.Text = phone.SPACEFOUND;

            // Set prison information if available
            if (phone.IDPRISON > 0)
            {
                try
                {
                    WPenitenciar wpen = new WPenitenciar(connection);
                    textBoxPenitenciar.Text = wpen.SelectPrisonById(phone.IDPRISON);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching prison details: {ex.Message}");
                }
            }

            // Set SIM card information if available
            if (phone.IDSIMCART >= 0)
            {
                try
                {
                    WSimCart wsim = new WSimCart(connection);
                    smcart = wsim.SelectSimById(phone.IDSIMCART);
                    textBoxSimCart.Text = $"{smcart.NRSIM} {smcart.OPERATOR} data {smcart.DATEFOUND.ToShortDateString()}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching SIM card details: {ex.Message}");
                }
            }

            // Set charger information if available
            if (phone.IDCHARGER >= 0)
            {
                try
                {
                    WIncarcator winc = new WIncarcator(connection);
                    chrg = winc.SelectChargerById(phone.IDCHARGER);
                    textBoxIncarcator.Text = $"{chrg.NUMBER} | {chrg.DATEFOUND:dd.MM.yyyy}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching charger details: {ex.Message}");
                }
            }

            // Set battery information if available
            if (phone.IDBATTERY >= 0)
            {
                try
                {
                    WBattery wbat = new WBattery(connection);
                    batt = wbat.SelectBattById(phone.IDBATTERY);
                    textBoxBatereie.Text = $"{batt.NUMBER} | {batt.DATEFOUND:dd.MM.yyyy}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching battery details: {ex.Message}");
                }
            }
        }


        private void buttonAcceptare_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxModel.Text) &&
                !string.IsNullOrWhiteSpace(textBoxImei.Text) &&
                !string.IsNullOrWhiteSpace(textBoxPenitenciar.Text))
            {
                phone.DATEFOUND = dateTimePickerDateFound.Value.Date;
                phone.MODEL = textBoxModel.Text;
                phone.COLOR = textBoxColor.Text;
                phone.IMEI = textBoxImei.Text;
                phone.FUNCTIONAL = checkBoxFunctioneaza.Checked;
                phone.SPACEFOUND = textBoxLocDepistare.Text;

                phone.TYPEOWNER = radioButtondetinut.Checked ? 1 :
                                   radioButtonPersCiv.Checked ? 2 : 3;

                if (phone.ID > 0)
                {
                    wphone.Update(phone);
                }
                else
                {
                    phone.ID = wphone.Insert(phone);
                }

                // Optionally set DialogResult here if needed
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Atentie! Nu au fost completate toate cimpurile necesare", "Adaugare telefon", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.None;
            }
        }

        private void buttonPenitenciar_Click(object sender, EventArgs e)
        {
            fcc = new FCautClasificator(new CautClasificator(new WPenitenciar(connection)));
            if (fcc.ShowDialog() == DialogResult.OK)
            {
                phone.IDPRISON = fcc.GetIdClasificator();
                textBoxPenitenciar.Text = fcc.GetDenumireClasificator();
            }
        }

        private void buttonOwnerNPP_Click(object sender, EventArgs e)
        {
            FOwner fo = new FOwner(connection);
            if (fo.ShowDialog() == DialogResult.OK)
            {
                phone.IDOWNER = fo.idowner;
                textBoxNPPStapin.Text = fo.nppowner;
            }
        }

        private void buttonAddSim_Click(object sender, EventArgs e)
        {
            FSimCart fsc = new FSimCart(connection, dateTimePickerDateFound.Value.Date, phone.IDPRISON, textBoxPenitenciar.Text);
            if (fsc.ShowDialog() == DialogResult.OK)
            {
                WSimCart wsc = new WSimCart(connection);
                smcart = fsc.smcart;
                phone.IDSIMCART = smcart.ID = wsc.Insert(smcart);
                textBoxSimCart.Text = $"{smcart.NRSIM} | {smcart.OPERATOR} | {smcart.DATEFOUND:dd.MM.yyyy}";
            }
        }

        private void buttonAddIncarcator_Click(object sender, EventArgs e)
        {
            FIncarcator finc = new FIncarcator(connection, dateTimePickerDateFound.Value.Date, phone.IDPRISON, textBoxPenitenciar.Text);
            if (finc.ShowDialog() == DialogResult.OK)
            {
                WIncarcator winc = new WIncarcator(connection);
                chrg = finc.chrg;
                phone.IDCHARGER = chrg.ID = winc.Insert(chrg);
                textBoxIncarcator.Text = $"{chrg.NUMBER} | {chrg.DATEFOUND:dd.MM.yyyy}";
            }
        }

        private void buttonBatereie_Click(object sender, EventArgs e)
        {
            FBatereie fbat = new FBatereie(connection, dateTimePickerDateFound.Value.Date, phone.IDPRISON, textBoxPenitenciar.Text);
            if (fbat.ShowDialog() == DialogResult.OK)
            {
                WBattery wbat = new WBattery(connection);
                batt = fbat.batt;
                phone.IDBATTERY = batt.ID = wbat.Insert(batt);
                textBoxBatereie.Text = $"{batt.NUMBER} | {batt.DATEFOUND:dd.MM.yyyy}";
            }
        }

        private void textBoxPenitenciar_TextChanged(object sender, EventArgs e)
        {
            // Handle text change events if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Handle label click events if needed
        }

        private void radioButtonFaraStapin_CheckedChanged(object sender, EventArgs e)
        {
            buttonOwnerNPP.Enabled = !radioButtonFaraStapin.Checked;
        }
    }
}
