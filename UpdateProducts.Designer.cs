namespace SalesInventory
{
    partial class UpdateProducts
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textUpdateProductName = new System.Windows.Forms.TextBox();
            this.textUpdatePrice = new System.Windows.Forms.TextBox();
            this.textUpdateDiscount = new System.Windows.Forms.TextBox();
            this.btnUpdateSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1621, 379);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.875F);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(553, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Product";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textUpdateDiscount);
            this.groupBox1.Controls.Add(this.textUpdatePrice);
            this.groupBox1.Controls.Add(this.textUpdateProductName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(215, 481);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1175, 525);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Your Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.875F);
            this.label2.Location = new System.Drawing.Point(54, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.875F);
            this.label3.Location = new System.Drawing.Point(54, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 55);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.875F);
            this.label4.Location = new System.Drawing.Point(54, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 55);
            this.label4.TabIndex = 2;
            this.label4.Text = "Discount : ";
            // 
            // textUpdateProductName
            // 
            this.textUpdateProductName.Location = new System.Drawing.Point(493, 86);
            this.textUpdateProductName.Multiline = true;
            this.textUpdateProductName.Name = "textUpdateProductName";
            this.textUpdateProductName.Size = new System.Drawing.Size(515, 55);
            this.textUpdateProductName.TabIndex = 3;
            // 
            // textUpdatePrice
            // 
            this.textUpdatePrice.Location = new System.Drawing.Point(493, 230);
            this.textUpdatePrice.Multiline = true;
            this.textUpdatePrice.Name = "textUpdatePrice";
            this.textUpdatePrice.Size = new System.Drawing.Size(515, 55);
            this.textUpdatePrice.TabIndex = 4;
            // 
            // textUpdateDiscount
            // 
            this.textUpdateDiscount.Location = new System.Drawing.Point(493, 374);
            this.textUpdateDiscount.Multiline = true;
            this.textUpdateDiscount.Name = "textUpdateDiscount";
            this.textUpdateDiscount.Size = new System.Drawing.Size(515, 55);
            this.textUpdateDiscount.TabIndex = 5;
            // 
            // btnUpdateSave
            // 
            this.btnUpdateSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.btnUpdateSave.Location = new System.Drawing.Point(931, 1078);
            this.btnUpdateSave.Name = "btnUpdateSave";
            this.btnUpdateSave.Size = new System.Drawing.Size(351, 134);
            this.btnUpdateSave.TabIndex = 2;
            this.btnUpdateSave.Text = "Save";
            this.btnUpdateSave.UseVisualStyleBackColor = true;
            this.btnUpdateSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.button1.Location = new System.Drawing.Point(401, 1078);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(351, 134);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1627, 1281);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdateSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateProducts";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.UpdateProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUpdateDiscount;
        private System.Windows.Forms.TextBox textUpdatePrice;
        private System.Windows.Forms.TextBox textUpdateProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateSave;
        private System.Windows.Forms.Button button1;
    }
}