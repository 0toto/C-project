namespace NoonGilGUI
{
    partial class incomeStatus
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.housingInput = new System.Windows.Forms.TextBox();
            this.eduInput = new System.Windows.Forms.TextBox();
            this.tranInput = new System.Windows.Forms.TextBox();
            this.foodInput = new System.Windows.Forms.TextBox();
            this.preInput = new System.Windows.Forms.TextBox();
            this.otherInput = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.graphButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "housing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "transportation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "education";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "groceries/food";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "pre-authorized payment";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "others";
            // 
            // housingInput
            // 
            this.housingInput.Location = new System.Drawing.Point(251, 36);
            this.housingInput.Name = "housingInput";
            this.housingInput.Size = new System.Drawing.Size(100, 20);
            this.housingInput.TabIndex = 6;
            // 
            // eduInput
            // 
            this.eduInput.Location = new System.Drawing.Point(251, 124);
            this.eduInput.Name = "eduInput";
            this.eduInput.Size = new System.Drawing.Size(100, 20);
            this.eduInput.TabIndex = 7;
            // 
            // tranInput
            // 
            this.tranInput.Location = new System.Drawing.Point(251, 81);
            this.tranInput.Name = "tranInput";
            this.tranInput.Size = new System.Drawing.Size(100, 20);
            this.tranInput.TabIndex = 8;
            // 
            // foodInput
            // 
            this.foodInput.Location = new System.Drawing.Point(251, 168);
            this.foodInput.Name = "foodInput";
            this.foodInput.Size = new System.Drawing.Size(100, 20);
            this.foodInput.TabIndex = 9;
            // 
            // preInput
            // 
            this.preInput.Location = new System.Drawing.Point(251, 207);
            this.preInput.Name = "preInput";
            this.preInput.Size = new System.Drawing.Size(100, 20);
            this.preInput.TabIndex = 10;
            // 
            // otherInput
            // 
            this.otherInput.Location = new System.Drawing.Point(251, 247);
            this.otherInput.Name = "otherInput";
            this.otherInput.Size = new System.Drawing.Size(100, 20);
            this.otherInput.TabIndex = 12;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "anually",
            "monthly",
            "bi-weekly",
            "weekly",
            "hourly"});
            this.checkedListBox1.Location = new System.Drawing.Point(254, 73);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(130, 19);
            this.checkedListBox1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.graphButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.otherInput);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.preInput);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.foodInput);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tranInput);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.eduInput);
            this.panel1.Controls.Add(this.housingInput);
            this.panel1.Location = new System.Drawing.Point(10, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 320);
            this.panel1.TabIndex = 14;
            // 
            // graphButton
            // 
            this.graphButton.Location = new System.Drawing.Point(133, 282);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(102, 33);
            this.graphButton.TabIndex = 13;
            this.graphButton.Text = "Start Graph";
            this.graphButton.UseVisualStyleBackColor = true;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // incomeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "incomeStatus";
            this.Text = "income page";
            this.Load += new System.EventHandler(this.incomeStatus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox housingInput;
        private System.Windows.Forms.TextBox eduInput;
        private System.Windows.Forms.TextBox tranInput;
        private System.Windows.Forms.TextBox foodInput;
        private System.Windows.Forms.TextBox preInput;
        private System.Windows.Forms.TextBox otherInput;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button graphButton;
    }
}