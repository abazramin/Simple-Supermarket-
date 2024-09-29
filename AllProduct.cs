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
    public partial class AllProduct : Form
    {
        public AllProduct()
        {
            InitializeComponent();
        }


        private void _RefrechAllProdcut()
        {
            dgvAllProduct.DataSource = clsProducts.GetAllProduct();
        }

        private void AllProduct_Load(object sender, EventArgs e)
        {
            _RefrechAllProdcut();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Delate ["+ dgvAllProduct.CurrentRow.Cells[0].Value + "]" , "Delete Product" , MessageBoxButtons.OKCancel , MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsProducts.DeleteProduct((int)dgvAllProduct.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Delete Product ID [" + dgvAllProduct.CurrentRow.Cells[0].Value + "] was successfully", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefrechAllProdcut();
                }
                else
                {
                    MessageBox.Show("Failed To Delate Products", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProducts updateProducts = new UpdateProducts((int)dgvAllProduct.CurrentRow.Cells[0].Value);
            updateProducts.ShowDialog();
            _RefrechAllProdcut();
        }
    }
}
