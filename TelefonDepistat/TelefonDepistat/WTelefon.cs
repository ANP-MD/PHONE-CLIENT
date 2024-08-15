using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace TelefonDepistat
{
    class WTelefon
    {
        protected MySqlConnection connection;
        protected MySqlDataReader dr;

        public WTelefon(MySqlConnection _connection)
        {
            connection = _connection;
        }

        public Telephone SelectPhoneById(int _id)
        {
            Telephone phone = new Telephone();

            // Ensure the connection is open
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            using (MySqlCommand cmd = new MySqlCommand("SelectPhoneById", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Clear any existing parameters
                cmd.Parameters.Clear();

                // Define and add parameters
                cmd.Parameters.Add(new MySqlParameter("p_ID", MySqlDbType.Int32) { Value = _id });

                try
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows && dr.Read())
                        {
                            phone.COLOR = dr["COLOR"].ToString();
                            phone.DATEFOUND = Convert.ToDateTime(dr["DATEFOUND"]);
                            phone.FUNCTIONAL = Convert.ToBoolean(dr["FUNCTIONAL"]);
                            phone.ID = Convert.ToInt32(dr["ID"]);
                            phone.IDBATTERY = Convert.ToInt32(dr["IDBATTERY"]);
                            phone.IDCHARGER = Convert.ToInt32(dr["IDCHARGER"]);
                            phone.IDOWNER = Convert.ToInt32(dr["IDOWNER"]);
                            phone.IDPRISON = Convert.ToInt32(dr["IDPRISON"]);
                            phone.IDSIMCART = Convert.ToInt32(dr["IDSIMCART"]);
                            phone.IMEI = dr["IMEI"].ToString();
                            phone.MODEL = dr["MODEL"].ToString();
                            phone.SPACEFOUND = dr["SPACEFOUND"].ToString();
                            phone.TYPEOWNER = Convert.ToInt32(dr["TYPEOWNER"]);
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

            return phone;
        }




        public int Update(Telephone _tlp)
        {
            int rowsAffected = 0;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            using (MySqlCommand cmd = new MySqlCommand("UpdateTelephone", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Define and add parameters with correct names
                cmd.Parameters.Add(new MySqlParameter("p_DATEFOUND", MySqlDbType.DateTime) { Value = _tlp.DATEFOUND });
                cmd.Parameters.Add(new MySqlParameter("p_IDPRISON", MySqlDbType.Int32) { Value = _tlp.IDPRISON });
                cmd.Parameters.Add(new MySqlParameter("p_MODEL", MySqlDbType.VarChar, 25) { Value = _tlp.MODEL });
                cmd.Parameters.Add(new MySqlParameter("p_COLOR", MySqlDbType.VarChar, 25) { Value = _tlp.COLOR });
                cmd.Parameters.Add(new MySqlParameter("p_IMEI", MySqlDbType.VarChar, 50) { Value = _tlp.IMEI });
                cmd.Parameters.Add(new MySqlParameter("p_FUNCTIONAL", MySqlDbType.Bit) { Value = _tlp.FUNCTIONAL });
                cmd.Parameters.Add(new MySqlParameter("p_TYPEOWNER", MySqlDbType.Int32) { Value = _tlp.TYPEOWNER });
                cmd.Parameters.Add(new MySqlParameter("p_IDOWNER", MySqlDbType.Int32) { Value = _tlp.IDOWNER });
                cmd.Parameters.Add(new MySqlParameter("p_SPACEFOUND", MySqlDbType.VarChar, 128) { Value = _tlp.SPACEFOUND });
                cmd.Parameters.Add(new MySqlParameter("p_IDSIMCART", MySqlDbType.Int32) { Value = (_tlp.IDSIMCART >= 0 ? (object)_tlp.IDSIMCART : DBNull.Value) });
                cmd.Parameters.Add(new MySqlParameter("p_IDCHARGER", MySqlDbType.Int32) { Value = (_tlp.IDCHARGER >= 0 ? (object)_tlp.IDCHARGER : DBNull.Value) });
                cmd.Parameters.Add(new MySqlParameter("p_IDBATTERY", MySqlDbType.Int32) { Value = (_tlp.IDBATTERY >= 0 ? (object)_tlp.IDBATTERY : DBNull.Value) });
                cmd.Parameters.Add(new MySqlParameter("p_ID", MySqlDbType.Int32) { Value = _tlp.ID });

                try
                {
                    rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    // Log or handle the exception
                    Console.WriteLine("MySQL Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return rowsAffected;
        }




        public int Insert(Telephone _tlp)
        {
            int id = 0;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            using (MySqlCommand cmd = new MySqlCommand("InsertTelephone", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Define and add parameters
                cmd.Parameters.Add(new MySqlParameter("p_DATEFOUND", MySqlDbType.DateTime) { Value = _tlp.DATEFOUND });
                cmd.Parameters.Add(new MySqlParameter("p_IDPRISON", MySqlDbType.Int32) { Value = _tlp.IDPRISON });
                cmd.Parameters.Add(new MySqlParameter("p_MODEL", MySqlDbType.VarChar, 25) { Value = _tlp.MODEL });
                cmd.Parameters.Add(new MySqlParameter("p_COLOR", MySqlDbType.VarChar, 25) { Value = _tlp.COLOR });
                cmd.Parameters.Add(new MySqlParameter("p_IMEI", MySqlDbType.VarChar, 50) { Value = _tlp.IMEI });
                cmd.Parameters.Add(new MySqlParameter("p_FUNCTIONAL", MySqlDbType.Bit) { Value = _tlp.FUNCTIONAL });
                cmd.Parameters.Add(new MySqlParameter("p_TYPEOWNER", MySqlDbType.Int32) { Value = _tlp.TYPEOWNER });
                cmd.Parameters.Add(new MySqlParameter("p_IDOWNER", MySqlDbType.Int32) { Value = _tlp.IDOWNER });
                cmd.Parameters.Add(new MySqlParameter("p_SPACEFOUND", MySqlDbType.VarChar, 128) { Value = _tlp.SPACEFOUND });
                cmd.Parameters.Add(new MySqlParameter("p_IDSIMCART", MySqlDbType.Int32) { Value = _tlp.IDSIMCART });
                cmd.Parameters.Add(new MySqlParameter("p_IDCHARGER", MySqlDbType.Int32) { Value = _tlp.IDCHARGER });
                cmd.Parameters.Add(new MySqlParameter("p_IDBATTERY", MySqlDbType.Int32) { Value = _tlp.IDBATTERY });

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

    }
}
