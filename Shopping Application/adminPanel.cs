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
    public partial class adminPanel : UserControl
    {   
        public Form1 f2;
        Boolean isNull = false;
        Categories cat;
        Orders ord;
        adminProduct apro;
        adminAddProduct aap;
        public adminPanel(Form1 f1)
        {
            InitializeComponent();
            aap = new adminAddProduct();
            aap.Location = new Point(200, 50);
            this.Controls.Add(aap);
            
        }
        
        
        private void menu_products_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!isNull)
            {
                disposeFunc(this.getFirstChild());
                apro = new adminProduct();
                apro.Location = new Point(200, 50);
                this.Controls.Add(apro);
                pageName.Text = "Products";
            }else
            {
                apro = new adminProduct();
                apro.Location = new Point(200, 50);
                this.Controls.Add(apro);
                pageName.Text = "Products";
            }
            
        }

        private void menu_AddProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!isNull)
            {
                disposeFunc(this.getFirstChild());
                aap = new adminAddProduct();
                aap.Location = new Point(200, 50);
                try { 
                this.Controls.Add(aap);
                pageName.Text = "Add Product";
                }catch(Exception ex)
                {
                    adminAddProduct aap = new adminAddProduct();
                    aap.Location = new Point(200, 50);
                    this.Controls.Add(aap);
                    pageName.Text = "Add Product";
                }
            }
            else
            {
                aap = new adminAddProduct();
                aap.Location = new Point(200, 50);
                this.Controls.Add(aap);
                pageName.Text = "Add Product";
            }
            

        }

        private void menu_Cat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!isNull)
            {
                disposeFunc(this.getFirstChild());
                cat = new Categories();
                cat.Location = new Point(200, 50);
                this.Controls.Add(cat);
                pageName.Text = "Categories";
            }else
            {
                cat = new Categories();
                cat.Location = new Point(200, 50);
                this.Controls.Add(cat);
                pageName.Text = "Categories";
            }
            

        }

        private void menu_orders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!isNull)
            {
                disposeFunc(this.getFirstChild());
                ord = new Orders();
                ord.Location = new Point(200, 50);
                this.Controls.Add(ord);
                pageName.Text = "Orders";
            }else
            {
                ord = new Orders();
                ord.Location = new Point(200, 50);
                this.Controls.Add(ord);
                pageName.Text = "Orders";

            }
        }

        // Function gets the first child of the group box and returns it. 
        public UserControl getFirstChild()
        {
            try
            {
                var children = this.Controls.OfType<UserControl>();
                UserControl c = children.Min();
                return c;  
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
                UserControl a = new UserControl();
                a.Name = "Null";
                isNull = true;
                return a;
            }
        }
        public void disposeFunc(UserControl u) //This function helps us to provide memory leak.
        {
            /*It won't throw exception even panel disposed once.
            Function Dispose() releases memory for current item. 
            Which means when user changed panel previous panel will dispose 
            so it won't use memory anymore.*/
            try
            {
                u.Dispose();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
            

        }


    }
}
