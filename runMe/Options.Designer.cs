namespace runMe
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl_systemExexute = new System.Windows.Forms.TabControl();
            this.tabPage_systemExecute = new System.Windows.Forms.TabPage();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl_systemExexute.SuspendLayout();
            this.tabPage_systemExecute.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.button1.Location = new System.Drawing.Point(263, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl_systemExexute
            // 
            this.tabControl_systemExexute.Controls.Add(this.tabPage_systemExecute);
            this.tabControl_systemExexute.Controls.Add(this.tabPage2);
            this.tabControl_systemExexute.Controls.Add(this.tabPage1);
            this.tabControl_systemExexute.Controls.Add(this.tabPage3);
            this.tabControl_systemExexute.Location = new System.Drawing.Point(12, 12);
            this.tabControl_systemExexute.Name = "tabControl_systemExexute";
            this.tabControl_systemExexute.SelectedIndex = 0;
            this.tabControl_systemExexute.Size = new System.Drawing.Size(330, 271);
            this.tabControl_systemExexute.TabIndex = 11;
            // 
            // tabPage_systemExecute
            // 
            this.tabPage_systemExecute.Controls.Add(this.checkBox3);
            this.tabPage_systemExecute.Controls.Add(this.textBox2);
            this.tabPage_systemExecute.Controls.Add(this.checkBox2);
            this.tabPage_systemExecute.Controls.Add(this.checkBox1);
            this.tabPage_systemExecute.Controls.Add(this.label1);
            this.tabPage_systemExecute.Controls.Add(this.textBox1);
            this.tabPage_systemExecute.Location = new System.Drawing.Point(4, 22);
            this.tabPage_systemExecute.Name = "tabPage_systemExecute";
            this.tabPage_systemExecute.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_systemExecute.Size = new System.Drawing.Size(322, 245);
            this.tabPage_systemExecute.TabIndex = 0;
            this.tabPage_systemExecute.Text = "System execute";
            this.tabPage_systemExecute.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = global::runMe.Properties.Settings.Default.systemExecuteOnlyFirstLine;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::runMe.Properties.Settings.Default, "systemExecuteOnlineFirstLine", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox3.Location = new System.Drawing.Point(9, 59);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(180, 17);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Only use first line on multiline text";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::runMe.Properties.Settings.Default, "systemExecuteSpaceReplaceString", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Location = new System.Drawing.Point(133, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(35, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = global::runMe.Properties.Settings.Default.systemExecuteSpaceReplaceString;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = global::runMe.Properties.Settings.Default.systemExecuteReplaceSpaces;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::runMe.Properties.Settings.Default, "systemExecuteReplaceSpaces", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.Location = new System.Drawing.Point(9, 105);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(131, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Replace spaces with: ";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::runMe.Properties.Settings.Default.systemExecuteNewlineToSpaces;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::runMe.Properties.Settings.Default, "systemExecuteNewlineToSpaces", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(9, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(169, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Replace newlines with spaces";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Command with parameters which shall be executed";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::runMe.Properties.Settings.Default, "systemExecuteCommand", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(9, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = global::runMe.Properties.Settings.Default.systemExecuteCommand;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(322, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Open webpage";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(322, 245);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "HTTP (Get)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(322, 245);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "HTTP (Post)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "The placeholders %title% and %text% will be replaced using the data of the notifi" +
                "cation";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(352, 390);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl_systemExexute);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.Text = "Run me Options";
            this.tabControl_systemExexute.ResumeLayout(false);
            this.tabPage_systemExecute.ResumeLayout(false);
            this.tabPage_systemExecute.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl_systemExexute;
        private System.Windows.Forms.TabPage tabPage_systemExecute;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
    }
}