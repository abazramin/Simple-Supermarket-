using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesInventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowAllProduct_Click(object sender, EventArgs e)
        {
            AllProduct allProduct = new AllProduct();
            allProduct.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (textProductName.Text == string.Empty && textPrice.Text == string.Empty && textDiscount.Text == string.Empty )
            {

                MessageBox.Show("Plase Enter The Value", "Message for you" , MessageBoxButtons.OK , MessageBoxIcon.Stop);

                return;
            }


            clsProducts clsLogic = new clsProducts();

            clsLogic.ProductName = textProductName.Text;
            clsLogic.Price = textPrice.Text;
            clsLogic.Discount = textDiscount.Text;

            if (clsLogic.Save())
            {
                MessageBox.Show("Successfully Add New Product", "Message For You", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textProductName.Clear();
                textPrice.Clear();
                textDiscount.Clear();
            }
            else
            {
                MessageBox.Show("Failed to Add New Product", "Message For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            int number = Convert.ToInt32(textSearch.Text);


            //if (number == null)
            //{
            //    MessageBox.Show("Plase Enter The Number ID", "Message For You", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //    return;
            //}

            clsProducts products = clsProducts.Find(number);


            if (products != null)
            {
                MessageBox.Show("Product ID is [" + products.ID + "]  Found  , was Name Is ["+products.ProductName+"] !", "Message For You", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textSearch.Clear();
            }
            else
            {
                MessageBox.Show("Prodcut Is Not Found", "Message For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
