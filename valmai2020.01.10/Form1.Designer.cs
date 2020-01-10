namespace valmai2020._01._10
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblmarka = new System.Windows.Forms.Label();
            this.lbltipusa = new System.Windows.Forms.Label();
            this.lblara = new System.Windows.Forms.Label();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.textBoxTipusa = new System.Windows.Forms.TextBox();
            this.buttonModosit = new System.Windows.Forms.Button();
            this.buttonUJ = new System.Windows.Forms.Button();
            this.buttonTorol = new System.Windows.Forms.Button();
            this.numericAr = new System.Windows.Forms.NumericUpDown();
            this.dataGridTelefonok = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTelefonok)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericAr);
            this.groupBox1.Controls.Add(this.buttonTorol);
            this.groupBox1.Controls.Add(this.buttonUJ);
            this.groupBox1.Controls.Add(this.buttonModosit);
            this.groupBox1.Controls.Add(this.textBoxTipusa);
            this.groupBox1.Controls.Add(this.textBoxMarka);
            this.groupBox1.Controls.Add(this.lblara);
            this.groupBox1.Controls.Add(this.lbltipusa);
            this.groupBox1.Controls.Add(this.lblmarka);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott telefon Adatai";
            // 
            // lblmarka
            // 
            this.lblmarka.AutoSize = true;
            this.lblmarka.Location = new System.Drawing.Point(-3, 35);
            this.lblmarka.Name = "lblmarka";
            this.lblmarka.Size = new System.Drawing.Size(36, 13);
            this.lblmarka.TabIndex = 0;
            this.lblmarka.Text = "márka";
            // 
            // lbltipusa
            // 
            this.lbltipusa.AutoSize = true;
            this.lbltipusa.Location = new System.Drawing.Point(215, 35);
            this.lbltipusa.Name = "lbltipusa";
            this.lbltipusa.Size = new System.Drawing.Size(39, 13);
            this.lbltipusa.TabIndex = 1;
            this.lbltipusa.Text = "Tipusa";
            // 
            // lblara
            // 
            this.lblara.AutoSize = true;
            this.lblara.Location = new System.Drawing.Point(430, 35);
            this.lblara.Name = "lblara";
            this.lblara.Size = new System.Drawing.Size(22, 13);
            this.lblara.TabIndex = 2;
            this.lblara.Text = "ára";
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(0, 80);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarka.TabIndex = 4;
            // 
            // textBoxTipusa
            // 
            this.textBoxTipusa.Location = new System.Drawing.Point(218, 80);
            this.textBoxTipusa.Name = "textBoxTipusa";
            this.textBoxTipusa.Size = new System.Drawing.Size(100, 20);
            this.textBoxTipusa.TabIndex = 5;
            // 
            // buttonModosit
            // 
            this.buttonModosit.Location = new System.Drawing.Point(218, 134);
            this.buttonModosit.Name = "buttonModosit";
            this.buttonModosit.Size = new System.Drawing.Size(75, 23);
            this.buttonModosit.TabIndex = 6;
            this.buttonModosit.Text = "Módosit";
            this.buttonModosit.UseVisualStyleBackColor = true;
            // 
            // buttonUJ
            // 
            this.buttonUJ.Location = new System.Drawing.Point(6, 134);
            this.buttonUJ.Name = "buttonUJ";
            this.buttonUJ.Size = new System.Drawing.Size(75, 23);
            this.buttonUJ.TabIndex = 7;
            this.buttonUJ.Text = "ÚJ";
            this.buttonUJ.UseVisualStyleBackColor = true;
            this.buttonUJ.Click += new System.EventHandler(this.buttonUJ_Click);
            // 
            // buttonTorol
            // 
            this.buttonTorol.Location = new System.Drawing.Point(433, 134);
            this.buttonTorol.Name = "buttonTorol";
            this.buttonTorol.Size = new System.Drawing.Size(75, 23);
            this.buttonTorol.TabIndex = 8;
            this.buttonTorol.Text = "Töröl";
            this.buttonTorol.UseVisualStyleBackColor = true;
            this.buttonTorol.Click += new System.EventHandler(this.buttonTorol_Click);
            // 
            // numericAr
            // 
            this.numericAr.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericAr.Location = new System.Drawing.Point(425, 81);
            this.numericAr.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericAr.Name = "numericAr";
            this.numericAr.Size = new System.Drawing.Size(120, 20);
            this.numericAr.TabIndex = 9;
            // 
            // dataGridTelefonok
            // 
            this.dataGridTelefonok.AllowUserToAddRows = false;
            this.dataGridTelefonok.AllowUserToDeleteRows = false;
            this.dataGridTelefonok.AllowUserToResizeColumns = false;
            this.dataGridTelefonok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTelefonok.Location = new System.Drawing.Point(0, 203);
            this.dataGridTelefonok.Name = "dataGridTelefonok";
            this.dataGridTelefonok.ReadOnly = true;
            this.dataGridTelefonok.Size = new System.Drawing.Size(545, 268);
            this.dataGridTelefonok.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 472);
            this.Controls.Add(this.dataGridTelefonok);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTelefonok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTipusa;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.Label lblara;
        private System.Windows.Forms.Label lbltipusa;
        private System.Windows.Forms.Label lblmarka;
        private System.Windows.Forms.Button buttonUJ;
        private System.Windows.Forms.Button buttonModosit;
        private System.Windows.Forms.NumericUpDown numericAr;
        private System.Windows.Forms.Button buttonTorol;
        private System.Windows.Forms.DataGridView dataGridTelefonok;
    }
}

