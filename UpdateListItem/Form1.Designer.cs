namespace EkipUyesiDegistirForm
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchFieldValueTxt = new System.Windows.Forms.TextBox();
            this.ReplaceFieldValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.siteurltxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.domain = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ReplaceFieldName = new System.Windows.Forms.TextBox();
            this.SearchFieldName = new System.Windows.Forms.TextBox();
            this.listname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.infolbl = new System.Windows.Forms.Label();
            this.OpenSettingBtn = new System.Windows.Forms.Button();
            this.saveSettingBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(152, 197);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(2);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(92, 37);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Value (Begins With)";
            // 
            // SearchFieldValueTxt
            // 
            this.SearchFieldValueTxt.Location = new System.Drawing.Point(233, 76);
            this.SearchFieldValueTxt.Margin = new System.Windows.Forms.Padding(2);
            this.SearchFieldValueTxt.Name = "SearchFieldValueTxt";
            this.SearchFieldValueTxt.Size = new System.Drawing.Size(148, 20);
            this.SearchFieldValueTxt.TabIndex = 2;
            // 
            // ReplaceFieldValue
            // 
            this.ReplaceFieldValue.Location = new System.Drawing.Point(238, 142);
            this.ReplaceFieldValue.Margin = new System.Windows.Forms.Padding(2);
            this.ReplaceFieldValue.Name = "ReplaceFieldValue";
            this.ReplaceFieldValue.Size = new System.Drawing.Size(144, 20);
            this.ReplaceFieldValue.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Replace Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sharepoint Site Adress";
            // 
            // siteurltxt
            // 
            this.siteurltxt.Location = new System.Drawing.Point(129, 10);
            this.siteurltxt.Margin = new System.Windows.Forms.Padding(2);
            this.siteurltxt.Name = "siteurltxt";
            this.siteurltxt.Size = new System.Drawing.Size(315, 20);
            this.siteurltxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(226, 34);
            this.username.Margin = new System.Windows.Forms.Padding(2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(85, 20);
            this.username.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Pass";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(362, 37);
            this.pass.Margin = new System.Windows.Forms.Padding(2);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(85, 20);
            this.pass.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Domain";
            // 
            // domain
            // 
            this.domain.Location = new System.Drawing.Point(59, 34);
            this.domain.Margin = new System.Windows.Forms.Padding(2);
            this.domain.Name = "domain";
            this.domain.Size = new System.Drawing.Size(85, 20);
            this.domain.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ReplaceFieldName);
            this.groupBox1.Controls.Add(this.ReplaceFieldValue);
            this.groupBox1.Controls.Add(this.SearchFieldName);
            this.groupBox1.Controls.Add(this.SearchFieldValueTxt);
            this.groupBox1.Controls.Add(this.StartBtn);
            this.groupBox1.Controls.Add(this.listname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(9, 93);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(434, 267);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update to List item Field By Search";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Replace Field Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Search Field Name";
            // 
            // ReplaceFieldName
            // 
            this.ReplaceFieldName.Location = new System.Drawing.Point(7, 142);
            this.ReplaceFieldName.Margin = new System.Windows.Forms.Padding(2);
            this.ReplaceFieldName.Name = "ReplaceFieldName";
            this.ReplaceFieldName.Size = new System.Drawing.Size(136, 20);
            this.ReplaceFieldName.TabIndex = 4;
            // 
            // SearchFieldName
            // 
            this.SearchFieldName.Location = new System.Drawing.Point(7, 76);
            this.SearchFieldName.Margin = new System.Windows.Forms.Padding(2);
            this.SearchFieldName.Name = "SearchFieldName";
            this.SearchFieldName.Size = new System.Drawing.Size(136, 20);
            this.SearchFieldName.TabIndex = 2;
            // 
            // listname
            // 
            this.listname.Location = new System.Drawing.Point(80, 26);
            this.listname.Margin = new System.Windows.Forms.Padding(2);
            this.listname.Name = "listname";
            this.listname.Size = new System.Drawing.Size(105, 20);
            this.listname.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "List Name";
            // 
            // infolbl
            // 
            this.infolbl.Location = new System.Drawing.Point(38, 378);
            this.infolbl.Name = "infolbl";
            this.infolbl.Size = new System.Drawing.Size(377, 53);
            this.infolbl.TabIndex = 6;
            // 
            // OpenSettingBtn
            // 
            this.OpenSettingBtn.Location = new System.Drawing.Point(15, 63);
            this.OpenSettingBtn.Name = "OpenSettingBtn";
            this.OpenSettingBtn.Size = new System.Drawing.Size(95, 23);
            this.OpenSettingBtn.TabIndex = 7;
            this.OpenSettingBtn.Text = "Open Settings";
            this.OpenSettingBtn.UseVisualStyleBackColor = true;
            this.OpenSettingBtn.Click += new System.EventHandler(this.OpenSettingBtn_Click);
            // 
            // saveSettingBtn
            // 
            this.saveSettingBtn.Location = new System.Drawing.Point(161, 63);
            this.saveSettingBtn.Name = "saveSettingBtn";
            this.saveSettingBtn.Size = new System.Drawing.Size(92, 23);
            this.saveSettingBtn.TabIndex = 8;
            this.saveSettingBtn.Text = "Save Settings";
            this.saveSettingBtn.UseVisualStyleBackColor = true;
            this.saveSettingBtn.Click += new System.EventHandler(this.saveSettingBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 440);
            this.Controls.Add(this.saveSettingBtn);
            this.Controls.Add(this.OpenSettingBtn);
            this.Controls.Add(this.infolbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.siteurltxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.domain);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "SharePoint Update List Item";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchFieldValueTxt;
        private System.Windows.Forms.TextBox ReplaceFieldValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox siteurltxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox domain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ReplaceFieldName;
        private System.Windows.Forms.TextBox SearchFieldName;
        private System.Windows.Forms.TextBox listname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label infolbl;
        private System.Windows.Forms.Button OpenSettingBtn;
        private System.Windows.Forms.Button saveSettingBtn;
    }
}

