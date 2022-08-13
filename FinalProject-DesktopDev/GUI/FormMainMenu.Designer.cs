namespace FinalProject_DesktopDev.GUI
{
    partial class FormMainMenu
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
            this.buttonUserManagement = new System.Windows.Forms.Button();
            this.buttonEmployeeManagement = new System.Windows.Forms.Button();
            this.buttonClientManagement = new System.Windows.Forms.Button();
            this.buttonInventoryManagement = new System.Windows.Forms.Button();
            this.buttonOrderManagement = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUserManagement
            // 
            this.buttonUserManagement.Enabled = false;
            this.buttonUserManagement.Location = new System.Drawing.Point(36, 24);
            this.buttonUserManagement.Name = "buttonUserManagement";
            this.buttonUserManagement.Size = new System.Drawing.Size(133, 49);
            this.buttonUserManagement.TabIndex = 0;
            this.buttonUserManagement.Text = "&User Management";
            this.buttonUserManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUserManagement.UseVisualStyleBackColor = true;
            this.buttonUserManagement.Click += new System.EventHandler(this.buttonUserManagement_Click);
            // 
            // buttonEmployeeManagement
            // 
            this.buttonEmployeeManagement.Enabled = false;
            this.buttonEmployeeManagement.Location = new System.Drawing.Point(36, 90);
            this.buttonEmployeeManagement.Name = "buttonEmployeeManagement";
            this.buttonEmployeeManagement.Size = new System.Drawing.Size(133, 49);
            this.buttonEmployeeManagement.TabIndex = 1;
            this.buttonEmployeeManagement.Text = "&Employee Management";
            this.buttonEmployeeManagement.UseVisualStyleBackColor = true;
            this.buttonEmployeeManagement.Click += new System.EventHandler(this.buttonEmployeeManagement_Click);
            // 
            // buttonClientManagement
            // 
            this.buttonClientManagement.Enabled = false;
            this.buttonClientManagement.Location = new System.Drawing.Point(36, 156);
            this.buttonClientManagement.Name = "buttonClientManagement";
            this.buttonClientManagement.Size = new System.Drawing.Size(133, 49);
            this.buttonClientManagement.TabIndex = 2;
            this.buttonClientManagement.Text = "&Client Management";
            this.buttonClientManagement.UseVisualStyleBackColor = true;
            this.buttonClientManagement.Click += new System.EventHandler(this.buttonClientManagement_Click);
            // 
            // buttonInventoryManagement
            // 
            this.buttonInventoryManagement.Enabled = false;
            this.buttonInventoryManagement.Location = new System.Drawing.Point(36, 222);
            this.buttonInventoryManagement.Name = "buttonInventoryManagement";
            this.buttonInventoryManagement.Size = new System.Drawing.Size(133, 49);
            this.buttonInventoryManagement.TabIndex = 3;
            this.buttonInventoryManagement.Text = "&Inventory Management";
            this.buttonInventoryManagement.UseVisualStyleBackColor = true;
            this.buttonInventoryManagement.Click += new System.EventHandler(this.buttonInventoryManagement_Click);
            // 
            // buttonOrderManagement
            // 
            this.buttonOrderManagement.Enabled = false;
            this.buttonOrderManagement.Location = new System.Drawing.Point(36, 288);
            this.buttonOrderManagement.Name = "buttonOrderManagement";
            this.buttonOrderManagement.Size = new System.Drawing.Size(133, 49);
            this.buttonOrderManagement.TabIndex = 4;
            this.buttonOrderManagement.Text = "&Order Management";
            this.buttonOrderManagement.UseVisualStyleBackColor = true;
            this.buttonOrderManagement.Click += new System.EventHandler(this.buttonOrderManagement_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.ForeColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(36, 354);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(133, 49);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(208, 431);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOrderManagement);
            this.Controls.Add(this.buttonInventoryManagement);
            this.Controls.Add(this.buttonClientManagement);
            this.Controls.Add(this.buttonEmployeeManagement);
            this.Controls.Add(this.buttonUserManagement);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUserManagement;
        private System.Windows.Forms.Button buttonEmployeeManagement;
        private System.Windows.Forms.Button buttonClientManagement;
        private System.Windows.Forms.Button buttonInventoryManagement;
        private System.Windows.Forms.Button buttonOrderManagement;
        private System.Windows.Forms.Button buttonExit;
    }
}