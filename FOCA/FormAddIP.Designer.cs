namespace FOCA
{
    partial class FormAddIp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddIp));
            this.lblAddIp = new System.Windows.Forms.Label();
            this.picFOCA = new System.Windows.Forms.PictureBox();
            this.txtOct1 = new System.Windows.Forms.TextBox();
            this.txtOct2 = new System.Windows.Forms.TextBox();
            this.txtOct3 = new System.Windows.Forms.TextBox();
            this.txtOct4 = new System.Windows.Forms.TextBox();
            this.btnAddIp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFOCA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddIp
            // 
            this.lblAddIp.AutoSize = true;
            this.lblAddIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddIp.Location = new System.Drawing.Point(256, 18);
            this.lblAddIp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddIp.Name = "lblAddIp";
            this.lblAddIp.Size = new System.Drawing.Size(135, 29);
            this.lblAddIp.TabIndex = 0;
            this.lblAddIp.Text = "Add new IP address";
            // 
            // picFOCA
            // 
            this.picFOCA.Image = ((System.Drawing.Image)(resources.GetObject("picFOCA.Image")));
            this.picFOCA.Location = new System.Drawing.Point(38, 18);
            this.picFOCA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picFOCA.Name = "picFOCA";
            this.picFOCA.Size = new System.Drawing.Size(180, 86);
            this.picFOCA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFOCA.TabIndex = 1;
            this.picFOCA.TabStop = false;
            // 
            // txtOct1
            // 
            this.txtOct1.Location = new System.Drawing.Point(261, 69);
            this.txtOct1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOct1.MaxLength = 3;
            this.txtOct1.Name = "txtOct1";
            this.txtOct1.Size = new System.Drawing.Size(46, 26);
            this.txtOct1.TabIndex = 2;
            this.txtOct1.Text = "0";
            // 
            // txtOct2
            // 
            this.txtOct2.Location = new System.Drawing.Point(318, 69);
            this.txtOct2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOct2.MaxLength = 3;
            this.txtOct2.Name = "txtOct2";
            this.txtOct2.Size = new System.Drawing.Size(46, 26);
            this.txtOct2.TabIndex = 3;
            this.txtOct2.Text = "0";
            // 
            // txtOct3
            // 
            this.txtOct3.Location = new System.Drawing.Point(375, 69);
            this.txtOct3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOct3.MaxLength = 3;
            this.txtOct3.Name = "txtOct3";
            this.txtOct3.Size = new System.Drawing.Size(46, 26);
            this.txtOct3.TabIndex = 4;
            this.txtOct3.Text = "0";
            // 
            // txtOct4
            // 
            this.txtOct4.Location = new System.Drawing.Point(432, 69);
            this.txtOct4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOct4.MaxLength = 3;
            this.txtOct4.Name = "txtOct4";
            this.txtOct4.Size = new System.Drawing.Size(46, 26);
            this.txtOct4.TabIndex = 5;
            this.txtOct4.Text = "0";
            // 
            // btnAddIp
            // 
            this.btnAddIp.Image = global::FOCA.Properties.Resources.add1;
            this.btnAddIp.Location = new System.Drawing.Point(489, 60);
            this.btnAddIp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddIp.Name = "btnAddIp";
            this.btnAddIp.Size = new System.Drawing.Size(92, 49);
            this.btnAddIp.TabIndex = 6;
            this.btnAddIp.Text = "Add";
            this.btnAddIp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddIp.UseVisualStyleBackColor = true;
            this.btnAddIp.Click += new System.EventHandler(this.btAddIp_Click);
            // 
            // FormAddIp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 118);
            this.Controls.Add(this.btnAddIp);
            this.Controls.Add(this.txtOct4);
            this.Controls.Add(this.txtOct3);
            this.Controls.Add(this.txtOct2);
            this.Controls.Add(this.txtOct1);
            this.Controls.Add(this.picFOCA);
            this.Controls.Add(this.lblAddIp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormAddIp";
            this.Text = "Add new IP address";
            ((System.ComponentModel.ISupportInitialize)(this.picFOCA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddIp;
        private System.Windows.Forms.PictureBox picFOCA;
        private System.Windows.Forms.TextBox txtOct1;
        private System.Windows.Forms.TextBox txtOct2;
        private System.Windows.Forms.TextBox txtOct3;
        private System.Windows.Forms.TextBox txtOct4;
        private System.Windows.Forms.Button btnAddIp;
    }
}