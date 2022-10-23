namespace RevisedPartsEntry
{
    partial class PartsEntry
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.partNumberTextBox = new System.Windows.Forms.TextBox();
            this.partDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.itemClassTextBox = new System.Windows.Forms.TextBox();
            this.unitsOnHandTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.totalInventoryCostTextBox = new System.Windows.Forms.TextBox();
            this.leadTimeTextBox = new System.Windows.Forms.TextBox();
            this.dailyUsageTextBox = new System.Windows.Forms.TextBox();
            this.reorderPointTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Part Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Part Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Inventory Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unit Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Units On Hand";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Reorder Point";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Daily Usage";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Lead Time In Days";
            // 
            // partNumberTextBox
            // 
            this.partNumberTextBox.Location = new System.Drawing.Point(283, 31);
            this.partNumberTextBox.Name = "partNumberTextBox";
            this.partNumberTextBox.Size = new System.Drawing.Size(218, 31);
            this.partNumberTextBox.TabIndex = 1;
            this.partNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.partNumberTextBox_Validating);
            // 
            // partDescriptionTextBox
            // 
            this.partDescriptionTextBox.Location = new System.Drawing.Point(283, 85);
            this.partDescriptionTextBox.Name = "partDescriptionTextBox";
            this.partDescriptionTextBox.Size = new System.Drawing.Size(218, 31);
            this.partDescriptionTextBox.TabIndex = 2;
            this.partDescriptionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.partDescriptionTextBox_Validating);
            // 
            // itemClassTextBox
            // 
            this.itemClassTextBox.Location = new System.Drawing.Point(283, 137);
            this.itemClassTextBox.Name = "itemClassTextBox";
            this.itemClassTextBox.Size = new System.Drawing.Size(218, 31);
            this.itemClassTextBox.TabIndex = 3;
            this.itemClassTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.itemClassTextBox_Validating);
            // 
            // unitsOnHandTextBox
            // 
            this.unitsOnHandTextBox.Location = new System.Drawing.Point(283, 188);
            this.unitsOnHandTextBox.Name = "unitsOnHandTextBox";
            this.unitsOnHandTextBox.Size = new System.Drawing.Size(218, 31);
            this.unitsOnHandTextBox.TabIndex = 4;
            this.unitsOnHandTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.unitsOnHandTextBox_Validating);
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(283, 246);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(218, 31);
            this.unitPriceTextBox.TabIndex = 5;
            this.unitPriceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.unitPriceTextBox_Validating);
            // 
            // totalInventoryCostTextBox
            // 
            this.totalInventoryCostTextBox.Location = new System.Drawing.Point(283, 305);
            this.totalInventoryCostTextBox.Name = "totalInventoryCostTextBox";
            this.totalInventoryCostTextBox.Size = new System.Drawing.Size(218, 31);
            this.totalInventoryCostTextBox.TabIndex = 6;
            // 
            // leadTimeTextBox
            // 
            this.leadTimeTextBox.Location = new System.Drawing.Point(283, 355);
            this.leadTimeTextBox.Name = "leadTimeTextBox";
            this.leadTimeTextBox.Size = new System.Drawing.Size(218, 31);
            this.leadTimeTextBox.TabIndex = 7;
            this.leadTimeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.leadTimeTextBox_Validating);
            // 
            // dailyUsageTextBox
            // 
            this.dailyUsageTextBox.Location = new System.Drawing.Point(283, 410);
            this.dailyUsageTextBox.Name = "dailyUsageTextBox";
            this.dailyUsageTextBox.Size = new System.Drawing.Size(218, 31);
            this.dailyUsageTextBox.TabIndex = 8;
            this.dailyUsageTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.dailyUsageTextBox_Validating);
            // 
            // reorderPointTextBox
            // 
            this.reorderPointTextBox.Location = new System.Drawing.Point(283, 469);
            this.reorderPointTextBox.Name = "reorderPointTextBox";
            this.reorderPointTextBox.Size = new System.Drawing.Size(218, 31);
            this.reorderPointTextBox.TabIndex = 9;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(115, 525);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(124, 40);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(270, 525);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(124, 40);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(427, 525);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(124, 40);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // PartsEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 586);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.reorderPointTextBox);
            this.Controls.Add(this.dailyUsageTextBox);
            this.Controls.Add(this.leadTimeTextBox);
            this.Controls.Add(this.totalInventoryCostTextBox);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.unitsOnHandTextBox);
            this.Controls.Add(this.itemClassTextBox);
            this.Controls.Add(this.partDescriptionTextBox);
            this.Controls.Add(this.partNumberTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PartsEntry";
            this.Text = "Parts Entry";
            this.Load += new System.EventHandler(this.PartsEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox partNumberTextBox;
        private System.Windows.Forms.TextBox partDescriptionTextBox;
        private System.Windows.Forms.TextBox itemClassTextBox;
        private System.Windows.Forms.TextBox unitsOnHandTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox totalInventoryCostTextBox;
        private System.Windows.Forms.TextBox leadTimeTextBox;
        private System.Windows.Forms.TextBox dailyUsageTextBox;
        private System.Windows.Forms.TextBox reorderPointTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

