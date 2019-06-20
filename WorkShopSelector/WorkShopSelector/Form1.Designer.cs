namespace WorkShopSelector
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
            this.locations = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Workshops = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registrationCostTextBox = new System.Windows.Forms.TextBox();
            this.lodgingCostTextBox = new System.Windows.Forms.TextBox();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // locations
            // 
            this.locations.FormattingEnabled = true;
            this.locations.ItemHeight = 16;
            this.locations.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.locations.Location = new System.Drawing.Point(37, 45);
            this.locations.Name = "locations";
            this.locations.Size = new System.Drawing.Size(303, 116);
            this.locations.TabIndex = 1;
            this.locations.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Workshops);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 257);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Workshops";
            // 
            // Workshops
            // 
            this.Workshops.FormattingEnabled = true;
            this.Workshops.ItemHeight = 16;
            this.Workshops.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Manegement",
            "Supervision Skills",
            "Negotiation",
            "How To Interview"});
            this.Workshops.Location = new System.Drawing.Point(30, 49);
            this.Workshops.Name = "Workshops";
            this.Workshops.Size = new System.Drawing.Size(303, 116);
            this.Workshops.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.locations);
            this.groupBox2.Location = new System.Drawing.Point(411, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 253);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Locations";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(233, 376);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(172, 62);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(411, 376);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(172, 62);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registration Cost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lodging Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Cost:";
            // 
            // registrationCostTextBox
            // 
            this.registrationCostTextBox.Location = new System.Drawing.Point(411, 272);
            this.registrationCostTextBox.Name = "registrationCostTextBox";
            this.registrationCostTextBox.Size = new System.Drawing.Size(100, 22);
            this.registrationCostTextBox.TabIndex = 7;
            // 
            // lodgingCostTextBox
            // 
            this.lodgingCostTextBox.Location = new System.Drawing.Point(411, 299);
            this.lodgingCostTextBox.Name = "lodgingCostTextBox";
            this.lodgingCostTextBox.Size = new System.Drawing.Size(100, 22);
            this.lodgingCostTextBox.TabIndex = 8;
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.Location = new System.Drawing.Point(411, 328);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalCostTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalCostTextBox);
            this.Controls.Add(this.lodgingCostTextBox);
            this.Controls.Add(this.registrationCostTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox locations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ListBox Workshops;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox registrationCostTextBox;
        private System.Windows.Forms.TextBox lodgingCostTextBox;
        private System.Windows.Forms.TextBox totalCostTextBox;
    }
}

