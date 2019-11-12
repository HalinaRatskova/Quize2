using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quize2
{
    class User
    {
        private string fname;
        private string lname;
        private string tel;

        public User (string fname, string lname, string tel)
        {
            this.fname = fname;
            this.lname = lname;
            this.tel = tel;


        }
        private void setFname(string fname)
        {
            this.fname = fname;
        }

        private void setLname(string lname)
        {
            this.lname = lname;
        }

        private void setTel(string tel)
        {
            this.lname = tel;
        }

        public string getFname()
        {
            return this.fname;
        }

        public string getLname()
        {
            return this.lname;
        }

        public string getTel()
        {
            return this.tel;
        }


    }
}





