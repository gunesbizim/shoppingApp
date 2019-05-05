using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Application
{
    public class OrderObj
    {
        string oid;
        string uid;
        string details;
        int status;

        public OrderObj()
        {
            status = 0;
        }
        public OrderObj(string oid,string uid,string details,int status)
        {
            this.oid = oid;
            this.uid = uid;
            this.details = details;
            this.status = status;
        }
        public void setOid(string oid)
        {
            this.oid = oid;
        }
        public void setStatus(int status)
        {
            this.status = status;
        }
        public void setUid(string uid)
        {
            this.uid = uid;
        }
        public void setDetails(string details)
        {
            this.details = details;
        }
        public string getOid()
        {
            return oid;
        }
        public string getUid()
        {
            return uid;
        }
        public string getDetails()
        {
            return details;
        }
        public int getStatus()
        {
            return status;
        }
    }
}
