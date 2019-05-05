using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Application
{
    public partial class profilePage : UserControl
    {
        List<OrderObj> orders;
        DbConnection conn;
        int yA = 0;
        user u;
        public profilePage(user u)
        {
            InitializeComponent();
            userName.Text = u.getEmail();
            conn = new DbConnection();
            this.u = u;
            getAdresses();
            getOrders();

        }

        private void addNAF_Click(object sender, EventArgs e)
        {
            
            adress a = new adress(u.getUid(),this);
            a.Location = new Point(0,yA);
            adressP.Controls.Add(a);
            yA += 151;
        }
        public void getAdresses()
        {
            List<AdressObj> aol = conn.getAdress(u.getUid());
            int i;
            for(i=0;i<aol.Count;i++)
            {
                adress a = new adress(aol[i].getPid(),aol[i].getPid(),aol[i].getAdress());
                a.Location = new Point(0, yA);
                adressP.Controls.Add(a);
                yA += 151;
            }
        }
        public void reloadAdress()
        {
            adressP.Controls.Clear();
            yA = 0;
            getAdresses();
        }
        public void getOrders()
        {
           
            int y = 0;
            orders = conn.getUserOrders(u.getUid());
            int i;
            for (i = 0; i < orders.Count; i++)
            {
                adminViewOrder avo = new adminViewOrder(orders[i],u.isAdmin);
                avo.Location = new Point(0, y);
                y += 87;
                orderP.Controls.Add(avo);
            }
        }
    }
}

