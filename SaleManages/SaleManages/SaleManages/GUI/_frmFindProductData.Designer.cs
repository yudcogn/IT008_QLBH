﻿namespace SaleManages.GUI
{
    partial class _frmFindProductData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmFindProductData));
            this.lbFindproData = new System.Windows.Forms.Label();
            this.tbFindproData = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFindproData = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFindproData
            // 
            this.lbFindproData.AutoSize = true;
            this.lbFindproData.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFindproData.Location = new System.Drawing.Point(54, 131);
            this.lbFindproData.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbFindproData.Name = "lbFindproData";
            this.lbFindproData.Size = new System.Drawing.Size(185, 37);
            this.lbFindproData.TabIndex = 0;
            this.lbFindproData.Text = "Tên sản phẩm:";
            // 
            // tbFindproData
            // 
            this.tbFindproData.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFindproData.Location = new System.Drawing.Point(258, 125);
            this.tbFindproData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbFindproData.Name = "tbFindproData";
            this.tbFindproData.Size = new System.Drawing.Size(434, 43);
            this.tbFindproData.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnFindproData);
            this.panel1.Controls.Add(this.tbFindproData);
            this.panel1.Controls.Add(this.lbFindproData);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 298);
            this.panel1.TabIndex = 1;
            // 
            // btnFindproData
            // 
            this.btnFindproData.BackColor = System.Drawing.Color.White;
            this.btnFindproData.color = System.Drawing.Color.White;
            this.btnFindproData.colorActive = System.Drawing.Color.LightSkyBlue;
            this.btnFindproData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindproData.Font = new System.Drawing.Font("Segoe UI Light", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindproData.ForeColor = System.Drawing.Color.Black;
            this.btnFindproData.Image = ((System.Drawing.Image)(resources.GetObject("btnFindproData.Image")));
            this.btnFindproData.ImagePosition = 15;
            this.btnFindproData.ImageZoom = 50;
            this.btnFindproData.LabelPosition = 0;
            this.btnFindproData.LabelText = "";
            this.btnFindproData.Location = new System.Drawing.Point(706, 98);
            this.btnFindproData.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFindproData.Name = "btnFindproData";
            this.btnFindproData.Size = new System.Drawing.Size(100, 108);
            this.btnFindproData.TabIndex = 35;
            this.btnFindproData.Click += new System.EventHandler(this.btnFindproData_Click_1);
            // 
            // _frmFindProductData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 306);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "_frmFindProductData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm sản phẩm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbFindproData;
        public System.Windows.Forms.TextBox tbFindproData;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton btnFindproData;
    }
}