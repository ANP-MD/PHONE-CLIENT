using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace TelefonDepistat
{
    class WSimCart
    {
        protected MySqlConnection connection;
        protected MySqlDataReader dr;

        public WSimCart(MySqlConnection _connection)
        {
            connection = _connection;
        }

        public SimCart SelectSimById(int _id)
        {
            SimCart sc = new SimCart();

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SelectSimCartById", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Define and add parameter
                    cmd.Parameters.AddWithValue("p_ID", _id); // Ensure the parameter name matches the stored procedure

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows && dr.Read())
                        {
                            sc.DATEFOUND = Convert.ToDateTime(dr["DATEFOUND"]);
                            sc.ID = Convert.ToInt32(dr["ID"]);
                            sc.IDPRISON = Convert.ToInt32(dr["IDPRISON"]);
                            sc.NRSIM = dr["NRSIM"].ToString();
                            sc.OPERATOR = dr["OPERATOR"].ToString();
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

            return sc;
        }


        public int Insert(SimCart _sc)
        {
            int id = 0;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            using (MySqlCommand cmd = new MySqlCommand("InsertSimCart", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Add parameters to the command
                cmd.Parameters.Add(new MySqlParameter("p_DATEFOUND", MySqlDbType.DateTime) { Value = _sc.DATEFOUND });
                cmd.Parameters.Add(new MySqlParameter("p_IDPRISON", MySqlDbType.Int32) { Value = _sc.IDPRISON });
                cmd.Parameters.Add(new MySqlParameter("p_NRSIM", MySqlDbType.VarChar, 25) { Value = _sc.NRSIM });
                cmd.Parameters.Add(new MySqlParameter("p_OPERATOR", MySqlDbType.VarChar, 25) { Value = _sc.OPERATOR });

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
