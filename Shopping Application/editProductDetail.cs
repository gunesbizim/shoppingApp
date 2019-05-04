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
    public partial class editProductDetail : UserControl
    {
        editProduct ep;
        public editProductDetail(string key,string value,editProduct ep)
        {
            InitializeComponent();
            this.ep = ep;
            label1.Text = key;
            textBox1.Text = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ep.addToNewDictionary(label1.Text,textBox1.Text);
        }
    }
}
