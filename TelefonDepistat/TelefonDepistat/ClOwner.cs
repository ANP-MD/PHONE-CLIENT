namespace TelefonDepistat
{
    class ClOwner
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string PRENUME { get; set; }
        public string PATRONIMIC { get; set; }
        public int ANULNASTERII { get; set; }

        public ClOwner()
        {
            Init();
        }
        public void Init()
        {
            this.ID = -1;
            this.NAME = "";
            this.PRENUME = "";
            this.PATRONIMIC = "";
            this.ANULNASTERII = -1;
        }


    }
}
