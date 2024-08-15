using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace TelefonDepistat
{
    public partial class FSimCart : Form
    {
        private MySqlConnection connection;
        private FCautClasificator fcc;
        public SimCart smcart;
        private int idpenitenciar;
        private string objoperator;

        public FSimCart(MySqlConnection _connection)
        {
            InitializeComponent();
            connection = _connection;
            smcart = new SimCart();
            idpenitenciar = -1;
            objoperator = "";
        }

        public FSimCart(MySqlConnection _connection, DateTime _datefound, int _idpenitenciar, string _namepenitenciar)
        {
            InitializeComponent();
            connection = _connection;
            smcart = new SimCart();
            smcart.DATEFOUND = _datefound;
            smcart.IDPRISON = _idpenitenciar;
            dateTimePickerAch1.Value = _datefound;
            idpenitenciar = _idpenitenciar;

            textBoxPenitenciar.Text = _namepenitenciar;

            objoperator = "";
        }

        private void buttonPenitenciar_Click(object sender, EventArgs e)
        {
            fcc = new FCautClasificator(new CautClasificator(new WPenitenciar(connection)));
            if (fcc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                smcart.IDPRISON = fcc.GetIdClasificator();
                textBoxPenitenciar.Text = fcc.GetDenumireClasificator();
            }
        }

        private void buttonAcceptare_Click(object sender, EventArgs e)
        {
            smcart.DATEFOUND = dateTimePickerAch1.Value.Date;
            smcart.IDPRISON = idpenitenciar;
            smcart.OPERATOR = comboBoxOperator.Text;
            smcart.NRSIM = textBoxNrSim.Text.Trim();
        }
    }
}
