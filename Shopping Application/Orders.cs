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
    public partial class Orders : UserControl
    {
        List<OrderObj> orders;
        DbConnection conn;
        public Orders()
        {
            InitializeComponent();
            conn = new DbConnection();
            displayOrders();
        }
        public void displayOrders()
        {
            int y = 0;
            orders = conn.getAllOrders();
            int i;
            for (i = 0; i < orders.Count; i++)
            {
                adminViewOrder avo = new adminViewOrder(orders[i]);
                avo.Location = new Point(0,y);
                y += 87;
                panel1.Controls.Add(avo);
            }
        }

    }
}
