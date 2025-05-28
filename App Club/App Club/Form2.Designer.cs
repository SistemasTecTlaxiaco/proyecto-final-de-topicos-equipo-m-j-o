namespace App_Club
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.group1foem1 = new System.Windows.Forms.GroupBox();
            this.txt2form2 = new System.Windows.Forms.TextBox();
            this.txt1form2 = new System.Windows.Forms.TextBox();
            this.btninisiarform2 = new System.Windows.Forms.Button();
            this.label2form2 = new System.Windows.Forms.Label();
            this.label1form2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new App_Club.RJButton();
            this.group1foem1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // group1foem1
            // 
            this.group1foem1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group1foem1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.group1foem1.Controls.Add(this.txt2form2);
            this.group1foem1.Controls.Add(this.txt1form2);
            this.group1foem1.Controls.Add(this.btninisiarform2);
            this.group1foem1.Controls.Add(this.label2form2);
            this.group1foem1.Controls.Add(this.label1form2);
            this.group1foem1.Location = new System.Drawing.Point(428, 85);
            this.group1foem1.Name = "group1foem1";
            this.group1foem1.Size = new System.Drawing.Size(363, 322);
            this.group1foem1.TabIndex = 0;
            this.group1foem1.TabStop = false;
            // 
            // txt2form2
            // 
            this.txt2form2.Location = new System.Drawing.Point(123, 141);
            this.txt2form2.Name = "txt2form2";
            this.txt2form2.Size = new System.Drawing.Size(183, 22);
            this.txt2form2.TabIndex = 4;
            this.txt2form2.TextChanged += new System.EventHandler(this.txt2form2_TextChanged);
            // 
            // txt1form2
            // 
            this.txt1form2.Location = new System.Drawing.Point(123, 72);
            this.txt1form2.Name = "txt1form2";
            this.txt1form2.Size = new System.Drawing.Size(183, 22);
            this.txt1form2.TabIndex = 3;
            this.txt1form2.TextChanged += new System.EventHandler(this.txt1form2_TextChanged);
            // 
            // btninisiarform2
            // 
            this.btninisiarform2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btninisiarform2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btninisiarform2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninisiarform2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninisiarform2.Location = new System.Drawing.Point(113, 216);
            this.btninisiarform2.Name = "btninisiarform2";
            this.btninisiarform2.Size = new System.Drawing.Size(145, 39);
            this.btninisiarform2.TabIndex = 2;
            this.btninisiarform2.Text = "Iniciar Sesión";
            this.btninisiarform2.UseVisualStyleBackColor = false;
            this.btninisiarform2.Click += new System.EventHandler(this.btninisiarform2_Click);
            // 
            // label2form2
            // 
            this.label2form2.AutoSize = true;
            this.label2form2.Location = new System.Drawing.Point(4, 147);
            this.label2form2.Name = "label2form2";
            this.label2form2.Size = new System.Drawing.Size(101, 16);
            this.label2form2.TabIndex = 1;
            this.label2form2.Text = "CONTRASEÑA";
            // 
            // label1form2
            // 
            this.label1form2.AutoSize = true;
            this.label1form2.Location = new System.Drawing.Point(7, 78);
            this.label1form2.Name = "label1form2";
            this.label1form2.Size = new System.Drawing.Size(98, 16);
            this.label1form2.TabIndex = 0;
            this.label1form2.Text = "NO. CONTROL";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 178);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRegresar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRegresar.BorderColor = System.Drawing.Color.White;
            this.btnRegresar.BorderRadius = 10;
            this.btnRegresar.BorderSize = 3;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.Black;
            this.btnRegresar.Location = new System.Drawing.Point(748, 25);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(150, 40);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.TextColor = System.Drawing.Color.Black;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(926, 453);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.group1foem1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.group1foem1.ResumeLayout(false);
            this.group1foem1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group1foem1;
        private System.Windows.Forms.Button btninisiarform2;
        private System.Windows.Forms.Label label2form2;
        private System.Windows.Forms.Label label1form2;
        private System.Windows.Forms.TextBox txt2form2;
        private System.Windows.Forms.TextBox txt1form2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJButton btnRegresar;
    }
}