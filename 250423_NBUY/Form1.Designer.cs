﻿namespace _250423_NBUY
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
            this.LstKategori = new System.Windows.Forms.ListBox();
            this.LstUrunler = new System.Windows.Forms.ListBox();
            this.LstTedarikci = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LstKategori
            // 
            this.LstKategori.FormattingEnabled = true;
            this.LstKategori.Location = new System.Drawing.Point(236, 37);
            this.LstKategori.Name = "LstKategori";
            this.LstKategori.Size = new System.Drawing.Size(240, 290);
            this.LstKategori.TabIndex = 0;
            // 
            // LstUrunler
            // 
            this.LstUrunler.FormattingEnabled = true;
            this.LstUrunler.Location = new System.Drawing.Point(12, 37);
            this.LstUrunler.Name = "LstUrunler";
            this.LstUrunler.Size = new System.Drawing.Size(197, 290);
            this.LstUrunler.TabIndex = 1;
            // 
            // LstTedarikci
            // 
            this.LstTedarikci.FormattingEnabled = true;
            this.LstTedarikci.Location = new System.Drawing.Point(503, 37);
            this.LstTedarikci.Name = "LstTedarikci";
            this.LstTedarikci.Size = new System.Drawing.Size(264, 290);
            this.LstTedarikci.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstTedarikci);
            this.Controls.Add(this.LstUrunler);
            this.Controls.Add(this.LstKategori);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstKategori;
        private System.Windows.Forms.ListBox LstUrunler;
        private System.Windows.Forms.ListBox LstTedarikci;
    }
}

