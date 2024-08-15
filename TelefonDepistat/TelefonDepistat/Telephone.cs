using System;

namespace TelefonDepistat
{
    public class Telephone
    {
        public int ID { get; set; }
        public DateTime DATEFOUND { get; set; }
        public int IDPRISON { get; set; }
        public string MODEL { get; set; }
        public string COLOR { get; set; }
        public string IMEI { get; set; }
        public bool FUNCTIONAL { get; set; }
        public int TYPEOWNER { get; set; }
        public int IDOWNER { get; set; }
        public string SPACEFOUND { get; set; }
        public int IDSIMCART { get; set; }
        public int IDCHARGER { get; set; }
        public int IDBATTERY { get; set; }


        public Telephone()
        {
            Init();
        }
        public void Init()
        {
            this.ID = -1;
            this.DATEFOUND = new DateTime();
            this.IDPRISON = -1;
            this.MODEL = "";
            this.COLOR = "";
            this.IMEI = "";
            this.FUNCTIONAL = false;
            this.TYPEOWNER = -1;
            this.IDOWNER = -1;
            this.SPACEFOUND = "";
            this.IDSIMCART = -1;
            this.IDCHARGER = -1;
            this.IDBATTERY = -1;
        }


    }
}
