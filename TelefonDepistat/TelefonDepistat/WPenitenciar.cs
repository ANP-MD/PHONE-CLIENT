using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace TelefonDepistat
{
    class WPenitenciar : Clasificator
    {
        protected MySqlConnection connection;
        protected MySqlDataReader dr;
        protected int id;
        protected string denumire;

        public WPenitenciar(MySqlConnection _connection)
        {
            connection = _connection;
        }

        
        public override void CloseConnection()
        {
            if (dr != null && !dr.IsClosed) dr.Close();
            connection.Close();
            id = 0;
            denumire = "";
        }
        

        public override MySqlDataReader GetValues()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("SelectPenitenciar", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            dr = cmd.ExecuteReader();
            return dr;
        }

        public string SelectPrisonById(int _id)
        {
            string prison = "";

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SelectPrisonById", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Define and add parameter
                    cmd.Parameters.AddWithValue("p_ID", _id); // Ensure the parameter name matches the stored procedure

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows && dr.Read())
                        {
                            prison = dr["Name"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (logging, rethrowing, etc.)
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return prison;
        }


        public override void Add()
        {
            // Code for adding a new record would go here, if needed
        }

        public override void Edit(int _id)
        {
            // Code for editing a record would go here, if needed
        }

        public override void Delete(int _id)
        {
            // Code for deleting a record would go here, if needed
        }

        public override MySqlDataReader Search(string _paramsearch)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("SelectDiviziuneSPByDenumire", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlParameter denumireParam = new MySqlParameter("@Denumire", MySqlDbType.VarChar);
            denumireParam.Value = _paramsearch;
            cmd.Parameters.Add(denumireParam);

            dr = cmd.ExecuteReader();

            return dr;
        }

        public string SelectDenumireById(int _id)
        {
            string denumire = "";

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
                connection.Open();

            MySqlCommand cmd = new MySqlCommand("SelectDiviziuneSPById", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            MySqlParameter idParam = new MySqlParameter("@IdDiviziune", MySqlDbType.Int32);
            idParam.Value = _id;
            cmd.Parameters.Add(idParam);

            dr = cmd.ExecuteReader();

            if (dr.Read() && !dr.IsDBNull(0))
            {
                denumire = dr["denumire"].ToString();
            }
            connection.Close();

            return denumire;
        }
    }
}
