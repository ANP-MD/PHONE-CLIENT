using System;

namespace TelefonDepistat
{
    public class Charger
    {
        public int ID { get; set; }
        public DateTime DATEFOUND { get; set; }
        public int IDPRISON { get; set; }
        public string NUMBER { get; set; }

        public Charger()
        {
            Init();
        }
        public void Init()
        {
            this.ID = -1;
            this.DATEFOUND = new DateTime();
            this.IDPRISON = -1;
            this.NUMBER = "";
        }


    }
}
