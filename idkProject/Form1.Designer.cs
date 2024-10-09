
namespace idkProject
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
            this.gamedeleteB = new Guna.UI2.WinForms.Guna2Button();
            this.gameaddB = new Guna.UI2.WinForms.Guna2Button();
            this.Gamepanel = new Guna.UI2.WinForms.Guna2Panel();
            this.AddB = new Guna.UI2.WinForms.Guna2Button();
            this.AddL = new System.Windows.Forms.Label();
            this.GameNameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.properties = new System.Windows.Forms.Label();
            this.Border = new Guna.UI2.WinForms.Guna2PictureBox();
            this.GameTypeTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.GamePriceTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.Gamepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Border)).BeginInit();
            this.SuspendLayout();
            // 
            // gamedeleteB
            // 
            this.gamedeleteB.Animated = true;
            this.gamedeleteB.AutoRoundedCorners = true;
            this.gamedeleteB.BorderRadius = 21;
            this.gamedeleteB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gamedeleteB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gamedeleteB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gamedeleteB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gamedeleteB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gamedeleteB.ForeColor = System.Drawing.Color.White;
            this.gamedeleteB.Location = new System.Drawing.Point(11, 760);
            this.gamedeleteB.Name = "gamedeleteB";
            this.gamedeleteB.Size = new System.Drawing.Size(246, 45);
            this.gamedeleteB.TabIndex = 0;
            this.gamedeleteB.Text = "GameDelete";
            // 
            // gameaddB
            // 
            this.gameaddB.Animated = true;
            this.gameaddB.AutoRoundedCorners = true;
            this.gameaddB.BorderRadius = 21;
            this.gameaddB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gameaddB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gameaddB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gameaddB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gameaddB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gameaddB.ForeColor = System.Drawing.Color.White;
            this.gameaddB.Location = new System.Drawing.Point(11, 829);
            this.gameaddB.Name = "gameaddB";
            this.gameaddB.Size = new System.Drawing.Size(246, 45);
            this.gameaddB.TabIndex = 1;
            this.gameaddB.Text = "GameAdd";
            // 
            // Gamepanel
            // 
            this.Gamepanel.AutoScroll = true;
            this.Gamepanel.Controls.Add(this.GamePriceTB);
            this.Gamepanel.Controls.Add(this.GameTypeTB);
            this.Gamepanel.Controls.Add(this.AddB);
            this.Gamepanel.Controls.Add(this.AddL);
            this.Gamepanel.Controls.Add(this.GameNameTB);
            this.Gamepanel.Controls.Add(this.pictureBox1);
            this.Gamepanel.Location = new System.Drawing.Point(12, 12);
            this.Gamepanel.Name = "Gamepanel";
            this.Gamepanel.Size = new System.Drawing.Size(565, 676);
            this.Gamepanel.TabIndex = 2;
            // 
            // AddB
            // 
            this.AddB.Animated = true;
            this.AddB.AutoRoundedCorners = true;
            this.AddB.BorderRadius = 21;
            this.AddB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddB.ForeColor = System.Drawing.Color.White;
            this.AddB.Location = new System.Drawing.Point(186, 420);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(180, 45);
            this.AddB.TabIndex = 3;
            this.AddB.Text = "Add";
            // 
            // AddL
            // 
            this.AddL.AutoSize = true;
            this.AddL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddL.ForeColor = System.Drawing.Color.White;
            this.AddL.Location = new System.Drawing.Point(217, 171);
            this.AddL.Name = "AddL";
            this.AddL.Size = new System.Drawing.Size(136, 31);
            this.AddL.TabIndex = 1;
            this.AddL.Text = "Add game";
            // 
            // GameNameTB
            // 
            this.GameNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GameNameTB.DefaultText = "";
            this.GameNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GameNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GameNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GameNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GameNameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GameNameTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GameNameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GameNameTB.Location = new System.Drawing.Point(107, 205);
            this.GameNameTB.Name = "GameNameTB";
            this.GameNameTB.PasswordChar = '\0';
            this.GameNameTB.PlaceholderText = "Game name";
            this.GameNameTB.SelectedText = "";
            this.GameNameTB.Size = new System.Drawing.Size(356, 36);
            this.GameNameTB.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 376);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // properties
            // 
            this.properties.AutoSize = true;
            this.properties.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.properties.ForeColor = System.Drawing.Color.White;
            this.properties.Location = new System.Drawing.Point(305, 781);
            this.properties.Name = "properties";
            this.properties.Size = new System.Drawing.Size(60, 24);
            this.properties.TabIndex = 3;
            this.properties.Text = "label1";
            // 
            // Border
            // 
            this.Border.BackColor = System.Drawing.Color.DarkMagenta;
            this.Border.ImageRotate = 0F;
            this.Border.Location = new System.Drawing.Point(0, 744);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(595, 10);
            this.Border.TabIndex = 0;
            this.Border.TabStop = false;
            // 
            // GameTypeTB
            // 
            this.GameTypeTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GameTypeTB.DefaultText = "";
            this.GameTypeTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GameTypeTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GameTypeTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GameTypeTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GameTypeTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GameTypeTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GameTypeTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GameTypeTB.Location = new System.Drawing.Point(107, 264);
            this.GameTypeTB.Name = "GameTypeTB";
            this.GameTypeTB.PasswordChar = '\0';
            this.GameTypeTB.PlaceholderText = "Game type";
            this.GameTypeTB.SelectedText = "";
            this.GameTypeTB.Size = new System.Drawing.Size(356, 36);
            this.GameTypeTB.TabIndex = 4;
            // 
            // GamePriceTB
            // 
            this.GamePriceTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GamePriceTB.DefaultText = "";
            this.GamePriceTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GamePriceTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GamePriceTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GamePriceTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GamePriceTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GamePriceTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GamePriceTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GamePriceTB.Location = new System.Drawing.Point(104, 320);
            this.GamePriceTB.Name = "GamePriceTB";
            this.GamePriceTB.PasswordChar = '\0';
            this.GamePriceTB.PlaceholderText = "Game price";
            this.GamePriceTB.SelectedText = "";
            this.GamePriceTB.Size = new System.Drawing.Size(356, 36);
            this.GamePriceTB.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(589, 885);
            this.Controls.Add(this.Border);
            this.Controls.Add(this.properties);
            this.Controls.Add(this.Gamepanel);
            this.Controls.Add(this.gameaddB);
            this.Controls.Add(this.gamedeleteB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Gamepanel.ResumeLayout(false);
            this.Gamepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Border)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button gamedeleteB;
        private Guna.UI2.WinForms.Guna2Button gameaddB;
        private Guna.UI2.WinForms.Guna2Panel Gamepanel;
        private System.Windows.Forms.Label properties;
        private Guna.UI2.WinForms.Guna2PictureBox Border;
        private Guna.UI2.WinForms.Guna2TextBox GameNameTB;
        private System.Windows.Forms.Label AddL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button AddB;
        private Guna.UI2.WinForms.Guna2TextBox GamePriceTB;
        private Guna.UI2.WinForms.Guna2TextBox GameTypeTB;
    }
}

