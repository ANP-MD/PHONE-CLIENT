using System;
using MySql.Data.MySqlClient; // Use MySql.Data.MySqlClient for MySQL
using System.Windows.Forms;

namespace TelefonDepistat
{
    public partial class FBatereie : Form
    {
        private MySqlConnection connection; // Changed to MySqlConnection
        public Battery batt;
        private int idpenitenciar;

        public FBatereie(MySqlConnection _connection)
        {
            InitializeComponent();
            connection = _connection;
            batt = new Battery();
            idpenitenciar = -1; // Default value indicating no penitentiary selected
        }

        public FBatereie(MySqlConnection _connection, DateTime _datefound, int _idpenitenciar, string _namepenitenciar)
        {
            InitializeComponent();
            connection = _connection;
            batt = new Battery
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
                MessageBox.Show("Atentie! Nu ati introdus numarul bateriei", "Validare Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Assign values to the Battery object
            batt.DATEFOUND = dateTimePickerDataDepistare.Value.Date;
            batt.IDPRISON = idpenitenciar;
            batt.NUMBER = textBoxNumber.Text.Trim();

            // Optionally, set the DialogResult to OK if you need to confirm successful entry
            this.DialogResult = DialogResult.OK;
        }
    }
}
