namespace Labels
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            productName = new TextBox();
            label2 = new Label();
            orderNumber = new TextBox();
            txtSerials = new TextBox();
            label3 = new Label();
            label4 = new Label();
            listSerials = new ListBox();
            numQty = new NumericUpDown();
            btnGenerate = new Button();
            btnRemove = new Button();
            cwNum = new TextBox();
            label5 = new Label();
            chkNoSerial = new CheckBox();
            addInfo = new RichTextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 0;
            label1.Text = "Product Name:";
            label1.Click += label1_Click;
            // 
            // productName
            // 
            productName.Location = new Point(12, 37);
            productName.Name = "productName";
            productName.Size = new Size(176, 23);
            productName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(249, 64);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 2;
            label2.Text = "CW PO#:";
            // 
            // orderNumber
            // 
            orderNumber.Location = new Point(249, 92);
            orderNumber.Name = "orderNumber";
            orderNumber.Size = new Size(176, 23);
            orderNumber.TabIndex = 3;
            // 
            // txtSerials
            // 
            txtSerials.Location = new Point(12, 115);
            txtSerials.Name = "txtSerials";
            txtSerials.Size = new Size(146, 23);
            txtSerials.TabIndex = 4;
            txtSerials.KeyDown += txtSerials_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(193, 9);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 5;
            label3.Text = "Quantity:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(12, 87);
            label4.Name = "label4";
            label4.Size = new Size(146, 25);
            label4.TabIndex = 8;
            label4.Text = "Serial Number:";
            // 
            // listSerials
            // 
            listSerials.FormattingEnabled = true;
            listSerials.ItemHeight = 15;
            listSerials.Location = new Point(12, 144);
            listSerials.Name = "listSerials";
            listSerials.Size = new Size(146, 289);
            listSerials.TabIndex = 9;
            // 
            // numQty
            // 
            numQty.Location = new Point(193, 38);
            numQty.Name = "numQty";
            numQty.Size = new Size(94, 23);
            numQty.TabIndex = 10;
            numQty.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(304, 415);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(119, 23);
            btnGenerate.TabIndex = 11;
            btnGenerate.Text = "Generate Labels";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(164, 144);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(80, 61);
            btnRemove.TabIndex = 12;
            btnRemove.Text = "Remove Selected Serial";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // cwNum
            // 
            cwNum.Location = new Point(249, 142);
            cwNum.Name = "cwNum";
            cwNum.Size = new Size(176, 23);
            cwNum.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(249, 118);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 14;
            label5.Text = "CW #:";
            label5.Click += label5_Click;
            // 
            // chkNoSerial
            // 
            chkNoSerial.AutoSize = true;
            chkNoSerial.Location = new Point(164, 119);
            chkNoSerial.Name = "chkNoSerial";
            chkNoSerial.Size = new Size(79, 19);
            chkNoSerial.TabIndex = 15;
            chkNoSerial.Text = "Serial N/A";
            chkNoSerial.UseVisualStyleBackColor = true;
            chkNoSerial.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // addInfo
            // 
            addInfo.Location = new Point(164, 236);
            addInfo.Name = "addInfo";
            addInfo.Size = new Size(185, 96);
            addInfo.TabIndex = 16;
            addInfo.Text = "";
            addInfo.TextChanged += addInfo_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(164, 212);
            label6.Name = "label6";
            label6.Size = new Size(126, 21);
            label6.TabIndex = 17;
            label6.Text = "Additional Info";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 450);
            Controls.Add(label6);
            Controls.Add(addInfo);
            Controls.Add(chkNoSerial);
            Controls.Add(label5);
            Controls.Add(cwNum);
            Controls.Add(btnRemove);
            Controls.Add(btnGenerate);
            Controls.Add(numQty);
            Controls.Add(listSerials);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSerials);
            Controls.Add(orderNumber);
            Controls.Add(label2);
            Controls.Add(productName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Label Generator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox productName;
        private Label label2;
        private TextBox orderNumber;
        private TextBox txtSerials;
        private Label label3;
        private Label label4;
        private ListBox listSerials;
        private NumericUpDown numQty;
        private Button btnGenerate;
        private Button btnRemove;
        private TextBox cwNum;
        private Label label5;
        private CheckBox chkNoSerial;
        private RichTextBox addInfo;
        private Label label6;
    }
}
