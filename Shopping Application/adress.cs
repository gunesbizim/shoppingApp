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
    public partial class adress : UserControl
    {
        string pid;
        string aid;
        string adressText;
        profilePage pp;
        public adress(string pid,profilePage pp)
        {
            InitializeComponent();
            this.pid = pid;
            aid = aidGenerator();
            this.pp = pp;
        }

        public adress(string pid, string aid,string adressText)
        {
            InitializeComponent();
            this.pid = pid;
            this.aid = aid;
            this.adressText = adressText;
            addBTT.Enabled = false;
            richTextBox1.Text = adressText;
            richTextBox1.Enabled = false;

        }
        private void addBTT_Click(object sender, EventArgs e)
        {
            DbConnection conn = new DbConnection();
            conn.sendCommand(conn.insertAdress(pid,richTextBox1.Text,aidGenerator()));
            pp.reloadAdress();
            richTextBox1.Enabled = false;
            addBTT.Enabled = false;
        }
        public String aidGenerator()
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
    }
}
