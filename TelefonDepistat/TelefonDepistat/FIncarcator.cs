using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TelefonDepistat
{
    public partial class FIncarcator : Form
    {
        private MySqlConnection connection; // Changed to MySqlConnection
        public Charger chrg;
        private int idpenitenciar;

        public FIncarcator(MySqlConnection _connection)
        {
            InitializeComponent();
            connection = _connection;
            chrg = new Charger();
            idpenitenciar = -1; // Default value indicating no penitentiary selected
        }

        public FIncarcator(MySqlConnection _connection, DateTime _datefound, int _idpenitenciar, string _namepenitenciar)
        {
            InitializeComponent();
            connection = _connection;
            chrg = new Charger
            {
                DATEFOUND = _datefound,
                IDPRISON = _idpenitenciar
            };
            dateTimePickerDataDepistare.Value = _datefound;
            idpenitenciar = _idpenitenciar;
            textBoxPenitenciar.Text = _namepenitenciar;
        }

        private void buttonAcceptare_Click(object sender, EventArgs e)
        {
            // Validate input before assigning
            if (string.IsNullOrWhiteSpace(textBoxNumber.Text))
            {
                MessageBox.Show("Atentie! Nu ati introdus numarul incarcatorului", "Validare Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Assign values to the Charger object
            chrg.DATEFOUND = dateTimePickerDataDepistare.Value.Date;
            chrg.IDPRISON = idpenitenciar;
            chrg.NUMBER = textBoxNumber.Text.Trim();

            // Optionally, set the DialogResult to OK if you need to confirm successful entry
            this.DialogResult = DialogResult.OK;
        }
    }
}
