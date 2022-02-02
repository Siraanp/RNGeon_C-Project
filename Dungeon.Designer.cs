
namespace Project1
{
    partial class Dungeon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dungeon));
            this.Fightlog_box = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerN = new System.Windows.Forms.TextBox();
            this.PlayerH = new System.Windows.Forms.TextBox();
            this.PlayerA = new System.Windows.Forms.TextBox();
            this.Enermy_Attack = new System.Windows.Forms.TextBox();
            this.Enermy_Health = new System.Windows.Forms.TextBox();
            this.Slash_btn = new System.Windows.Forms.Button();
            this.Pierce_btn = new System.Windows.Forms.Button();
            this.Crush_btn = new System.Windows.Forms.Button();
            this.Fight_btn = new System.Windows.Forms.Button();
            this.BackToVillage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fightlog_box
            // 
            this.Fightlog_box.Location = new System.Drawing.Point(52, 339);
            this.Fightlog_box.Name = "Fightlog_box";
            this.Fightlog_box.ReadOnly = true;
            this.Fightlog_box.Size = new System.Drawing.Size(718, 99);
            this.Fightlog_box.TabIndex = 2;
            this.Fightlog_box.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fight Log";
            // 
            // PlayerN
            // 
            this.PlayerN.Location = new System.Drawing.Point(151, 133);
            this.PlayerN.Name = "PlayerN";
            this.PlayerN.ReadOnly = true;
            this.PlayerN.Size = new System.Drawing.Size(93, 22);
            this.PlayerN.TabIndex = 4;
            this.PlayerN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayerH
            // 
            this.PlayerH.Location = new System.Drawing.Point(69, 253);
            this.PlayerH.Name = "PlayerH";
            this.PlayerH.ReadOnly = true;
            this.PlayerH.Size = new System.Drawing.Size(89, 22);
            this.PlayerH.TabIndex = 5;
            this.PlayerH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayerA
            // 
            this.PlayerA.Location = new System.Drawing.Point(178, 253);
            this.PlayerA.Name = "PlayerA";
            this.PlayerA.ReadOnly = true;
            this.PlayerA.Size = new System.Drawing.Size(89, 22);
            this.PlayerA.TabIndex = 6;
            this.PlayerA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Enermy_Attack
            // 
            this.Enermy_Attack.Location = new System.Drawing.Point(607, 264);
            this.Enermy_Attack.Name = "Enermy_Attack";
            this.Enermy_Attack.ReadOnly = true;
            this.Enermy_Attack.Size = new System.Drawing.Size(89, 22);
            this.Enermy_Attack.TabIndex = 7;
            // 
            // Enermy_Health
            // 
            this.Enermy_Health.Location = new System.Drawing.Point(433, 264);
            this.Enermy_Health.Name = "Enermy_Health";
            this.Enermy_Health.ReadOnly = true;
            this.Enermy_Health.Size = new System.Drawing.Size(89, 22);
            this.Enermy_Health.TabIndex = 8;
            // 
            // Slash_btn
            // 
            this.Slash_btn.Location = new System.Drawing.Point(322, 89);
            this.Slash_btn.Name = "Slash_btn";
            this.Slash_btn.Size = new System.Drawing.Size(100, 50);
            this.Slash_btn.TabIndex = 9;
            this.Slash_btn.Text = "Slash";
            this.Slash_btn.UseVisualStyleBackColor = true;
            this.Slash_btn.Visible = false;
            this.Slash_btn.Click += new System.EventHandler(this.Slash_btn_Click);
            // 
            // Pierce_btn
            // 
            this.Pierce_btn.Location = new System.Drawing.Point(259, 175);
            this.Pierce_btn.Name = "Pierce_btn";
            this.Pierce_btn.Size = new System.Drawing.Size(100, 50);
            this.Pierce_btn.TabIndex = 10;
            this.Pierce_btn.Text = "Pierce";
            this.Pierce_btn.UseVisualStyleBackColor = true;
            this.Pierce_btn.Visible = false;
            this.Pierce_btn.Click += new System.EventHandler(this.Pierce_btn_Click);
            // 
            // Crush_btn
            // 
            this.Crush_btn.Location = new System.Drawing.Point(401, 175);
            this.Crush_btn.Name = "Crush_btn";
            this.Crush_btn.Size = new System.Drawing.Size(100, 50);
            this.Crush_btn.TabIndex = 11;
            this.Crush_btn.Text = "Crush";
            this.Crush_btn.UseVisualStyleBackColor = true;
            this.Crush_btn.Visible = false;
            this.Crush_btn.Click += new System.EventHandler(this.Crush_btn_Click);
            // 
            // Fight_btn
            // 
            this.Fight_btn.Location = new System.Drawing.Point(322, 119);
            this.Fight_btn.Name = "Fight_btn";
            this.Fight_btn.Size = new System.Drawing.Size(100, 50);
            this.Fight_btn.TabIndex = 13;
            this.Fight_btn.Text = "Fight";
            this.Fight_btn.UseVisualStyleBackColor = true;
            this.Fight_btn.Click += new System.EventHandler(this.Fight_btn_Click);
            // 
            // BackToVillage
            // 
            this.BackToVillage.Location = new System.Drawing.Point(322, 212);
            this.BackToVillage.Name = "BackToVillage";
            this.BackToVillage.Size = new System.Drawing.Size(100, 50);
            this.BackToVillage.TabIndex = 14;
            this.BackToVillage.Text = "Back To Village";
            this.BackToVillage.UseVisualStyleBackColor = true;
            this.BackToVillage.Click += new System.EventHandler(this.BackToVillage_Click);
            // 
            // Dungeon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackToVillage);
            this.Controls.Add(this.Fight_btn);
            this.Controls.Add(this.Crush_btn);
            this.Controls.Add(this.Pierce_btn);
            this.Controls.Add(this.Slash_btn);
            this.Controls.Add(this.Enermy_Health);
            this.Controls.Add(this.Enermy_Attack);
            this.Controls.Add(this.PlayerA);
            this.Controls.Add(this.PlayerH);
            this.Controls.Add(this.PlayerN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fightlog_box);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Dungeon";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dungeon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox Fightlog_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PlayerN;
        private System.Windows.Forms.TextBox PlayerH;
        private System.Windows.Forms.TextBox PlayerA;
        private System.Windows.Forms.TextBox Enermy_Attack;
        private System.Windows.Forms.TextBox Enermy_Health;
        private System.Windows.Forms.Button Slash_btn;
        private System.Windows.Forms.Button Pierce_btn;
        private System.Windows.Forms.Button Crush_btn;
        private System.Windows.Forms.Button Fight_btn;
        private System.Windows.Forms.Button BackToVillage;
    }
}