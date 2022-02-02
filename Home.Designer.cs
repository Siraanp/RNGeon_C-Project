
namespace Project1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Mission_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gacha_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Diamond_Show = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PHealth_display = new System.Windows.Forms.TextBox();
            this.PAttack_display = new System.Windows.Forms.TextBox();
            this.Gallery_btn = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(462, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Daimond :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(20, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Player Health :";
            // 
            // Mission_btn
            // 
            this.Mission_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Mission_btn.Location = new System.Drawing.Point(400, 95);
            this.Mission_btn.Name = "Mission_btn";
            this.Mission_btn.Size = new System.Drawing.Size(247, 74);
            this.Mission_btn.TabIndex = 9;
            this.Mission_btn.Text = "Enter RNGgeon";
            this.Mission_btn.UseVisualStyleBackColor = true;
            this.Mission_btn.Click += new System.EventHandler(this.Mission_btn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(134, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Profile";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gacha_btn
            // 
            this.gacha_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gacha_btn.Location = new System.Drawing.Point(400, 187);
            this.gacha_btn.Name = "gacha_btn";
            this.gacha_btn.Size = new System.Drawing.Size(247, 74);
            this.gacha_btn.TabIndex = 16;
            this.gacha_btn.Text = "GACHA ";
            this.gacha_btn.UseVisualStyleBackColor = true;
            this.gacha_btn.Click += new System.EventHandler(this.gacha_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(105, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(182, 45);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Diamond_Show
            // 
            this.Diamond_Show.Location = new System.Drawing.Point(554, 28);
            this.Diamond_Show.Name = "Diamond_Show";
            this.Diamond_Show.ReadOnly = true;
            this.Diamond_Show.Size = new System.Drawing.Size(100, 22);
            this.Diamond_Show.TabIndex = 19;
            this.Diamond_Show.TextChanged += new System.EventHandler(this.Diamond_Show_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(20, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Player Attack :";
            // 
            // PHealth_display
            // 
            this.PHealth_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PHealth_display.Location = new System.Drawing.Point(157, 315);
            this.PHealth_display.Name = "PHealth_display";
            this.PHealth_display.ReadOnly = true;
            this.PHealth_display.Size = new System.Drawing.Size(100, 28);
            this.PHealth_display.TabIndex = 22;
            this.PHealth_display.TextChanged += new System.EventHandler(this.PHealth_display_TextChanged);
            // 
            // PAttack_display
            // 
            this.PAttack_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAttack_display.Location = new System.Drawing.Point(157, 353);
            this.PAttack_display.Name = "PAttack_display";
            this.PAttack_display.ReadOnly = true;
            this.PAttack_display.Size = new System.Drawing.Size(100, 28);
            this.PAttack_display.TabIndex = 23;
            this.PAttack_display.TextChanged += new System.EventHandler(this.PAttack_display_TextChanged);
            // 
            // Gallery_btn
            // 
            this.Gallery_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Gallery_btn.Location = new System.Drawing.Point(400, 278);
            this.Gallery_btn.Name = "Gallery_btn";
            this.Gallery_btn.Size = new System.Drawing.Size(247, 67);
            this.Gallery_btn.TabIndex = 11;
            this.Gallery_btn.Text = "Gallery";
            this.Gallery_btn.UseVisualStyleBackColor = true;
            this.Gallery_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(617, 376);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 30);
            this.logout.TabIndex = 24;
            this.logout.Text = "LogOut";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 418);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.PAttack_display);
            this.Controls.Add(this.PHealth_display);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Diamond_Show);
            this.Controls.Add(this.gacha_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Gallery_btn);
            this.Controls.Add(this.Mission_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Home";
            this.Text = "Homes";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Mission_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gacha_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Diamond_Show;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PHealth_display;
        private System.Windows.Forms.TextBox PAttack_display;
        private System.Windows.Forms.Button Gallery_btn;
        private System.Windows.Forms.Button logout;
    }
}