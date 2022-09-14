namespace ShopriteInventoryApp
{
    partial class MainForm
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.button_report = new Guna.UI2.WinForms.Guna2Button();
            this.button_users = new Guna.UI2.WinForms.Guna2Button();
            this.button_stocks = new Guna.UI2.WinForms.Guna2Button();
            this.button_categories = new Guna.UI2.WinForms.Guna2Button();
            this.button_products = new Guna.UI2.WinForms.Guna2Button();
            this.button_admin = new Guna.UI2.WinForms.Guna2Button();
            this.dashboardControl1 = new ShopriteInventoryApp.DashboardControl();
            this.productsControl1 = new ShopriteInventoryApp.ProductsControl();
            this.categoryControl1 = new ShopriteInventoryApp.CategoryControl();
            this.stockControl1 = new ShopriteInventoryApp.StockControl();
            this.usersControl1 = new ShopriteInventoryApp.UsersControl();
            this.reportControl1 = new ShopriteInventoryApp.ReportControl();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.button_report);
            this.guna2Panel1.Controls.Add(this.button_users);
            this.guna2Panel1.Controls.Add(this.button_stocks);
            this.guna2Panel1.Controls.Add(this.button_categories);
            this.guna2Panel1.Controls.Add(this.button_products);
            this.guna2Panel1.Controls.Add(this.button_admin);
            this.guna2Panel1.Location = new System.Drawing.Point(-1, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(183, 600);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::ShopriteInventoryApp.Properties.Resources.download_removebg_preview;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(13, 25);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(162, 150);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            // 
            // button_report
            // 
            this.button_report.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_report.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_report.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_report.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_report.FillColor = System.Drawing.Color.Transparent;
            this.button_report.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_report.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button_report.Location = new System.Drawing.Point(5, 420);
            this.button_report.Name = "button_report";
            this.button_report.Size = new System.Drawing.Size(175, 36);
            this.button_report.TabIndex = 4;
            this.button_report.Text = "REPORTS";
            this.button_report.Click += new System.EventHandler(this.button_report_Click);
            // 
            // button_users
            // 
            this.button_users.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_users.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_users.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_users.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_users.FillColor = System.Drawing.Color.Transparent;
            this.button_users.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_users.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button_users.Location = new System.Drawing.Point(0, 378);
            this.button_users.Name = "button_users";
            this.button_users.Size = new System.Drawing.Size(175, 36);
            this.button_users.TabIndex = 5;
            this.button_users.Text = "USERS";
            this.button_users.Click += new System.EventHandler(this.button_users_Click);
            // 
            // button_stocks
            // 
            this.button_stocks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_stocks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_stocks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_stocks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_stocks.FillColor = System.Drawing.Color.Transparent;
            this.button_stocks.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_stocks.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button_stocks.Location = new System.Drawing.Point(5, 336);
            this.button_stocks.Name = "button_stocks";
            this.button_stocks.Size = new System.Drawing.Size(175, 36);
            this.button_stocks.TabIndex = 4;
            this.button_stocks.Text = "STOCKS";
            this.button_stocks.Click += new System.EventHandler(this.button_stocks_Click);
            // 
            // button_categories
            // 
            this.button_categories.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_categories.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_categories.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_categories.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_categories.FillColor = System.Drawing.Color.Transparent;
            this.button_categories.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_categories.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button_categories.Location = new System.Drawing.Point(5, 294);
            this.button_categories.Name = "button_categories";
            this.button_categories.Size = new System.Drawing.Size(175, 36);
            this.button_categories.TabIndex = 3;
            this.button_categories.Text = "CATEGORIES";
            this.button_categories.Click += new System.EventHandler(this.button_categories_Click);
            // 
            // button_products
            // 
            this.button_products.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_products.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_products.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_products.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_products.FillColor = System.Drawing.Color.Transparent;
            this.button_products.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_products.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button_products.Location = new System.Drawing.Point(5, 252);
            this.button_products.Name = "button_products";
            this.button_products.Size = new System.Drawing.Size(175, 36);
            this.button_products.TabIndex = 2;
            this.button_products.Text = "PRODUCTS";
            this.button_products.Click += new System.EventHandler(this.button_products_Click);
            // 
            // button_admin
            // 
            this.button_admin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_admin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_admin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_admin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_admin.FillColor = System.Drawing.Color.Transparent;
            this.button_admin.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_admin.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button_admin.Location = new System.Drawing.Point(5, 201);
            this.button_admin.Name = "button_admin";
            this.button_admin.Size = new System.Drawing.Size(175, 30);
            this.button_admin.TabIndex = 1;
            this.button_admin.Text = "DASHBOARD";
            this.button_admin.Click += new System.EventHandler(this.button_admin_Click);
            // 
            // dashboardControl1
            // 
            this.dashboardControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dashboardControl1.Location = new System.Drawing.Point(180, 0);
            this.dashboardControl1.Name = "dashboardControl1";
            this.dashboardControl1.Size = new System.Drawing.Size(817, 600);
            this.dashboardControl1.TabIndex = 6;
            // 
            // productsControl1
            // 
            this.productsControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.productsControl1.Location = new System.Drawing.Point(180, 0);
            this.productsControl1.Name = "productsControl1";
            this.productsControl1.Size = new System.Drawing.Size(817, 600);
            this.productsControl1.TabIndex = 5;
            // 
            // categoryControl1
            // 
            this.categoryControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.categoryControl1.Location = new System.Drawing.Point(180, 0);
            this.categoryControl1.Name = "categoryControl1";
            this.categoryControl1.Size = new System.Drawing.Size(817, 600);
            this.categoryControl1.TabIndex = 4;
            // 
            // stockControl1
            // 
            this.stockControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stockControl1.Location = new System.Drawing.Point(180, 0);
            this.stockControl1.Name = "stockControl1";
            this.stockControl1.Size = new System.Drawing.Size(817, 600);
            this.stockControl1.TabIndex = 3;
            // 
            // usersControl1
            // 
            this.usersControl1.BackColor = System.Drawing.Color.White;
            this.usersControl1.Location = new System.Drawing.Point(180, 0);
            this.usersControl1.Name = "usersControl1";
            this.usersControl1.Size = new System.Drawing.Size(817, 600);
            this.usersControl1.TabIndex = 2;
            // 
            // reportControl1
            // 
            this.reportControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.reportControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.reportControl1.Location = new System.Drawing.Point(183, 0);
            this.reportControl1.Name = "reportControl1";
            this.reportControl1.Size = new System.Drawing.Size(817, 600);
            this.reportControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dashboardControl1);
            this.Controls.Add(this.productsControl1);
            this.Controls.Add(this.categoryControl1);
            this.Controls.Add(this.stockControl1);
            this.Controls.Add(this.usersControl1);
            this.Controls.Add(this.reportControl1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button button_report;
        private Guna.UI2.WinForms.Guna2Button button_users;
        private Guna.UI2.WinForms.Guna2Button button_stocks;
        private Guna.UI2.WinForms.Guna2Button button_categories;
        private Guna.UI2.WinForms.Guna2Button button_products;
        private Guna.UI2.WinForms.Guna2Button button_admin;
        private ReportControl reportControl1;
        private UsersControl usersControl1;
        private StockControl stockControl1;
        private CategoryControl categoryControl1;
        private ProductsControl productsControl1;
        private DashboardControl dashboardControl1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}