using System;

namespace TelefonDepistat
{
    public class SimCart
    {
        public int ID { get; set; }
        public DateTime DATEFOUND { get; set; }
        public int IDPRISON { get; set; }
        public string OPERATOR { get; set; }
        public string NRSIM { get; set; }

        public SimCart()
        {
            Init();
        }
        public void Init()
        {
            this.ID = -1;
            this.DATEFOUND = new DateTime();
            this.IDPRISON = -1;
            this.OPERATOR = "";
            this.NRSIM = "";
        }


    }
}
