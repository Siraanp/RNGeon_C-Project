
namespace Project1
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.reg_btn = new System.Windows.Forms.Button();
            this.tolgn_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmpassword.Location = new System.Drawing.Point(394, 224);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Size = new System.Drawing.Size(368, 45);
            this.txtconfirmpassword.TabIndex = 3;
            this.txtconfirmpassword.TextChanged += new System.EventHandler(this.txtconfirmpassword_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(394, 154);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(368, 45);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(394, 81);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(368, 45);
            this.txtusername.TabIndex = 5;
            // 
            // reg_btn
            // 
            this.reg_btn.Location = new System.Drawing.Point(259, 295);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(300, 50);
            this.reg_btn.TabIndex = 6;
            this.reg_btn.Text = "Register Now";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // tolgn_btn
            // 
            this.tolgn_btn.Location = new System.Drawing.Point(159, 362);
            this.tolgn_btn.Name = "tolgn_btn";
            this.tolgn_btn.Size = new System.Drawing.Size(500, 50);
            this.tolgn_btn.TabIndex = 7;
            this.tolgn_btn.Text = "Have Account? Login now";
            this.tolgn_btn.UseVisualStyleBackColor = true;
            this.tolgn_btn.Click += new System.EventHandler(this.tolgn_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 46);
            this.label4.TabIndex = 17;
            this.label4.Text = "RNGeon";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tolgn_btn);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtconfirmpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtconfirmpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Button tolgn_btn;
        private System.Windows.Forms.Label label4;
    }
}