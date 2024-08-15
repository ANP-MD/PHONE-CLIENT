using MySql.Data.MySqlClient;

namespace TelefonDepistat
{
    public abstract class Clasificator
    {
        // Method to get values, returning a MySqlDataReader
        public abstract MySqlDataReader GetValues();

        // Method to close the connection
        public abstract void CloseConnection();

        // Method to add a new record
        public abstract void Add();

        // Method to edit an existing record by ID
        public abstract void Edit(int id);

        // Method to delete a record by ID
        public abstract void Delete(int id);

        // Method to search records by a search parameter
        public abstract MySqlDataReader Search(string searchParam);
    }
}
