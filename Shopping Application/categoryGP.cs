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
    public partial class categoryGP : UserControl
    {
        Label l;
        Form1 f1;
        string catName;
        public categoryGP(string name,Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            l = category;
            l.Text = name;
            catName = name;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DbConnection conn = new DbConnection();
            CatView catv = new CatView(f1,catName);
            catv.Location= new Point(0,0);
            f1.disposeFunc(f1.getFirstChild());
            f1.returnContainer().Controls.Add(catv);
        }
    }
}
