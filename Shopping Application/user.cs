using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Application
{
    public class user
    {
        public String eMail;
        public String password;
        public String uid;
        public bool isAdmin;
        public string admin;
        
        public user()
        {
            this.eMail = eMail;
            this.password = password;
            this.uid = uid;
            this.isAdmin = isAdmin;

        }

        public user(String email, String password,String uid,Boolean isAdmin)
        {
            this.eMail = email;
            this.password = password;
            this.uid = uid;
            this.isAdmin = isAdmin;

        }
        public void setEmail(String email)
        {
            eMail = email;
        }
        public void setPassword(String password)
        {
            this.password = password;
        }
        public void setUid(String uid)
        {
            this.uid = uid;
        }
        public String getEmail()
        {
            return eMail;
        }
        public String getPassword()
        {
            return password;
        }
        public String getUid()
        {
            return uid;
        }
        
        public bool isUserAdmin(string admin)
        {
            if (admin == "True")
            {
                isAdmin = true;
            }else
            {
                isAdmin = false;
            }
               
            return isAdmin;
        }
        public bool isUserAdmin()
        {
            return isAdmin;
        }
    }
}
