using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_MANGEMENT_SYSYEM.Classes
{
    class ATMMachine
    {
        private int id;
        private int code;
        private string location;

        public int getId() { return id; }
        public void setId(int id) { this.id = id; }

        public int getCode() { return code; }
        public void setCode(int code) { this.code = code; }

        public string getLocation() { return location; }
        public void setLocation(string location) { this.location = location; }

 
        public void verificataion()
        {
            Console.WriteLine(" verify is done ....");
        }

    }
}
