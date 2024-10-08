
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
            this.properties = new System.Windows.Forms.Label();
            this.Border = new Guna.UI2.WinForms.Guna2PictureBox();
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
            this.gamedeleteB.Location = new System.Drawing.Point(12, 527);
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
            this.gameaddB.Location = new System.Drawing.Point(12, 596);
            this.gameaddB.Name = "gameaddB";
            this.gameaddB.Size = new System.Drawing.Size(246, 45);
            this.gameaddB.TabIndex = 1;
            this.gameaddB.Text = "GameAdd";
            // 
            // Gamepanel
            // 
            this.Gamepanel.AutoScroll = true;
            this.Gamepanel.Location = new System.Drawing.Point(12, 12);
            this.Gamepanel.Name = "Gamepanel";
            this.Gamepanel.Size = new System.Drawing.Size(565, 500);
            this.Gamepanel.TabIndex = 2;
            // 
            // properties
            // 
            this.properties.AutoSize = true;
            this.properties.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.properties.ForeColor = System.Drawing.Color.White;
            this.properties.Location = new System.Drawing.Point(306, 548);
            this.properties.Name = "properties";
            this.properties.Size = new System.Drawing.Size(60, 24);
            this.properties.TabIndex = 3;
            this.properties.Text = "label1";
            // 
            // Border
            // 
            this.Border.BackColor = System.Drawing.Color.DarkMagenta;
            this.Border.ImageRotate = 0F;
            this.Border.Location = new System.Drawing.Point(1, 511);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(595, 10);
            this.Border.TabIndex = 0;
            this.Border.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(589, 653);
            this.Controls.Add(this.Border);
            this.Controls.Add(this.properties);
            this.Controls.Add(this.Gamepanel);
            this.Controls.Add(this.gameaddB);
            this.Controls.Add(this.gamedeleteB);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

