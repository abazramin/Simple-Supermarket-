namespace SalesInventory
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.textDiscount = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textProductName = new System.Windows.Forms.TextBox();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbNameProduct = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowAllProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Location = new System.Drawing.Point(10, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1691, 302);
            this.panel1.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Cornsilk;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.875F);
            this.lbTitle.Location = new System.Drawing.Point(447, 86);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new System.Windows.Forms.Padding(20);
            this.lbTitle.Size = new System.Drawing.Size(826, 116);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "SuperMarket Mangement";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.textDiscount);
            this.gbInfo.Controls.Add(this.textPrice);
            this.gbInfo.Controls.Add(this.textProductName);
            this.gbInfo.Controls.Add(this.lbDiscount);
            this.gbInfo.Controls.Add(this.lbPrice);
            this.gbInfo.Controls.Add(this.lbNameProduct);
            this.gbInfo.Location = new System.Drawing.Point(123, 443);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(1051, 420);
            this.gbInfo.TabIndex = 1;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Mangment Information";
            // 
            // textDiscount
            // 
            this.textDiscount.Location = new System.Drawing.Point(382, 280);
            this.textDiscount.Multiline = true;
            this.textDiscount.Name = "textDiscount";
            this.textDiscount.Size = new System.Drawing.Size(459, 54);
            this.textDiscount.TabIndex = 5;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(382, 185);
            this.textPrice.Multiline = true;
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(459, 53);
            this.textPrice.TabIndex = 4;
            // 
            // textProductName
            // 
            this.textProductName.Location = new System.Drawing.Point(382, 90);
            this.textProductName.Multiline = true;
            this.textProductName.Name = "textProductName";
            this.textProductName.Size = new System.Drawing.Size(459, 53);
            this.textProductName.TabIndex = 3;
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.lbDiscount.Location = new System.Drawing.Point(75, 295);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(153, 39);
            this.lbDiscount.TabIndex = 2;
            this.lbDiscount.Text = "Discount";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.lbPrice.Location = new System.Drawing.Point(75, 199);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(97, 39);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "Price";
            // 
            // lbNameProduct
            // 
            this.lbNameProduct.AutoSize = true;
            this.lbNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.lbNameProduct.Location = new System.Drawing.Point(75, 104);
            this.lbNameProduct.Name = "lbNameProduct";
            this.lbNameProduct.Size = new System.Drawing.Size(239, 39);
            this.lbNameProduct.TabIndex = 0;
            this.lbNameProduct.Text = "Product Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1294, 443);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(292, 112);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1294, 823);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(292, 112);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowAllProduct
            // 
            this.btnShowAllProduct.Location = new System.Drawing.Point(1294, 633);
            this.btnShowAllProduct.Name = "btnShowAllProduct";
            this.btnShowAllProduct.Size = new System.Drawing.Size(292, 112);
            this.btnShowAllProduct.TabIndex = 4;
            this.btnShowAllProduct.Text = "Show All Product";
            this.btnShowAllProduct.UseVisualStyleBackColor = true;
            this.btnShowAllProduct.Click += new System.EventHandler(this.btnShowAllProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.label1.Location = new System.Drawing.Point(163, 991);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search By ID :";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(421, 984);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(459, 53);
            this.textSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.btnSearch.Location = new System.Drawing.Point(929, 984);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(220, 53);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 1346);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowAllProduct);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lbNameProduct;
        private System.Windows.Forms.TextBox textDiscount;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textProductName;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowAllProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}

