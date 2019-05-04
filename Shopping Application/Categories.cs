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
    public partial class Categories : UserControl
    {
        string oldCatName;
        public Categories()
        {
            InitializeComponent();
            processCats(); 
        }
           

        private void addCat_Click(object sender, EventArgs e)
        {
            //Search list, if cat exists messagebox otherwise add.
            if ((categoryExists(addCatNameTB.Text)))
            {
                DbConnection conn = new DbConnection();
                if (conn.sendCommand(conn.insertCategory(addCatNameTB.Text)))
                {
                    MessageBox.Show("Category added !");
                    categoriesLB.Items.Clear();
                    processCats(); // Can be optimized
                    addCatNameTB.Clear();
                }
                else
                {
                    MessageBox.Show("Category couldn't added !");
                }
            }
            else
            {
                MessageBox.Show("Category already exists !");
            }
            
        }
        public void processCats()
        {
            DbConnection conn = new DbConnection();
            List<string> categories = conn.getCategories();
            int size = categories.Count;
            int i;
            for (i = 0; i < size; i++)
            {
                categoriesLB.Items.Add(categories[i]);
            }
        }
        public bool categoryExists(string cat)
        {
            int i;
            bool existance = true;
            string s = cat;
            string test;
            Console.WriteLine(categoriesLB.Items.Count);
            for (i = 0; i < categoriesLB.Items.Count; i++)
            {
                test = categoriesLB.Items[i].ToString();
                Console.WriteLine(s+"/"+s);
                if (cat == test)
                    existance = false;    
            }   
            return existance;
        }

        private void apply_Click(object sender, EventArgs e)
        {
            
            if (categoryExists(catNameUpdateTB.Text))
            {
                DbConnection conn = new DbConnection();
                if (conn.sendCommand(conn.updateCategory(oldCatName, catNameUpdateTB.Text)))
                {
                    MessageBox.Show("Category updated !");
                    categoriesLB.Items.Clear();
                    processCats();
                    catNameUpdateTB.Clear();
                }
                else
                {
                    MessageBox.Show("Category couldn't updated !");
                }

            }
            else
            {
                MessageBox.Show("You have same category ! Category didn't updated !");
            }

        }

        private void categoriesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            catNameUpdateTB.Text = categoriesLB.Items[categoriesLB.SelectedIndex].ToString();
            oldCatName = catNameUpdateTB.Text;

        }
    }
    }

