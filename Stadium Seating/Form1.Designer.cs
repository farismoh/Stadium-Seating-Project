namespace Stadium_Seating
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ticketsSoldGroupBox = new System.Windows.Forms.GroupBox();
            this.revenueGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ticketALabel = new System.Windows.Forms.Label();
            this.ticketBLabel = new System.Windows.Forms.Label();
            this.ticketCLabel = new System.Windows.Forms.Label();
            this.revALabel = new System.Windows.Forms.Label();
            this.revBLabel = new System.Windows.Forms.Label();
            this.revCLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.aPromptLabel = new System.Windows.Forms.Label();
            this.bPromptLabel = new System.Windows.Forms.Label();
            this.cPromptLabel = new System.Windows.Forms.Label();
            this.totalPromptLabel = new System.Windows.Forms.Label();
            this.classATextBox = new System.Windows.Forms.TextBox();
            this.classBTextBox = new System.Windows.Forms.TextBox();
            this.classCTextBox = new System.Windows.Forms.TextBox();
            this.ticketsSoldGroupBox.SuspendLayout();
            this.revenueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(314, 522);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(148, 79);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate Revenue";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(518, 522);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(148, 79);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(724, 522);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(148, 79);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ticketsSoldGroupBox
            // 
            this.ticketsSoldGroupBox.Controls.Add(this.classCTextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.classBTextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.ticketCLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.classATextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.ticketBLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.ticketALabel);
            this.ticketsSoldGroupBox.Controls.Add(this.label1);
            this.ticketsSoldGroupBox.Location = new System.Drawing.Point(42, 60);
            this.ticketsSoldGroupBox.Name = "ticketsSoldGroupBox";
            this.ticketsSoldGroupBox.Size = new System.Drawing.Size(539, 440);
            this.ticketsSoldGroupBox.TabIndex = 3;
            this.ticketsSoldGroupBox.TabStop = false;
            this.ticketsSoldGroupBox.Text = "Tickets Sold";
            // 
            // revenueGroupBox
            // 
            this.revenueGroupBox.Controls.Add(this.totalPromptLabel);
            this.revenueGroupBox.Controls.Add(this.cPromptLabel);
            this.revenueGroupBox.Controls.Add(this.bPromptLabel);
            this.revenueGroupBox.Controls.Add(this.totalLabel);
            this.revenueGroupBox.Controls.Add(this.aPromptLabel);
            this.revenueGroupBox.Controls.Add(this.revCLabel);
            this.revenueGroupBox.Controls.Add(this.revALabel);
            this.revenueGroupBox.Controls.Add(this.revBLabel);
            this.revenueGroupBox.Location = new System.Drawing.Point(620, 60);
            this.revenueGroupBox.Name = "revenueGroupBox";
            this.revenueGroupBox.Size = new System.Drawing.Size(495, 440);
            this.revenueGroupBox.TabIndex = 4;
            this.revenueGroupBox.TabStop = false;
            this.revenueGroupBox.Text = "Revenue Generated";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter the numer of tickets sold\r\n for each class of seats.";
            // 
            // ticketALabel
            // 
            this.ticketALabel.AutoSize = true;
            this.ticketALabel.Location = new System.Drawing.Point(133, 148);
            this.ticketALabel.Name = "ticketALabel";
            this.ticketALabel.Size = new System.Drawing.Size(67, 20);
            this.ticketALabel.TabIndex = 6;
            this.ticketALabel.Text = "Class A:";
            // 
            // ticketBLabel
            // 
            this.ticketBLabel.AutoSize = true;
            this.ticketBLabel.Location = new System.Drawing.Point(133, 195);
            this.ticketBLabel.Name = "ticketBLabel";
            this.ticketBLabel.Size = new System.Drawing.Size(67, 20);
            this.ticketBLabel.TabIndex = 7;
            this.ticketBLabel.Text = "Class B:";
            // 
            // ticketCLabel
            // 
            this.ticketCLabel.AutoSize = true;
            this.ticketCLabel.Location = new System.Drawing.Point(133, 239);
            this.ticketCLabel.Name = "ticketCLabel";
            this.ticketCLabel.Size = new System.Drawing.Size(67, 20);
            this.ticketCLabel.TabIndex = 8;
            this.ticketCLabel.Text = "Class C:";
            // 
            // revALabel
            // 
            this.revALabel.AutoSize = true;
            this.revALabel.Location = new System.Drawing.Point(129, 103);
            this.revALabel.Name = "revALabel";
            this.revALabel.Size = new System.Drawing.Size(67, 20);
            this.revALabel.TabIndex = 9;
            this.revALabel.Text = "Class A:";
            // 
            // revBLabel
            // 
            this.revBLabel.AutoSize = true;
            this.revBLabel.Location = new System.Drawing.Point(129, 147);
            this.revBLabel.Name = "revBLabel";
            this.revBLabel.Size = new System.Drawing.Size(67, 20);
            this.revBLabel.TabIndex = 10;
            this.revBLabel.Text = "Class B:";
            // 
            // revCLabel
            // 
            this.revCLabel.AutoSize = true;
            this.revCLabel.Location = new System.Drawing.Point(129, 185);
            this.revCLabel.Name = "revCLabel";
            this.revCLabel.Size = new System.Drawing.Size(67, 20);
            this.revCLabel.TabIndex = 11;
            this.revCLabel.Text = "Class C:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(148, 236);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 12;
            this.totalLabel.Text = "Total:";
            // 
            // aPromptLabel
            // 
            this.aPromptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aPromptLabel.Location = new System.Drawing.Point(260, 100);
            this.aPromptLabel.Name = "aPromptLabel";
            this.aPromptLabel.Size = new System.Drawing.Size(193, 23);
            this.aPromptLabel.TabIndex = 9;
            // 
            // bPromptLabel
            // 
            this.bPromptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bPromptLabel.Location = new System.Drawing.Point(260, 144);
            this.bPromptLabel.Name = "bPromptLabel";
            this.bPromptLabel.Size = new System.Drawing.Size(193, 23);
            this.bPromptLabel.TabIndex = 10;
            // 
            // cPromptLabel
            // 
            this.cPromptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cPromptLabel.Location = new System.Drawing.Point(260, 185);
            this.cPromptLabel.Name = "cPromptLabel";
            this.cPromptLabel.Size = new System.Drawing.Size(193, 23);
            this.cPromptLabel.TabIndex = 11;
            // 
            // totalPromptLabel
            // 
            this.totalPromptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPromptLabel.Location = new System.Drawing.Point(260, 235);
            this.totalPromptLabel.Name = "totalPromptLabel";
            this.totalPromptLabel.Size = new System.Drawing.Size(193, 23);
            this.totalPromptLabel.TabIndex = 13;
            // 
            // classATextBox
            // 
            this.classATextBox.Location = new System.Drawing.Point(288, 148);
            this.classATextBox.Name = "classATextBox";
            this.classATextBox.Size = new System.Drawing.Size(197, 26);
            this.classATextBox.TabIndex = 14;
            // 
            // classBTextBox
            // 
            this.classBTextBox.Location = new System.Drawing.Point(288, 195);
            this.classBTextBox.Name = "classBTextBox";
            this.classBTextBox.Size = new System.Drawing.Size(197, 26);
            this.classBTextBox.TabIndex = 15;
            // 
            // classCTextBox
            // 
            this.classCTextBox.Location = new System.Drawing.Point(288, 233);
            this.classCTextBox.Name = "classCTextBox";
            this.classCTextBox.Size = new System.Drawing.Size(197, 26);
            this.classCTextBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 674);
            this.Controls.Add(this.revenueGroupBox);
            this.Controls.Add(this.ticketsSoldGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.ticketsSoldGroupBox.ResumeLayout(false);
            this.ticketsSoldGroupBox.PerformLayout();
            this.revenueGroupBox.ResumeLayout(false);
            this.revenueGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox ticketsSoldGroupBox;
        private System.Windows.Forms.TextBox classCTextBox;
        private System.Windows.Forms.TextBox classBTextBox;
        private System.Windows.Forms.Label ticketCLabel;
        private System.Windows.Forms.TextBox classATextBox;
        private System.Windows.Forms.Label ticketBLabel;
        private System.Windows.Forms.Label ticketALabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox revenueGroupBox;
        private System.Windows.Forms.Label totalPromptLabel;
        private System.Windows.Forms.Label cPromptLabel;
        private System.Windows.Forms.Label bPromptLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label aPromptLabel;
        private System.Windows.Forms.Label revCLabel;
        private System.Windows.Forms.Label revALabel;
        private System.Windows.Forms.Label revBLabel;
    }
}

