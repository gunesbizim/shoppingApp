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
    public partial class adminViewOrder : UserControl
    {
        DbConnection conn;
        OrderObj o;
        public adminViewOrder(OrderObj o)
        {
            InitializeComponent();
            this.o = o;
            conn = new DbConnection();        
            oid.Text = o.getOid();
            uid.Text = o.getUid();
            details.Text = o.getDetails();
            setCB();
        }
        public adminViewOrder(OrderObj o, bool isAdmin)
        {
            InitializeComponent();
            this.o = o;
            conn = new DbConnection();
            oid.Text = o.getOid();
            uid.Text = o.getUid();
            details.Text = o.getDetails();
            setCB();
            update.Visible = false;
            deleteOrder.Visible = false;
            comboBox1.Enabled = false;
        }

        private void deleteOrder_Click(object sender, EventArgs e)
        {          
            if (conn.sendCommand(conn.deleteOrder(o.getOid())) == true)
            {
                MessageBox.Show("Order deleted !");
                deleteOrder.Enabled = false;
                update.Enabled = false;
            }else
                MessageBox.Show("Oops something went wrong :( !");         
        }

        public void setCB()
        {
            comboBox1.Items.Add("Pending Payment");
            comboBox1.Items.Add("Pending Shipment");
            comboBox1.Items.Add("Shipment");
            comboBox1.Items.Add("Send");

            if (o.getStatus() == 0)
                comboBox1.SelectedIndex = 0;
            else if (o.getStatus() == 1)
                comboBox1.SelectedIndex = 1;
            else if (o.getStatus() == 2)
                comboBox1.SelectedIndex = 2;
            else
                comboBox1.SelectedIndex = 3;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (conn.sendCommand(conn.updateOrders(o.getOid(), comboBox1.SelectedIndex)) == true)
                MessageBox.Show("Order updated !");
            else
                MessageBox.Show("Oops something went wrong :( !");
        }
    }
}

