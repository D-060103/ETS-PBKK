namespace CurrencyConverter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtFromCurrency = new System.Windows.Forms.TextBox();
            this.txtToCurrency = new System.Windows.Forms.TextBox();
            this.cmbFromCurrency = new System.Windows.Forms.ComboBox();
            this.cmbToCurrency = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblFromCuurency = new System.Windows.Forms.Label();
            this.lblToCurrency = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFromCurrency
            // 
            this.txtFromCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromCurrency.Location = new System.Drawing.Point(383, 141);
            this.txtFromCurrency.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFromCurrency.Name = "txtFromCurrency";
            this.txtFromCurrency.Size = new System.Drawing.Size(137, 32);
            this.txtFromCurrency.TabIndex = 0;
            // 
            // txtToCurrency
            // 
            this.txtToCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToCurrency.Location = new System.Drawing.Point(383, 270);
            this.txtToCurrency.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtToCurrency.Name = "txtToCurrency";
            this.txtToCurrency.Size = new System.Drawing.Size(133, 32);
            this.txtToCurrency.TabIndex = 1;
            // 
            // cmbFromCurrency
            // 
            this.cmbFromCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFromCurrency.FormattingEnabled = true;
            this.cmbFromCurrency.Location = new System.Drawing.Point(553, 141);
            this.cmbFromCurrency.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFromCurrency.Name = "cmbFromCurrency";
            this.cmbFromCurrency.Size = new System.Drawing.Size(333, 30);
            this.cmbFromCurrency.TabIndex = 2;
            // 
            // cmbToCurrency
            // 
            this.cmbToCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbToCurrency.FormattingEnabled = true;
            this.cmbToCurrency.Location = new System.Drawing.Point(553, 270);
            this.cmbToCurrency.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbToCurrency.Name = "cmbToCurrency";
            this.cmbToCurrency.Size = new System.Drawing.Size(288, 30);
            this.cmbToCurrency.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(525, 318);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(121, 40);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblFromCuurency
            // 
            this.lblFromCuurency.AutoSize = true;
            this.lblFromCuurency.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromCuurency.Location = new System.Drawing.Point(639, 86);
            this.lblFromCuurency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFromCuurency.Name = "lblFromCuurency";
            this.lblFromCuurency.Size = new System.Drawing.Size(176, 24);
            this.lblFromCuurency.TabIndex = 5;
            this.lblFromCuurency.Text = "From (Currency)";
            // 
            // lblToCurrency
            // 
            this.lblToCurrency.AutoSize = true;
            this.lblToCurrency.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToCurrency.Location = new System.Drawing.Point(639, 231);
            this.lblToCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToCurrency.Name = "lblToCurrency";
            this.lblToCurrency.Size = new System.Drawing.Size(147, 24);
            this.lblToCurrency.TabIndex = 6;
            this.lblToCurrency.Text = "To (Currency)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amount";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1141, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblToCurrency);
            this.Controls.Add(this.lblFromCuurency);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cmbToCurrency);
            this.Controls.Add(this.cmbFromCurrency);
            this.Controls.Add(this.txtToCurrency);
            this.Controls.Add(this.txtFromCurrency);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "ETS PBKK D 2023 - Money Conversion";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFromCurrency;
        private System.Windows.Forms.TextBox txtToCurrency;
        private System.Windows.Forms.ComboBox cmbFromCurrency;
        private System.Windows.Forms.ComboBox cmbToCurrency;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblFromCuurency;
        private System.Windows.Forms.Label lblToCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

