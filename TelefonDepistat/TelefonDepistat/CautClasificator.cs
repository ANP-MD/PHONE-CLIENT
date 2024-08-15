using MySql.Data.MySqlClient;

namespace TelefonDepistat
{
    public class CautClasificator
    {
        private Clasificator _clasificator;

        public CautClasificator(Clasificator clasificator)
        {
            this._clasificator = clasificator;
        }

        public MySqlDataReader GetValues()
        {
            return _clasificator.GetValues();
        }

        public void CloseConnection()
        {
            _clasificator.CloseConnection();
        }

        public void Add()
        {
            _clasificator.Add();
        }

        public void Edit(int id)
        {
            _clasificator.Edit(id);
        }

        public void Delete(int id)
        {
            _clasificator.Delete(id);
        }

        public MySqlDataReader Search(string paramSearch)
        {
            return _clasificator.Search(paramSearch);
        }
    }
}
