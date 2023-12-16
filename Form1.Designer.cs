namespace AuctionSystem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.emailV = new System.Windows.Forms.TextBox();
            this.passV = new System.Windows.Forms.TextBox();
            this.emailL = new System.Windows.Forms.Label();
            this.passL = new System.Windows.Forms.Label();
            this.emailL2 = new System.Windows.Forms.Label();
            this.passL2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameL2 = new System.Windows.Forms.Label();
            this.nameL = new System.Windows.Forms.Label();
            this.nameV = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uploadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // emailV
            // 
            this.emailV.Location = new System.Drawing.Point(314, 154);
            this.emailV.Name = "emailV";
            this.emailV.Size = new System.Drawing.Size(100, 20);
            this.emailV.TabIndex = 0;
            // 
            // passV
            // 
            this.passV.Location = new System.Drawing.Point(314, 204);
            this.passV.Name = "passV";
            this.passV.Size = new System.Drawing.Size(100, 20);
            this.passV.TabIndex = 1;
            // 
            // emailL
            // 
            this.emailL.AutoSize = true;
            this.emailL.Location = new System.Drawing.Point(232, 161);
            this.emailL.Name = "emailL";
            this.emailL.Size = new System.Drawing.Size(32, 13);
            this.emailL.TabIndex = 2;
            this.emailL.Text = "Email";
            // 
            // passL
            // 
            this.passL.AutoSize = true;
            this.passL.Location = new System.Drawing.Point(232, 211);
            this.passL.Name = "passL";
            this.passL.Size = new System.Drawing.Size(53, 13);
            this.passL.TabIndex = 3;
            this.passL.Text = "Password";
            // 
            // emailL2
            // 
            this.emailL2.AutoSize = true;
            this.emailL2.ForeColor = System.Drawing.Color.Red;
            this.emailL2.Location = new System.Drawing.Point(313, 177);
            this.emailL2.Name = "emailL2";
            this.emailL2.Size = new System.Drawing.Size(0, 13);
            this.emailL2.TabIndex = 4;
            // 
            // passL2
            // 
            this.passL2.AutoSize = true;
            this.passL2.ForeColor = System.Drawing.Color.Red;
            this.passL2.Location = new System.Drawing.Point(312, 227);
            this.passL2.Name = "passL2";
            this.passL2.Size = new System.Drawing.Size(0, 13);
            this.passL2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(310, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "SignUp";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // nameL2
            // 
            this.nameL2.AutoSize = true;
            this.nameL2.ForeColor = System.Drawing.Color.Red;
            this.nameL2.Location = new System.Drawing.Point(313, 127);
            this.nameL2.Name = "nameL2";
            this.nameL2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameL2.Size = new System.Drawing.Size(0, 13);
            this.nameL2.TabIndex = 9;
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Location = new System.Drawing.Point(229, 111);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(35, 13);
            this.nameL.TabIndex = 8;
            this.nameL.Text = "Name";
            this.nameL.Click += new System.EventHandler(this.Label7_Click);
            // 
            // nameV
            // 
            this.nameV.Location = new System.Drawing.Point(314, 104);
            this.nameV.Name = "nameV";
            this.nameV.Size = new System.Drawing.Size(100, 20);
            this.nameV.TabIndex = 7;
            this.nameV.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(314, 261);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(517, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(527, 229);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(75, 23);
            this.uploadButton.TabIndex = 12;
            this.uploadButton.Text = "upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.nameL2);
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.nameV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passL2);
            this.Controls.Add(this.emailL2);
            this.Controls.Add(this.passL);
            this.Controls.Add(this.emailL);
            this.Controls.Add(this.passV);
            this.Controls.Add(this.emailV);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailV;
        private System.Windows.Forms.TextBox passV;
        private System.Windows.Forms.Label emailL;
        private System.Windows.Forms.Label passL;
        private System.Windows.Forms.Label emailL2;
        private System.Windows.Forms.Label passL2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label nameL2;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.TextBox nameV;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

