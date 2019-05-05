using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Application
{
    class AdressObj
    {
        string pid;
        string aid;
        string adress;
        public AdressObj()
        {

        }
        public AdressObj(string pid,string aid,string adress)
        {
            this.pid = pid;
            this.aid = aid;
            this.adress = adress;
        }
        public void setPid(string pid)
        {
            this.pid = pid;
        }
        public void setAid(string aid)
        {
            this.aid = aid;
        }
        public void setAdress(string adress)
        {
            this.adress = adress;
        }
        public string getPid()
        {
            return pid;
        }
        public string getAid()
        {
            return aid;
        }
        public string getAdress()
        {
            return adress;
        }
        public override string ToString()
        {
            return adress;
        }
    }
}
