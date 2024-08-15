using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic; // Use System.Collections.Generic for List<T>
using System.Data;

namespace TelefonDepistat
{
    class WOwner
    {
        protected MySqlConnection connection;
        protected MySqlDataReader dr;

        public WOwner(MySqlConnection _connection)
        {
            connection = _connection;
        }

        public int Insert(ClOwner _clw)
        {
            int id = 0;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            using (MySqlCommand cmd = new MySqlCommand("InsertOwner", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Define and add parameters
                cmd.Parameters.Add(new MySqlParameter("p_NAME", MySqlDbType.VarChar, 32) { Value = _clw.NAME });
                cmd.Parameters.Add(new MySqlParameter("p_PRENUME", MySqlDbType.VarChar, 32) { Value = _clw.PRENUME });
                cmd.Parameters.Add(new MySqlParameter("p_PATRONIMIC", MySqlDbType.VarChar, 25) { Value = _clw.PATRONIMIC });
                cmd.Parameters.Add(new MySqlParameter("p_ANULNASTERII", MySqlDbType.Int32) { Value = _clw.ANULNASTERII });

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
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return id;
        }


        public List<ClOwner> SelectOwner(ClOwner _clw)
        {
            List<ClOwner> ListOwner = new List<ClOwner>();

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            using (MySqlCommand cmd = new MySqlCommand("SelectOwner", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Define and add parameters with matching names
                cmd.Parameters.Add(new MySqlParameter("p_NAME", MySqlDbType.VarChar, 32) { Value = (object)_clw.NAME ?? DBNull.Value });
                cmd.Parameters.Add(new MySqlParameter("p_PRENUME", MySqlDbType.VarChar, 32) { Value = (object)_clw.PRENUME ?? DBNull.Value });
                cmd.Parameters.Add(new MySqlParameter("p_PATRONIMIC", MySqlDbType.VarChar, 25) { Value = (object)_clw.PATRONIMIC ?? DBNull.Value });

                try
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ClOwner clw = new ClOwner
                            {
                                ID = Convert.ToInt32(dr["ID"]),
                                NAME = dr["NAME"].ToString(),
                                PRENUME = dr["PRENUME"].ToString(),
                                PATRONIMIC = dr["PATRONIMIC"].ToString(),
                                ANULNASTERII = Convert.ToInt32(dr["ANULNASTERII"])
                            };
                            ListOwner.Add(clw);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    // Log or handle the MySQL-specific error
                    Console.WriteLine("MySQL Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Log or handle other errors
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    // Ensure the connection is closed
                    connection.Close();
                }
            }

            return ListOwner;
        }



        public ClOwner SelectOwnerById(int _idowner)
        {
            ClOwner clo = new ClOwner();

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            using (MySqlCommand cmd = new MySqlCommand("SelectOwnerById", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Define and add parameters
                cmd.Parameters.AddWithValue("p_ID", _idowner);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows && dr.Read())
                    {
                        clo.ID = Convert.ToInt32(dr["ID"]);
                        clo.NAME = dr["NAME"].ToString();
                        clo.PRENUME = dr["PRENUME"].ToString();
                        clo.PATRONIMIC = dr["PATRONIMIC"].ToString();
                        clo.ANULNASTERII = Convert.ToInt32(dr["ANULNASTERII"]);
                    }
                }
            }

            connection.Close();

            return clo;
        }


    }
}
