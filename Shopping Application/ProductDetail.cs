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
    public partial class ProductDetail : UserControl
    {
        
        Panel p;
        int y;
        
        adminAddProduct aap;
        public ProductDetail(Panel p1,int y1, Dictionary<string,string> item,adminAddProduct aap)
        {
            InitializeComponent();
            p = p1;
            y = y1+60;
            this.aap = aap;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isEmpty(keyTb, valueTb))
            {
                this.Enabled = false;
                try
                {
                    
                    aap.item.Add(keyTb.Text, valueTb.Text);
                    ProductDetail pd = new ProductDetail(aap.panel1, y, aap.item,aap);
                    p.Controls.Add(pd);
                    pd.Location = new Point(0, y);
                }
                catch(Exception a)
                {
                    MessageBox.Show("You can not add same Property !");
                    this.Enabled = true;
                    Console.WriteLine("Error " + a.Message);
                }
                
            }else
            {
                MessageBox.Show("Propterty and/or value fields can not be empty!");
            }     
        }
        public bool isEmpty(TextBox a, TextBox b)
        {
            if(a.Text.Length==0 || b.Text.Length == 0){
                return false;
            }else
            {
                return true;
            }
               
        }
    }
}
