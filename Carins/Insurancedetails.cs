using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carins
{
    class Insurancedetails
    {
        private int rcid;

        public int Rcid
        {
            get { return rcid; }
            set { rcid = value; }
        }
        private string cusname;

        public string Cusname
        {
            get { return cusname; }
            set { cusname = value; }
        }
        private string carnum;

        public string Carnum
        {
            get { return carnum; }
            set { carnum = value; }
        }
        private string cusphone;

        public string Cusphone
        {
            get { return cusphone; }
            set { cusphone = value; }
        }
        private string instype;

        public string Instype
        {
            get { return instype; }
            set { instype = value; }
        }
        private int carprice;

        public int Carprice
        {
            get { return carprice; }
            set { carprice = value; }
        }
        private string fayear;

        public string Fayear
        {
            get { return fayear; }
            set { fayear = value; }
        }
        private string ncd;

        public string Ncd
        {
            get { return ncd; }
            set { ncd = value; }
        }
        private string stdate;

        public string Stdate
        {
            get { return stdate; }
            set { stdate = value; }
        }
        private int sum;

        public int Sum
        {
            get { return sum; }
            set { sum = value; }
        }
        private string enddate;

        public string Enddate
        {
            get { return enddate; }
            set { enddate = value; }
        }

        public Insurancedetails(int rcid,string cusname,string carnum,string cusphone,
            int carprice,string instype,string fayear,
            string ncd,int sum,string stdate,string endate) {
                Rcid = rcid;
                Cusname = cusname;
                Carnum = carnum;
                Cusphone = cusphone;
                Carprice = carprice;
                Instype = instype;
                Fayear = fayear;
                Ncd = ncd;
                Sum = sum;
                Stdate = stdate;
                Enddate = endate;
        }
    }
}
