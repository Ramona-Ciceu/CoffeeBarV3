namespace CoffeeBarV3
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
            this.uiCustomerCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uiBalanceTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uiPurchaseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.uiCostTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uiItemsCombo = new System.Windows.Forms.ComboBox();
            this.uiDepositButton = new System.Windows.Forms.Button();
            this.uiDepositTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uiLastItemTextbox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.uiDisplayOrdersTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.uiAddItemTextBox = new System.Windows.Forms.TextBox();
            this.uiAddPriceTextBox = new System.Windows.Forms.TextBox();
            this.uiAddItemButton = new System.Windows.Forms.Button();
            this.uiDiplayOrdersbutton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiCustomerCombo
            // 
            this.uiCustomerCombo.FormattingEnabled = true;
            this.uiCustomerCombo.Location = new System.Drawing.Point(43, 39);
            this.uiCustomerCombo.Name = "uiCustomerCombo";
            this.uiCustomerCombo.Size = new System.Drawing.Size(216, 21);
            this.uiCustomerCombo.TabIndex = 0;
            this.uiCustomerCombo.SelectedIndexChanged += new System.EventHandler(this.uiCustomerCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // uiBalanceTextbox
            // 
            this.uiBalanceTextbox.Location = new System.Drawing.Point(43, 80);
            this.uiBalanceTextbox.Name = "uiBalanceTextbox";
            this.uiBalanceTextbox.ReadOnly = true;
            this.uiBalanceTextbox.Size = new System.Drawing.Size(100, 20);
            this.uiBalanceTextbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Balance";
            // 
            // uiPurchaseButton
            // 
            this.uiPurchaseButton.Location = new System.Drawing.Point(370, 134);
            this.uiPurchaseButton.Name = "uiPurchaseButton";
            this.uiPurchaseButton.Size = new System.Drawing.Size(75, 23);
            this.uiPurchaseButton.TabIndex = 4;
            this.uiPurchaseButton.Text = "Purchase";
            this.uiPurchaseButton.UseVisualStyleBackColor = true;
            this.uiPurchaseButton.Click += new System.EventHandler(this.uiPurchaseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cost";
            // 
            // uiCostTextbox
            // 
            this.uiCostTextbox.Location = new System.Drawing.Point(367, 96);
            this.uiCostTextbox.Name = "uiCostTextbox";
            this.uiCostTextbox.ReadOnly = true;
            this.uiCostTextbox.Size = new System.Drawing.Size(100, 20);
            this.uiCostTextbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Item";
            // 
            // uiItemsCombo
            // 
            this.uiItemsCombo.FormattingEnabled = true;
            this.uiItemsCombo.Location = new System.Drawing.Point(367, 39);
            this.uiItemsCombo.Name = "uiItemsCombo";
            this.uiItemsCombo.Size = new System.Drawing.Size(216, 21);
            this.uiItemsCombo.TabIndex = 5;
            this.uiItemsCombo.SelectedIndexChanged += new System.EventHandler(this.uiItemsCombo_SelectedIndexChanged_1);
            // 
            // uiDepositButton
            // 
            this.uiDepositButton.Location = new System.Drawing.Point(46, 183);
            this.uiDepositButton.Name = "uiDepositButton";
            this.uiDepositButton.Size = new System.Drawing.Size(75, 23);
            this.uiDepositButton.TabIndex = 9;
            this.uiDepositButton.Text = "Deposit";
            this.uiDepositButton.UseVisualStyleBackColor = true;
            this.uiDepositButton.Click += new System.EventHandler(this.uiDepositButton_Click);
            // 
            // uiDepositTextBox
            // 
            this.uiDepositTextBox.Location = new System.Drawing.Point(46, 157);
            this.uiDepositTextBox.Name = "uiDepositTextBox";
            this.uiDepositTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiDepositTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Last Item";
            // 
            // uiLastItemTextbox
            // 
            this.uiLastItemTextbox.Location = new System.Drawing.Point(46, 121);
            this.uiLastItemTextbox.Name = "uiLastItemTextbox";
            this.uiLastItemTextbox.ReadOnly = true;
            this.uiLastItemTextbox.Size = new System.Drawing.Size(100, 20);
            this.uiLastItemTextbox.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // uiDisplayOrdersTextBox
            // 
            this.uiDisplayOrdersTextBox.Location = new System.Drawing.Point(0, 328);
            this.uiDisplayOrdersTextBox.Multiline = true;
            this.uiDisplayOrdersTextBox.Name = "uiDisplayOrdersTextBox";
            this.uiDisplayOrdersTextBox.Size = new System.Drawing.Size(689, 81);
            this.uiDisplayOrdersTextBox.TabIndex = 15;
            this.uiDisplayOrdersTextBox.TextChanged += new System.EventHandler(this.uiDisplayOrdersTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiAddItemButton);
            this.groupBox1.Controls.Add(this.uiAddPriceTextBox);
            this.groupBox1.Controls.Add(this.uiAddItemTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(277, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 129);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Item";
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Price";
            // 
            // uiAddItemTextBox
            // 
            this.uiAddItemTextBox.Location = new System.Drawing.Point(90, 32);
            this.uiAddItemTextBox.Name = "uiAddItemTextBox";
            this.uiAddItemTextBox.Size = new System.Drawing.Size(301, 20);
            this.uiAddItemTextBox.TabIndex = 2;
            // 
            // uiAddPriceTextBox
            // 
            this.uiAddPriceTextBox.Location = new System.Drawing.Point(93, 66);
            this.uiAddPriceTextBox.Name = "uiAddPriceTextBox";
            this.uiAddPriceTextBox.Size = new System.Drawing.Size(298, 20);
            this.uiAddPriceTextBox.TabIndex = 3;
            // 
            // uiAddItemButton
            // 
            this.uiAddItemButton.Location = new System.Drawing.Point(178, 100);
            this.uiAddItemButton.Name = "uiAddItemButton";
            this.uiAddItemButton.Size = new System.Drawing.Size(75, 23);
            this.uiAddItemButton.TabIndex = 4;
            this.uiAddItemButton.Text = "Add Item";
            this.uiAddItemButton.UseVisualStyleBackColor = true;
            this.uiAddItemButton.Click += new System.EventHandler(this.uiAddItemButton_Click);
            // 
            // uiDiplayOrdersbutton
            // 
            this.uiDiplayOrdersbutton.Location = new System.Drawing.Point(264, 415);
            this.uiDiplayOrdersbutton.Name = "uiDiplayOrdersbutton";
            this.uiDiplayOrdersbutton.Size = new System.Drawing.Size(117, 23);
            this.uiDiplayOrdersbutton.TabIndex = 17;
            this.uiDiplayOrdersbutton.Text = "Display All Orders";
            this.uiDiplayOrdersbutton.UseVisualStyleBackColor = true;
            this.uiDiplayOrdersbutton.Click += new System.EventHandler(this.uiDiplayOrdersbutton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Orders";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 442);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uiDiplayOrdersbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uiDisplayOrdersTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uiLastItemTextbox);
            this.Controls.Add(this.uiDepositTextBox);
            this.Controls.Add(this.uiDepositButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiCostTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiItemsCombo);
            this.Controls.Add(this.uiPurchaseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiBalanceTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiCustomerCombo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uiCustomerCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uiBalanceTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uiPurchaseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiCostTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox uiItemsCombo;
        private System.Windows.Forms.Button uiDepositButton;
        private System.Windows.Forms.TextBox uiDepositTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uiLastItemTextbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox uiDisplayOrdersTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button uiAddItemButton;
        private System.Windows.Forms.TextBox uiAddPriceTextBox;
        private System.Windows.Forms.TextBox uiAddItemTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button uiDiplayOrdersbutton;
        private System.Windows.Forms.Label label8;
    }
}

