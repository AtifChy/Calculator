namespace Calculator
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
            textBoxPanel = new Panel();
            txtDisplay = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnClear = new Button();
            btnResult = new Button();
            btnDelete = new Button();
            btnPlus = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btn00 = new Button();
            btnMinus = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnMultiply = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnDivide = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            textBoxPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxPanel
            // 
            textBoxPanel.Controls.Add(txtDisplay);
            textBoxPanel.Dock = DockStyle.Top;
            textBoxPanel.Location = new Point(0, 0);
            textBoxPanel.Name = "textBoxPanel";
            textBoxPanel.Padding = new Padding(10, 10, 10, 0);
            textBoxPanel.Size = new Size(502, 125);
            textBoxPanel.TabIndex = 0;
            // 
            // txtDisplay
            // 
            txtDisplay.Dock = DockStyle.Fill;
            txtDisplay.Font = new Font("Segoe UI Variable Display", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(10, 10);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(482, 114);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.WordWrap = false;
            txtDisplay.KeyDown += txtDisplay_KeyDown;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnClear, 0, 4);
            tableLayoutPanel1.Controls.Add(btnResult, 3, 4);
            tableLayoutPanel1.Controls.Add(btnDelete, 2, 4);
            tableLayoutPanel1.Controls.Add(btnPlus, 3, 3);
            tableLayoutPanel1.Controls.Add(btnDot, 2, 3);
            tableLayoutPanel1.Controls.Add(btn0, 1, 3);
            tableLayoutPanel1.Controls.Add(btn00, 0, 3);
            tableLayoutPanel1.Controls.Add(btnMinus, 3, 2);
            tableLayoutPanel1.Controls.Add(btn3, 2, 2);
            tableLayoutPanel1.Controls.Add(btn2, 1, 2);
            tableLayoutPanel1.Controls.Add(btn1, 0, 2);
            tableLayoutPanel1.Controls.Add(btnMultiply, 3, 1);
            tableLayoutPanel1.Controls.Add(btn6, 2, 1);
            tableLayoutPanel1.Controls.Add(btn5, 1, 1);
            tableLayoutPanel1.Controls.Add(btn4, 0, 1);
            tableLayoutPanel1.Controls.Add(btnDivide, 3, 0);
            tableLayoutPanel1.Controls.Add(btn9, 2, 0);
            tableLayoutPanel1.Controls.Add(btn8, 1, 0);
            tableLayoutPanel1.Controls.Add(btn7, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 125);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(502, 478);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnClear
            // 
            tableLayoutPanel1.SetColumnSpan(btnClear, 2);
            btnClear.Dock = DockStyle.Fill;
            btnClear.Font = new Font("Segoe UI Variable Display", 19.8000011F);
            btnClear.Location = new Point(8, 380);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(240, 90);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = SystemColors.Control;
            btnResult.Dock = DockStyle.Fill;
            btnResult.FlatStyle = FlatStyle.System;
            btnResult.Font = new Font("Segoe UI Variable Display", 19.8000011F);
            btnResult.Location = new Point(377, 380);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(117, 90);
            btnResult.TabIndex = 19;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Segoe UI Variable Display", 19.8000011F);
            btnDelete.Location = new Point(254, 380);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 90);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "⌫";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPlus
            // 
            btnPlus.Dock = DockStyle.Fill;
            btnPlus.Font = new Font("Segoe UI Variable Display", 19.8000011F);
            btnPlus.Location = new Point(377, 287);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(117, 87);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnDot
            // 
            btnDot.Dock = DockStyle.Fill;
            btnDot.Font = new Font("Segoe UI Variable Display", 19.8000011F);
            btnDot.Location = new Point(254, 287);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(117, 87);
            btnDot.TabIndex = 14;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btn0
            // 
            btn0.Dock = DockStyle.Fill;
            btn0.Font = new Font("Segoe UI Variable Display", 19.8000011F);
            btn0.Location = new Point(131, 287);
            btn0.Name = "btn0";
            btn0.Size = new Size(117, 87);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn00
            // 
            btn00.Dock = DockStyle.Fill;
            btn00.Font = new Font("Segoe UI Variable Display", 19.8000011F);
            btn00.Location = new Point(8, 287);
            btn00.Name = "btn00";
            btn00.Size = new Size(117, 87);
            btn00.TabIndex = 12;
            btn00.Text = "00";
            btn00.UseVisualStyleBackColor = true;
            btn00.Click += btn00_Click;
            // 
            // btnMinus
            // 
            btnMinus.Dock = DockStyle.Fill;
            btnMinus.Font = new Font("Segoe UI Variable Display", 19.8000011F);
            btnMinus.Location = new Point(377, 194);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(117, 87);
            btnMinus.TabIndex = 11;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.Font = new Font("Segoe UI Variable Display", 19.8000011F);
            btn3.Location = new Point(254, 194);
            btn3.Name = "btn3";
            btn3.Size = new Size(117, 87);
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.Font = new Font("Segoe UI Variable Display", 19.8000011F);
            btn2.Location = new Point(131, 194);
            btn2.Name = "btn2";
            btn2.Size = new Size(117, 87);
            btn2.TabIndex = 9;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.Font = new Font("Segoe UI Variable Display", 19.8000011F);
            btn1.Location = new Point(8, 194);
            btn1.Name = "btn1";
            btn1.Size = new Size(117, 87);
            btn1.TabIndex = 8;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Dock = DockStyle.Fill;
            btnMultiply.Font = new Font("Segoe UI Variable Display", 19.8000011F);
            btnMultiply.Location = new Point(377, 101);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(117, 87);
            btnMultiply.TabIndex = 7;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.Font = new Font("Segoe UI Variable Display", 19.8000011F);
            btn6.Location = new Point(254, 101);
            btn6.Name = "btn6";
            btn6.Size = new Size(117, 87);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.Font = new Font("Segoe UI Variable Display", 19.8000011F);
            btn5.Location = new Point(131, 101);
            btn5.Name = "btn5";
            btn5.Size = new Size(117, 87);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.Font = new Font("Segoe UI Variable Display", 19.8000011F);
            btn4.Location = new Point(8, 101);
            btn4.Name = "btn4";
            btn4.Size = new Size(117, 87);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btnDivide
            // 
            btnDivide.Dock = DockStyle.Fill;
            btnDivide.Font = new Font("Segoe UI Variable Display", 19.8000011F);
            btnDivide.Location = new Point(377, 8);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(117, 87);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.Font = new Font("Segoe UI Variable Display", 19.8000011F);
            btn9.Location = new Point(254, 8);
            btn9.Name = "btn9";
            btn9.Size = new Size(117, 87);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.Font = new Font("Segoe UI Variable Display", 19.8000011F);
            btn8.Location = new Point(131, 8);
            btn8.Name = "btn8";
            btn8.Size = new Size(117, 87);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.Font = new Font("Segoe UI Variable Display", 19.8000011F);
            btn7.Location = new Point(8, 8);
            btn7.Name = "btn7";
            btn7.Size = new Size(117, 87);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 603);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(textBoxPanel);
            MinimumSize = new Size(450, 450);
            Name = "Form1";
            Text = "Calculator";
            textBoxPanel.ResumeLayout(false);
            textBoxPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel textBoxPanel;
        private TextBox txtDisplay;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn7;
        private Button btnResult;
        private Button btnDelete;
        private Button btnPlus;
        private Button btnDot;
        private Button btn0;
        private Button btn00;
        private Button btnMinus;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnMultiply;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnDivide;
        private Button btn9;
        private Button btn8;
        private Button btnClear;
    }
}
