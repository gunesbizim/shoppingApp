using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Application
{
    public partial class Form1 : Form
    {

        public Boolean logedIn = false;
        private Boolean isAdmin = false;
        GroupBox container;
        public user u;
        public List<Product> cartList;
        MainPage mp;
        int totalPrice;
        public Form1()
        {
            InitializeComponent();
            u = new user(); 
            container = new GroupBox();
            this.Controls.Add(container);
            container.Location = new Point(1, 61);
            container.AutoSize = true;
            mp = new MainPage(this);
            mp.Location = new Point(0, 0);
            container.Controls.Add(mp);
            userMenuPref();
            cartList = new List<Product>();

        }
        // Function gets the first child of the group box and returns it. 
        public UserControl getFirstChild()
        {
            var children = container.Controls.OfType<UserControl>();
            UserControl c = children.Min();
            return c;
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
            }catch(Exception e)
            {
                Console.WriteLine("Error : " + e.Message);
            }          
        }

        private void appname_Click(object sender, EventArgs e)
        {       
            try
            {
                if (this.getFirstChild().GetType().ToString() != mp.GetType().ToString())
                {
                    disposeFunc(this.getFirstChild());
                    mp = new MainPage(this);
                    
                    container.Controls.Add(mp);
                }
            }
            catch (Exception a){
                Console.WriteLine("Error : " + a.Message);
            }      
        }
     
        //If user log' s in sets boolean as true.
        private void setLogIn()
        {
            logedIn = true;
        }
        private void userMenuPref()
        {
            if (logedIn==true)
            {
                if (isAdmin == true)
                {
                    userMenu.Items.Add("Admin Panel");
                    userMenu.Items.Add("Account");
                    userMenu.Items.Add("Log Out");
                }else
                {
                    userMenu.Items.Add("Account");
                    userMenu.Items.Add("Log Out");
                }
                
            }
            else
            {
                userMenu.Items.Add("Log In");
            }
        }
        private void userMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            if (logedIn == false)
            {
                Log_In logInForm = new Log_In(this);
                logInForm.Show();
                this.Hide();
            }
            else
            {
                int index = userMenu.Items.IndexOf(e.ClickedItem);

                if (isAdmin==true)
                {
                    if (index == 0)
                    {
                        disposeFunc(getFirstChild());
                        adminPanel ap = new adminPanel(this);
                        container.Controls.Add(ap);
                    }
                    else if (index == 1)
                    {
                        disposeFunc(getFirstChild());
                        profilePage pp = new profilePage(u);
                        container.Controls.Add(pp);
                    }
                    else
                    {
                        Application.Restart();
                    }
                }
                else
                {
                    if (index == 0)
                    {
                        disposeFunc(getFirstChild());
                        profilePage pp = new profilePage(u);
                        container.Controls.Add(pp);
                    }
                    else
                    {
                        Application.Restart();
                    }
                }
                    
                
            }
        }
        public GroupBox returnContainer()
        {
            return container;
        }
        public void addToContainer(UserControl u)
        {
            container.Controls.Add(u);
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            if (!(u.getEmail() == null))
            {
                username_label.Text = u.getEmail();
                logedIn = true;
                isAdmin = u.isUserAdmin();
                userMenu.Items.Clear();
                userMenuPref();
            }          
        }

        private void cartImage_Click(object sender, EventArgs e)
        {
            this.disposeFunc(getFirstChild());
            Cart cart = new Cart(cartList, this);
            container.Controls.Add(cart);

        }
        public bool checkChild()
        {
            if (!(this.getFirstChild().IsDisposed))
            {

                return true;
            }
            else
            {
                return false;
            }

        }
        public void addToCart(Product p)
        {
            cartList.Add(p);
        }
        public void clearCart()
        {
            cartList.Clear();
            cart_total_price_label.Text = "0";
            cart_item_count_label.Text = "0";
        }
        public void updateCartPreview(Product p)
        {

            totalPrice += p.getPrice();
            cart_total_price_label.Text = totalPrice.ToString();
            int i;
            int totalCount=0;
            for (i = 0; i < cartList.Count; i++)
            {
                totalCount += cartList[i].getProductCount();
            }
            cart_item_count_label.Text = totalCount.ToString();
        }       
    }
}
