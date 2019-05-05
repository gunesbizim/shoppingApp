using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Application
{
    public partial class Log_In : Form
    {
        public user us;
        public Form1 f1Copy;
        public Log_In(Form1 f1)
        {
            InitializeComponent();
            f1Copy = f1;
            
            
        }


        // https://stackoverflow.com/questions/11313205/generate-a-unique-id
        public String uidGenerator()
        {
            StringBuilder builder = new StringBuilder();
            Enumerable
               .Range(65, 26)
                .Select(e => ((char)e).ToString())
                .Concat(Enumerable.Range(97, 26).Select(e => ((char)e).ToString()))
                .Concat(Enumerable.Range(0, 10).Select(e => e.ToString()))
                .OrderBy(e => Guid.NewGuid())
                .Take(12)
                .ToList().ForEach(e => builder.Append(e));
            string id = builder.ToString();
            return id;  
        }

        public Boolean checkEmail(String email)
        {
            Regex r = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (!(r.IsMatch(email)))
            {
                MessageBox.Show("Please enter a valid e-mail !");
                return false;
            }
            else
            {
                return true;
            }
        }   

        public Boolean checkPassword(String password)
        {

            Regex r = new Regex(@"^[a - zA - Z]\w{ 3,14}$");
            if (!(r.IsMatch(password)))
            {
                MessageBox.Show("The password's first character must be a letter, it must contain at least 4 characters and no more than 15 characters and no characters other than letters, numbers and the underscore may be used.");
                return false;
            }
            else
            {
                return true;
            }
            

        }
        
       public user returnUser(user us)
        {
            return us;
        }

        

        private void signUpBt_Click(object sender, EventArgs e)
        {
            if (checkEmail(eMailTb.Text))
            {
                DbConnection conn = new DbConnection();
                if (conn.checkEmailIsRegistered(eMailTb.Text))
                {
                    String uid = uidGenerator();
                    user us2 = new user(eMailTb.Text, passwordTb.Text, uid, false);

                    Console.WriteLine(conn.insertUserCmd(us2.getUid(), us2.getEmail(), us2.getPassword(), us2.isUserAdmin()));
                    conn.sendCommand(conn.insertUserCmd(us2.getUid(), us2.getEmail(), us2.getPassword(), us2.isUserAdmin()));
                    this.Hide();
                    MessageBox.Show("Successfully loged in !");
                    Form1 f2 = f1Copy;
                    f2.u = us2;
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("This e-mail is already registered !");
                }
                

            }
           
        }

        private void logInBt_Click(object sender, EventArgs e)
        {
            if (!isEmpty(eMailLogIn, eMailTb))
            {
                //Check boxes empty or not !
                DbConnection conn = new DbConnection();
                string[] a;
                string email = eMailLogIn.Text;
                string password = PasswordLogIn.Text;
                a = conn.getUserCmd(email);
                user b = new user();
                try
                {
                    b.setUid(a[0]);
                    b.setEmail(a[1]);
                    b.setPassword(a[2]);
                    b.isUserAdmin(a[3]);
                }catch(Exception err)
                {
                    Console.WriteLine("Error : " + err.Message);
                }
                
                us = b;

                if (eMailLogIn.Text == us.getEmail() && PasswordLogIn.Text == us.getPassword())
                {
                    this.Hide();
                    //Clear textboxes !
                    MessageBox.Show("Successfully loged in !");
                    Form1 f2 = f1Copy;
                    f2.u = us;
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("E-Mail or Password is incorrect !");
                }
            }
            else
            {
                MessageBox.Show("Email or password field can not be empty !");
            }
           
        }
        public void disposeFunc(UserControl u) //This function helps us to provide memory leak.
        {
            /*It won't throw exception even panel disposed once.
            Function Dispose() releases memory for current item. 
            Which means when user changed panel previous panel will dispose 
            so it won't use memory anymore.*/
            u.Dispose();

        }
        public bool isEmpty(TextBox a,TextBox b)
        {
            if (a.TextLength != 0 && b.TextLength!=0)
                return true;
            else
                return false;
        }

        private void Log_In_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 f2 = f1Copy;
            f2.Show();
            this.Dispose();
        }
    }
}

