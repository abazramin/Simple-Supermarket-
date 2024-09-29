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
    public partial class UpdateProducts : Form
    {

        int _ProductID;
        clsProducts clsProducts;
        public UpdateProducts(int ID)
        {

            InitializeComponent();
            _ProductID = ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateProducts_Load(object sender, EventArgs e)
        {
            clsProducts = clsProducts.Find(_ProductID);


            if (clsProducts != null)
            {
                textUpdateProductName.Text = clsProducts.ProductName;
                textUpdatePrice.Text = clsProducts.Price;
                textUpdateDiscount.Text = clsProducts.Discount;
            }


        }

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
               clsProducts = clsProducts.Find(_ProductID);

            if (clsProducts != null)
            {
                clsProducts.ProductName=textUpdateProductName.Text;
                clsProducts.Price =textUpdatePrice.Text;
                clsProducts.Discount = textUpdateDiscount.Text;

            }


            if (clsProducts.Save())
            {
                MessageBox.Show("Update Product [" + clsProducts.ID + "] was successfully", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {

                MessageBox.Show("Update Product [" + clsProducts.ID + "] was Faild", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
