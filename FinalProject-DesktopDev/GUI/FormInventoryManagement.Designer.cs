namespace FinalProject_DesktopDev.GUI
{
    partial class FormInventoryManagement
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
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearchBy = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelSBN = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxQOH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxYearPublished = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPublisherName = new System.Windows.Forms.TextBox();
            this.labelPublisherName = new System.Windows.Forms.Label();
            this.textBoxPublisherID = new System.Windows.Forms.TextBox();
            this.labelPublisherID = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxSearch2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSearch2 = new System.Windows.Forms.ComboBox();
            this.buttonSearch2 = new System.Windows.Forms.Button();
            this.buttonList2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxAuthorID = new System.Windows.Forms.TextBox();
            this.buttonAdd2 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonListPublisher = new System.Windows.Forms.Button();
            this.textBoxBookAuthorID = new System.Windows.Forms.TextBox();
            this.labelBookAuthorID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(125, 97);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxUnitPrice.TabIndex = 2;
            this.textBoxUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUnitPrice_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Controls.Add(this.labelSearchBy);
            this.groupBox1.Controls.Add(this.comboBoxSearch);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Location = new System.Drawing.Point(6, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 106);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(22, 55);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(121, 20);
            this.textBoxSearch.TabIndex = 6;
            // 
            // labelSearchBy
            // 
            this.labelSearchBy.AutoSize = true;
            this.labelSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSearchBy.Location = new System.Drawing.Point(19, 25);
            this.labelSearchBy.Name = "labelSearchBy";
            this.labelSearchBy.Size = new System.Drawing.Size(69, 13);
            this.labelSearchBy.TabIndex = 12;
            this.labelSearchBy.Text = "Search By:";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "ISBN",
            "Title",
            "Unit Price",
            "Year Published",
            "QOH"});
            this.comboBoxSearch.Location = new System.Drawing.Point(117, 17);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearch.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(163, 55);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "&Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearchBook_Click);
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(6, 491);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(125, 23);
            this.buttonList.TabIndex = 32;
            this.buttonList.Text = "&List Books";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonListBook_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(27, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Unit Price:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelLastName.Location = new System.Drawing.Point(27, 62);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(36, 13);
            this.labelLastName.TabIndex = 33;
            this.labelLastName.Text = "Title:";
            // 
            // labelSBN
            // 
            this.labelSBN.AutoSize = true;
            this.labelSBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSBN.Location = new System.Drawing.Point(27, 23);
            this.labelSBN.Name = "labelSBN";
            this.labelSBN.Size = new System.Drawing.Size(40, 13);
            this.labelSBN.TabIndex = 30;
            this.labelSBN.Text = "ISBN:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(125, 58);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(121, 20);
            this.textBoxTitle.TabIndex = 1;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(125, 19);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(121, 20);
            this.textBoxISBN.TabIndex = 0;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(19, 30);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(462, 391);
            this.dataGridViewResult.TabIndex = 29;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(79, 444);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 23);
            this.buttonAdd.TabIndex = 31;
            this.buttonAdd.Text = "&Add Book";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // textBoxQOH
            // 
            this.textBoxQOH.Location = new System.Drawing.Point(125, 175);
            this.textBoxQOH.Name = "textBoxQOH";
            this.textBoxQOH.Size = new System.Drawing.Size(121, 20);
            this.textBoxQOH.TabIndex = 4;
            this.textBoxQOH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQOH_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(27, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "QOH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(27, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Year Published:";
            // 
            // textBoxYearPublished
            // 
            this.textBoxYearPublished.Location = new System.Drawing.Point(125, 136);
            this.textBoxYearPublished.Name = "textBoxYearPublished";
            this.textBoxYearPublished.Size = new System.Drawing.Size(121, 20);
            this.textBoxYearPublished.TabIndex = 3;
            this.textBoxYearPublished.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYearPublished_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxBookAuthorID);
            this.groupBox2.Controls.Add(this.labelBookAuthorID);
            this.groupBox2.Controls.Add(this.buttonListPublisher);
            this.groupBox2.Controls.Add(this.textBoxQOH);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxYearPublished);
            this.groupBox2.Controls.Add(this.textBoxPublisherName);
            this.groupBox2.Controls.Add(this.textBoxUnitPrice);
            this.groupBox2.Controls.Add(this.labelPublisherName);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.textBoxPublisherID);
            this.groupBox2.Controls.Add(this.buttonList);
            this.groupBox2.Controls.Add(this.labelPublisherID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelLastName);
            this.groupBox2.Controls.Add(this.labelSBN);
            this.groupBox2.Controls.Add(this.textBoxTitle);
            this.groupBox2.Controls.Add(this.textBoxISBN);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Location = new System.Drawing.Point(509, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 529);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book";
            // 
            // textBoxPublisherName
            // 
            this.textBoxPublisherName.Location = new System.Drawing.Point(125, 253);
            this.textBoxPublisherName.Name = "textBoxPublisherName";
            this.textBoxPublisherName.Size = new System.Drawing.Size(121, 20);
            this.textBoxPublisherName.TabIndex = 45;
            // 
            // labelPublisherName
            // 
            this.labelPublisherName.AutoSize = true;
            this.labelPublisherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPublisherName.Location = new System.Drawing.Point(27, 257);
            this.labelPublisherName.Name = "labelPublisherName";
            this.labelPublisherName.Size = new System.Drawing.Size(73, 13);
            this.labelPublisherName.TabIndex = 46;
            this.labelPublisherName.Text = "Pub. Name:";
            // 
            // textBoxPublisherID
            // 
            this.textBoxPublisherID.Location = new System.Drawing.Point(125, 214);
            this.textBoxPublisherID.Name = "textBoxPublisherID";
            this.textBoxPublisherID.Size = new System.Drawing.Size(121, 20);
            this.textBoxPublisherID.TabIndex = 43;
            this.textBoxPublisherID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPublisherID_KeyPress);
            // 
            // labelPublisherID
            // 
            this.labelPublisherID.AutoSize = true;
            this.labelPublisherID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPublisherID.Location = new System.Drawing.Point(27, 218);
            this.labelPublisherID.Name = "labelPublisherID";
            this.labelPublisherID.Size = new System.Drawing.Size(80, 13);
            this.labelPublisherID.TabIndex = 44;
            this.labelPublisherID.Text = "Publisher ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxEmail);
            this.groupBox3.Controls.Add(this.textBoxLastName);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.buttonList2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxFirstName);
            this.groupBox3.Controls.Add(this.textBoxAuthorID);
            this.groupBox3.Controls.Add(this.buttonAdd2);
            this.groupBox3.Location = new System.Drawing.Point(819, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 365);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(27, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(125, 142);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(121, 20);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(125, 104);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(121, 20);
            this.textBoxLastName.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxSearch2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.comboBoxSearch2);
            this.groupBox4.Controls.Add(this.buttonSearch2);
            this.groupBox4.Location = new System.Drawing.Point(8, 212);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 106);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            // 
            // textBoxSearch2
            // 
            this.textBoxSearch2.Location = new System.Drawing.Point(22, 55);
            this.textBoxSearch2.Name = "textBoxSearch2";
            this.textBoxSearch2.Size = new System.Drawing.Size(121, 20);
            this.textBoxSearch2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(19, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Search By:";
            // 
            // comboBoxSearch2
            // 
            this.comboBoxSearch2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch2.FormattingEnabled = true;
            this.comboBoxSearch2.Items.AddRange(new object[] {
            "Author ID",
            "First Name",
            "Last Name",
            "Email"});
            this.comboBoxSearch2.Location = new System.Drawing.Point(117, 17);
            this.comboBoxSearch2.Name = "comboBoxSearch2";
            this.comboBoxSearch2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearch2.TabIndex = 5;
            // 
            // buttonSearch2
            // 
            this.buttonSearch2.Location = new System.Drawing.Point(163, 55);
            this.buttonSearch2.Name = "buttonSearch2";
            this.buttonSearch2.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch2.TabIndex = 5;
            this.buttonSearch2.Text = "&Search";
            this.buttonSearch2.UseVisualStyleBackColor = true;
            this.buttonSearch2.Click += new System.EventHandler(this.buttonSearchAuthor_Click);
            // 
            // buttonList2
            // 
            this.buttonList2.Location = new System.Drawing.Point(204, 332);
            this.buttonList2.Name = "buttonList2";
            this.buttonList2.Size = new System.Drawing.Size(75, 23);
            this.buttonList2.TabIndex = 32;
            this.buttonList2.Text = "&List";
            this.buttonList2.UseVisualStyleBackColor = true;
            this.buttonList2.Click += new System.EventHandler(this.buttonListAuthor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(27, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Last Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(27, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "First Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(27, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Author ID:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(125, 60);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(121, 20);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxAuthorID
            // 
            this.textBoxAuthorID.Location = new System.Drawing.Point(125, 16);
            this.textBoxAuthorID.Name = "textBoxAuthorID";
            this.textBoxAuthorID.Size = new System.Drawing.Size(121, 20);
            this.textBoxAuthorID.TabIndex = 0;
            this.textBoxAuthorID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAuthorID_KeyPress);
            // 
            // buttonAdd2
            // 
            this.buttonAdd2.Location = new System.Drawing.Point(17, 332);
            this.buttonAdd2.Name = "buttonAdd2";
            this.buttonAdd2.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd2.TabIndex = 31;
            this.buttonAdd2.Text = "&Add";
            this.buttonAdd2.UseVisualStyleBackColor = true;
            this.buttonAdd2.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.ForeColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(1023, 509);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 34;
            this.buttonExit.Text = "&Back";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonListPublisher
            // 
            this.buttonListPublisher.Location = new System.Drawing.Point(154, 491);
            this.buttonListPublisher.Name = "buttonListPublisher";
            this.buttonListPublisher.Size = new System.Drawing.Size(125, 23);
            this.buttonListPublisher.TabIndex = 43;
            this.buttonListPublisher.Text = "List &Publishers";
            this.buttonListPublisher.UseVisualStyleBackColor = true;
            this.buttonListPublisher.Click += new System.EventHandler(this.buttonListPublisher_Click);
            // 
            // textBoxBookAuthorID
            // 
            this.textBoxBookAuthorID.Location = new System.Drawing.Point(125, 292);
            this.textBoxBookAuthorID.Name = "textBoxBookAuthorID";
            this.textBoxBookAuthorID.Size = new System.Drawing.Size(121, 20);
            this.textBoxBookAuthorID.TabIndex = 49;
            this.textBoxBookAuthorID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBookAuthorID_KeyPress);
            // 
            // labelBookAuthorID
            // 
            this.labelBookAuthorID.AutoSize = true;
            this.labelBookAuthorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelBookAuthorID.Location = new System.Drawing.Point(27, 296);
            this.labelBookAuthorID.Name = "labelBookAuthorID";
            this.labelBookAuthorID.Size = new System.Drawing.Size(65, 13);
            this.labelBookAuthorID.TabIndex = 50;
            this.labelBookAuthorID.Text = "Author ID:";
            // 
            // FormInventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(1116, 562);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewResult);
            this.Name = "FormInventoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearchBy;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelSBN;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxQOH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxYearPublished;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxSearch2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSearch2;
        private System.Windows.Forms.Button buttonSearch2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonList2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxAuthorID;
        private System.Windows.Forms.Button buttonAdd2;
        private System.Windows.Forms.Button buttonListPublisher;
        private System.Windows.Forms.TextBox textBoxPublisherName;
        private System.Windows.Forms.Label labelPublisherName;
        private System.Windows.Forms.TextBox textBoxPublisherID;
        private System.Windows.Forms.Label labelPublisherID;
        private System.Windows.Forms.TextBox textBoxBookAuthorID;
        private System.Windows.Forms.Label labelBookAuthorID;
    }
}