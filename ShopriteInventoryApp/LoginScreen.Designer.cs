namespace ShopriteInventoryApp
{
    partial class LoginScreen
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.comboBox_Role = new System.Windows.Forms.ComboBox();
            this.Label_Clear = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Button_Login = new Guna.UI2.WinForms.Guna2Button();
            this.TextBox_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Label_Exit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.comboBox_Role);
            this.guna2CustomGradientPanel1.Controls.Add(this.Label_Clear);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2CustomGradientPanel1.Controls.Add(this.Button_Login);
            this.guna2CustomGradientPanel1.Controls.Add(this.TextBox_Password);
            this.guna2CustomGradientPanel1.Controls.Add(this.TextBox_Username);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2CirclePictureBox2);
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.LimeGreen;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(455, 23);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(235, 392);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // comboBox_Role
            // 
            this.comboBox_Role.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Role.FormattingEnabled = true;
            this.comboBox_Role.Items.AddRange(new object[] {
            "ADMIN",
            "SALES PERSON"});
            this.comboBox_Role.Location = new System.Drawing.Point(39, 149);
            this.comboBox_Role.Name = "comboBox_Role";
            this.comboBox_Role.Size = new System.Drawing.Size(165, 28);
            this.comboBox_Role.TabIndex = 7;
            this.comboBox_Role.Text = "Specify Role";
            // 
            // Label_Clear
            // 
            this.Label_Clear.BackColor = System.Drawing.Color.Transparent;
            this.Label_Clear.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Clear.ForeColor = System.Drawing.Color.Crimson;
            this.Label_Clear.Location = new System.Drawing.Point(20, 314);
            this.Label_Clear.Name = "Label_Clear";
            this.Label_Clear.Size = new System.Drawing.Size(51, 16);
            this.Label_Clear.TabIndex = 6;
            this.Label_Clear.Text = "CLEAR";
            this.Label_Clear.Click += new System.EventHandler(this.Label_Clear_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(20, 257);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(69, 15);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "PASSWORD:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(20, 194);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(70, 15);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "USERNAME :";
            // 
            // Button_Login
            // 
            this.Button_Login.BackColor = System.Drawing.Color.Transparent;
            this.Button_Login.BorderRadius = 20;
            this.Button_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Login.ForeColor = System.Drawing.Color.White;
            this.Button_Login.Location = new System.Drawing.Point(70, 329);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(108, 38);
            this.Button_Login.TabIndex = 4;
            this.Button_Login.Text = "LOGIN";
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_Password.BorderColor = System.Drawing.Color.Black;
            this.TextBox_Password.BorderRadius = 20;
            this.TextBox_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Password.DefaultText = "";
            this.TextBox_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Password.Location = new System.Drawing.Point(20, 272);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '●';
            this.TextBox_Password.PlaceholderText = "";
            this.TextBox_Password.SelectedText = "";
            this.TextBox_Password.Size = new System.Drawing.Size(195, 36);
            this.TextBox_Password.TabIndex = 3;
            this.TextBox_Password.UseSystemPasswordChar = true;
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_Username.BorderColor = System.Drawing.Color.Transparent;
            this.TextBox_Username.BorderRadius = 20;
            this.TextBox_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Username.DefaultText = "";
            this.TextBox_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_Username.ForeColor = System.Drawing.Color.Silver;
            this.TextBox_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Username.Location = new System.Drawing.Point(20, 215);
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.PasswordChar = '\0';
            this.TextBox_Username.PlaceholderText = "";
            this.TextBox_Username.SelectedText = "";
            this.TextBox_Username.Size = new System.Drawing.Size(195, 36);
            this.TextBox_Username.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Crimson;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(70, 127);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(88, 16);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "USER LOGIN";
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.Image = global::ShopriteInventoryApp.Properties.Resources.download;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(68, 19);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(90, 88);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 0;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // Label_Exit
            // 
            this.Label_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Label_Exit.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Exit.ForeColor = System.Drawing.Color.ForestGreen;
            this.Label_Exit.Location = new System.Drawing.Point(724, -9);
            this.Label_Exit.Name = "Label_Exit";
            this.Label_Exit.Size = new System.Drawing.Size(18, 41);
            this.Label_Exit.TabIndex = 6;
            this.Label_Exit.Text = "x";
            this.Label_Exit.Click += new System.EventHandler(this.Label_Exit_Click);
            this.Label_Exit.MouseEnter += new System.EventHandler(this.Label_Exit_MouseEnter);
            this.Label_Exit.MouseLeave += new System.EventHandler(this.Label_Exit_MouseLeave);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2PictureBox1.Image = global::ShopriteInventoryApp.Properties.Resources.istockphoto_1320617333_170667a;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(754, 442);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 442);
            this.Controls.Add(this.Label_Exit);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginScreen";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2Button Button_Login;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Password;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Username;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_Exit;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_Clear;
        private System.Windows.Forms.ComboBox comboBox_Role;
    }
}