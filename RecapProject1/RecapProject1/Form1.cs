using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ListProduct()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.ToList();
            }
        }
        private void ListCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cbxkategori.DataSource = context.Categories.ToList();
                cbxkategori.DisplayMember = "CategoryName";
                cbxkategori.ValueMember = "CategoryID";
            }
        }        
        private void ListProductsByCategory(int categoryıd)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p=>p.CategoryId==categoryıd).ToList();

            }
        }
        private void ListProductsByName(string productname)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(productname.ToLower())).ToList();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListCategories();
            ListProduct();
        }

        private void cbxkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductsByCategory(Convert.ToInt32(cbxkategori.SelectedValue));
            }
            catch 
            {

                
            }
            
        }

        private void tbxsearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbxsearch.Text;
            if (string.IsNullOrEmpty(key))
            {
                ListProduct();
            }
            else
            {
                ListProductsByName(key);
            }
            
        }
    }
}
