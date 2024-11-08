namespace SWPDM_Update_Card_Data
{
    partial class WindowForm
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
            this.label11 = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.UpdateCardData_button = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Way1_tab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CenterBottom_textBox = new System.Windows.Forms.TextBox();
            this.CenterTopMGP_textBox = new System.Windows.Forms.TextBox();
            this.TipExtension_textBox = new System.Windows.Forms.TextBox();
            this.Preload_textBox = new System.Windows.Forms.TextBox();
            this.DutPlunger_textBox = new System.Windows.Forms.TextBox();
            this.TotalLength_textBox = new System.Windows.Forms.TextBox();
            this.TipType_textBox = new System.Windows.Forms.TextBox();
            this.Probe_textBox = new System.Windows.Forms.TextBox();
            this.CenterOfWeb_textBox = new System.Windows.Forms.TextBox();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.Way2_tab = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl.SuspendLayout();
            this.Way1_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Way2_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(276, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Probe Parameters";
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(242, 355);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 4;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // UpdateCardData_button
            // 
            this.UpdateCardData_button.Location = new System.Drawing.Point(323, 355);
            this.UpdateCardData_button.Name = "UpdateCardData_button";
            this.UpdateCardData_button.Size = new System.Drawing.Size(110, 23);
            this.UpdateCardData_button.TabIndex = 4;
            this.UpdateCardData_button.Text = "Update Card Data";
            this.UpdateCardData_button.UseVisualStyleBackColor = true;
            this.UpdateCardData_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Way1_tab);
            this.tabControl.Controls.Add(this.Way2_tab);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(425, 337);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 6;
            // 
            // Way1_tab
            // 
            this.Way1_tab.BackColor = System.Drawing.SystemColors.Window;
            this.Way1_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Way1_tab.Controls.Add(this.pictureBox1);
            this.Way1_tab.Controls.Add(this.groupBox1);
            this.Way1_tab.ForeColor = System.Drawing.SystemColors.Window;
            this.Way1_tab.Location = new System.Drawing.Point(4, 22);
            this.Way1_tab.Name = "Way1_tab";
            this.Way1_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Way1_tab.Size = new System.Drawing.Size(417, 311);
            this.Way1_tab.TabIndex = 0;
            this.Way1_tab.Text = "Way 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SWPDM_Update_Card_Data.Properties.Resources.probe_illustration;
            this.pictureBox1.Location = new System.Drawing.Point(352, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 259);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CenterBottom_textBox);
            this.groupBox1.Controls.Add(this.CenterTopMGP_textBox);
            this.groupBox1.Controls.Add(this.TipExtension_textBox);
            this.groupBox1.Controls.Add(this.Preload_textBox);
            this.groupBox1.Controls.Add(this.DutPlunger_textBox);
            this.groupBox1.Controls.Add(this.TotalLength_textBox);
            this.groupBox1.Controls.Add(this.TipType_textBox);
            this.groupBox1.Controls.Add(this.Probe_textBox);
            this.groupBox1.Controls.Add(this.CenterOfWeb_textBox);
            this.groupBox1.Controls.Add(this.Description_textBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 301);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Card Parameters for this probe";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Center-Bottom MGP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Center-Top MGP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tip Extension";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Preload";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Dut Plunger";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tip type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Probe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Center of Web";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Description";
            // 
            // CenterBottom_textBox
            // 
            this.CenterBottom_textBox.Location = new System.Drawing.Point(121, 269);
            this.CenterBottom_textBox.Name = "CenterBottom_textBox";
            this.CenterBottom_textBox.Size = new System.Drawing.Size(189, 20);
            this.CenterBottom_textBox.TabIndex = 11;
            // 
            // CenterTopMGP_textBox
            // 
            this.CenterTopMGP_textBox.Location = new System.Drawing.Point(121, 242);
            this.CenterTopMGP_textBox.Name = "CenterTopMGP_textBox";
            this.CenterTopMGP_textBox.Size = new System.Drawing.Size(189, 20);
            this.CenterTopMGP_textBox.TabIndex = 10;
            // 
            // TipExtension_textBox
            // 
            this.TipExtension_textBox.Location = new System.Drawing.Point(121, 215);
            this.TipExtension_textBox.Name = "TipExtension_textBox";
            this.TipExtension_textBox.Size = new System.Drawing.Size(189, 20);
            this.TipExtension_textBox.TabIndex = 9;
            // 
            // Preload_textBox
            // 
            this.Preload_textBox.Location = new System.Drawing.Point(121, 188);
            this.Preload_textBox.Name = "Preload_textBox";
            this.Preload_textBox.Size = new System.Drawing.Size(189, 20);
            this.Preload_textBox.TabIndex = 8;
            // 
            // DutPlunger_textBox
            // 
            this.DutPlunger_textBox.Location = new System.Drawing.Point(121, 161);
            this.DutPlunger_textBox.Name = "DutPlunger_textBox";
            this.DutPlunger_textBox.Size = new System.Drawing.Size(189, 20);
            this.DutPlunger_textBox.TabIndex = 7;
            // 
            // TotalLength_textBox
            // 
            this.TotalLength_textBox.Location = new System.Drawing.Point(121, 134);
            this.TotalLength_textBox.Name = "TotalLength_textBox";
            this.TotalLength_textBox.Size = new System.Drawing.Size(189, 20);
            this.TotalLength_textBox.TabIndex = 6;
            // 
            // TipType_textBox
            // 
            this.TipType_textBox.Location = new System.Drawing.Point(121, 107);
            this.TipType_textBox.Name = "TipType_textBox";
            this.TipType_textBox.Size = new System.Drawing.Size(189, 20);
            this.TipType_textBox.TabIndex = 5;
            // 
            // Probe_textBox
            // 
            this.Probe_textBox.Location = new System.Drawing.Point(121, 80);
            this.Probe_textBox.Name = "Probe_textBox";
            this.Probe_textBox.Size = new System.Drawing.Size(189, 20);
            this.Probe_textBox.TabIndex = 4;
            // 
            // CenterOfWeb_textBox
            // 
            this.CenterOfWeb_textBox.Location = new System.Drawing.Point(121, 28);
            this.CenterOfWeb_textBox.Name = "CenterOfWeb_textBox";
            this.CenterOfWeb_textBox.Size = new System.Drawing.Size(189, 20);
            this.CenterOfWeb_textBox.TabIndex = 12;
            // 
            // Description_textBox
            // 
            this.Description_textBox.Location = new System.Drawing.Point(121, 54);
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.Size = new System.Drawing.Size(189, 20);
            this.Description_textBox.TabIndex = 3;
            // 
            // Way2_tab
            // 
            this.Way2_tab.Controls.Add(this.radioButton1);
            this.Way2_tab.Controls.Add(this.label12);
            this.Way2_tab.Controls.Add(this.radioButton2);
            this.Way2_tab.Controls.Add(this.richTextBox2);
            this.Way2_tab.Controls.Add(this.richTextBox1);
            this.Way2_tab.ForeColor = System.Drawing.SystemColors.Window;
            this.Way2_tab.Location = new System.Drawing.Point(4, 22);
            this.Way2_tab.Name = "Way2_tab";
            this.Way2_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Way2_tab.Size = new System.Drawing.Size(417, 311);
            this.Way2_tab.TabIndex = 1;
            this.Way2_tab.Text = "Way 2";
            this.Way2_tab.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Paste properties value here:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.radioButton2.Location = new System.Drawing.Point(173, 15);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(141, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "All probes in this location";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.radioButton1.Location = new System.Drawing.Point(28, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "The selected probe";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(6, 229);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(325, 76);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "Syntax: \n     Field_A  Field_B  Field_C  ...\n     MEM-xxxx00-01  <value> <value> " +
    "...\n     MEM-xxxx01-01  <value> <value> ...\n     MEM-xxxx02-01  <value> <value> " +
    "...";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(405, 147);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // WindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(446, 389);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.UpdateCardData_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.tabControl);
            this.Name = "WindowForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Card Data";
            this.tabControl.ResumeLayout(false);
            this.Way1_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Way2_tab.ResumeLayout(false);
            this.Way2_tab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button UpdateCardData_button;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Way1_tab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CenterBottom_textBox;
        private System.Windows.Forms.TextBox CenterTopMGP_textBox;
        private System.Windows.Forms.TextBox TipExtension_textBox;
        private System.Windows.Forms.TextBox Preload_textBox;
        private System.Windows.Forms.TextBox DutPlunger_textBox;
        private System.Windows.Forms.TextBox TotalLength_textBox;
        private System.Windows.Forms.TextBox TipType_textBox;
        private System.Windows.Forms.TextBox Probe_textBox;
        private System.Windows.Forms.TextBox CenterOfWeb_textBox;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.TabPage Way2_tab;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}