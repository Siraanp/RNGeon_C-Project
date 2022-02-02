
namespace Project1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tolgn_btn = new System.Windows.Forms.Button();
            this.lgn_btn = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tolgn_btn
            // 
            this.tolgn_btn.Location = new System.Drawing.Point(166, 373);
            this.tolgn_btn.Name = "tolgn_btn";
            this.tolgn_btn.Size = new System.Drawing.Size(500, 50);
            this.tolgn_btn.TabIndex = 15;
            this.tolgn_btn.Text = "Don\'t have Account? Register now";
            this.tolgn_btn.UseVisualStyleBackColor = true;
            this.tolgn_btn.Click += new System.EventHandler(this.tolgn_btn_Click);
            // 
            // lgn_btn
            // 
            this.lgn_btn.Location = new System.Drawing.Point(266, 306);
            this.lgn_btn.Name = "lgn_btn";
            this.lgn_btn.Size = new System.Drawing.Size(300, 50);
            this.lgn_btn.TabIndex = 14;
            this.lgn_btn.Text = "Login";
            this.lgn_btn.UseVisualStyleBackColor = true;
            this.lgn_btn.Click += new System.EventHandler(this.lgn_btn_Click);
            // 
            // txtusername
            // 
            this.txtusername.AcceptsReturn = true;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(396, 97);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(368, 53);
            this.txtusername.TabIndex = 13;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(396, 200);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(368, 53);
            this.txtpassword.TabIndex = 12;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 46);
            this.label3.TabIndex = 16;
            this.label3.Text = "RNGeon";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tolgn_btn);
            this.Controls.Add(this.lgn_btn);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tolgn_btn;
        private System.Windows.Forms.Button lgn_btn;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}