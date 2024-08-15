using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace TelefonDepistat
{
    class WBattery
    {
        protected MySqlConnection connection;
        protected MySqlDataReader dr;

        public WBattery(MySqlConnection _connection)
        {
            connection = _connection;
        }

        public Battery SelectBattById(int _id)
        {
            Battery batt = new Battery();

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SelectBattById", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Define and add parameter
                    cmd.Parameters.AddWithValue("p_ID", _id); // Ensure the parameter name matches the stored procedure

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows && dr.Read())
                        {
                            batt.DATEFOUND = Convert.ToDateTime(dr["DATEFOUND"]);
                            batt.ID = Convert.ToInt32(dr["ID"]);
                            batt.IDPRISON = Convert.ToInt32(dr["IDPRISON"]);
                            batt.NUMBER = dr["NUMBER"].ToString(); // Ensure this matches the column name from the procedure
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

            return batt;
        }


        public int Insert(Battery _bt)
        {
            int id = 0;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            using (MySqlCommand cmd = new MySqlCommand("InsertBattery", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Define and add parameters
                cmd.Parameters.Add(new MySqlParameter("p_DATEFOUND", MySqlDbType.DateTime) { Value = _bt.DATEFOUND });
                cmd.Parameters.Add(new MySqlParameter("p_IDPRISON", MySqlDbType.Int32) { Value = _bt.IDPRISON });
                cmd.Parameters.Add(new MySqlParameter("p_NUMBER", MySqlDbType.VarChar, 25) { Value = _bt.NUMBER });

                // Define output parameter
                MySqlParameter outputId = new MySqlParameter("p_ID", MySqlDbType.Int32)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputId);

                try
                {
                    cmd.ExecuteNonQuery();
                    id = Convert.ToInt32(cmd.Parameters["p_ID"].Value);
                }
                catch (Exception ex)
                {
                    // Log or handle the exception
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return id;
        }

    }
}
