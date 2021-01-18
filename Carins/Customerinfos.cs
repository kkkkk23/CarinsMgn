using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carins
{
    class Customerinfos
    {
       // private int rcid;
        private string cusname;
        private string carnum;
        private string cusphone;
        private int carprice;
        /*public int Rcid
        {
            get { return rcid; }
            set { rcid = value; }
        }*/
        public string Cusname
        {
            get { return cusname; }
            set { cusname = value; }
        }
        public string Carnum
        {
            get { return carnum; }
            set { carnum = value; }
        }
        public string Cusphone
        {
            get { return cusphone; }
            set { cusphone = value; }
        }
        public int Carprice
        {
            get { return carprice; }
            set { carprice = value; }
        }
        public Customerinfos(string cusname, string carnum, string cusphone, int carprice)
        {
            //Rcid = rcid;
            Cusname = cusname;
            Carnum = carnum;
            Cusphone = cusphone;
            Carprice = carprice;
        }
    }
}
