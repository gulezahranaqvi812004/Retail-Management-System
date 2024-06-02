namespace BusinessApplication
{
    partial class AddDevice
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
            this.button1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.pp = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 29;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(97, 366);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(85, 30);
            this.exit.TabIndex = 28;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Location = new System.Drawing.Point(284, 100);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(147, 28);
            this.menu.TabIndex = 31;
            this.menu.Text = "Admin Menu";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(173, 43);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(393, 28);
            this.header.TabIndex = 30;
            this.header.Text = "Mobile shop management system";
            // 
            // pp
            // 
            this.pp.Location = new System.Drawing.Point(289, 282);
            this.pp.Name = "pp";
            this.pp.Size = new System.Drawing.Size(238, 26);
            this.pp.TabIndex = 38;
            this.pp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.price.Location = new System.Drawing.Point(183, 283);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(56, 25);
            this.price.TabIndex = 37;
            this.price.Text = "Price";
            this.price.Click += new System.EventHandler(this.salary_Click);
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(153, 224);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(85, 25);
            this.quantity.TabIndex = 36;
            this.quantity.Text = "Quantity";
            this.quantity.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(289, 225);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(238, 26);
            this.stock.TabIndex = 35;
            this.stock.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(289, 161);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(238, 26);
            this.name.TabIndex = 34;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(136, 162);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(129, 25);
            this.nameLabel.TabIndex = 33;
            this.nameLabel.Text = "Device Name";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // AddDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pp);
            this.Controls.Add(this.price);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.header);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit);
            this.Name = "AddDevice";
            this.Text = "AddDevice";
            this.Load += new System.EventHandler(this.AddDevice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.TextBox pp;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label nameLabel;
    }
}