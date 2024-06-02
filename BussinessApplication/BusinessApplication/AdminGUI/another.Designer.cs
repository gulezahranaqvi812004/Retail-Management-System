namespace BusinessApplication.AdminGUI
{
    partial class another
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewDevice = new System.Windows.Forms.Button();
            this.viewEmp = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(305, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 42);
            this.label1.TabIndex = 64;
            this.label1.Text = "Admin Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(119, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(714, 42);
            this.label2.TabIndex = 63;
            this.label2.Text = "Mobile Shop Management System";
            // 
            // viewDevice
            // 
            this.viewDevice.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDevice.Location = new System.Drawing.Point(283, 202);
            this.viewDevice.Name = "viewDevice";
            this.viewDevice.Size = new System.Drawing.Size(302, 69);
            this.viewDevice.TabIndex = 65;
            this.viewDevice.Text = "Maintain Employees";
            this.viewDevice.UseVisualStyleBackColor = true;
            this.viewDevice.Click += new System.EventHandler(this.viewDevice_Click);
            // 
            // viewEmp
            // 
            this.viewEmp.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.viewEmp.Location = new System.Drawing.Point(283, 294);
            this.viewEmp.Name = "viewEmp";
            this.viewEmp.Size = new System.Drawing.Size(302, 59);
            this.viewEmp.TabIndex = 66;
            this.viewEmp.Text = "Maintain expenditures";
            this.viewEmp.UseVisualStyleBackColor = true;
            this.viewEmp.Click += new System.EventHandler(this.viewEmp_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.exit.Location = new System.Drawing.Point(283, 370);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(302, 58);
            this.exit.TabIndex = 67;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // another
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.viewEmp);
            this.Controls.Add(this.viewDevice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "another";
            this.Text = "another";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewDevice;
        private System.Windows.Forms.Button viewEmp;
        private System.Windows.Forms.Button exit;
    }
}