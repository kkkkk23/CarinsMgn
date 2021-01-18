using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carins
{
    class Staffinfos
    {
        private string staccount;
        private string stpass;
        private string actype;

        public string Actype
        {
            get { return actype; }
            set { actype = value; }
        }
        public string Staccount
        {
            get { return staccount; }
            set { staccount = value; }
        }
        public string Stpass
        {
            get { return stpass; }
            set { stpass = value; }
        }
        public Staffinfos(string actype,string stacc,string stpass)
        {
            Actype = actype;
            Staccount = stacc;
            Stpass = stpass;
        }
    }
}
