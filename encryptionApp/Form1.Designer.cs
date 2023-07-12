namespace encryptionApp
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
            cbxEncode = new ComboBox();
            tbxInput = new TextBox();
            tbxOutput = new TextBox();
            lblArrow = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // cbxEncode
            // 
            cbxEncode.FormattingEnabled = true;
            cbxEncode.Location = new Point(22, 132);
            cbxEncode.Margin = new Padding(6);
            cbxEncode.Name = "cbxEncode";
            cbxEncode.Size = new Size(221, 40);
            cbxEncode.TabIndex = 0;
            // 
            // tbxInput
            // 
            tbxInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxInput.Location = new Point(258, 26);
            tbxInput.Margin = new Padding(6);
            tbxInput.MaxLength = 512;
            tbxInput.Multiline = true;
            tbxInput.Name = "tbxInput";
            tbxInput.Size = new Size(514, 260);
            tbxInput.TabIndex = 1;
            tbxInput.Text = "Input encode";
            tbxInput.Click += tbxInput_Click;
            // 
            // tbxOutput
            // 
            tbxOutput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxOutput.Location = new Point(258, 369);
            tbxOutput.Margin = new Padding(6);
            tbxOutput.Multiline = true;
            tbxOutput.Name = "tbxOutput";
            tbxOutput.ReadOnly = true;
            tbxOutput.Size = new Size(514, 260);
            tbxOutput.TabIndex = 2;
            tbxOutput.Text = "Output encode";
            // 
            // lblArrow
            // 
            lblArrow.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblArrow.AutoSize = true;
            lblArrow.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblArrow.Location = new Point(446, 297);
            lblArrow.Margin = new Padding(6, 0, 6, 0);
            lblArrow.Name = "lblArrow";
            lblArrow.Size = new Size(49, 62);
            lblArrow.TabIndex = 3;
            lblArrow.Text = "↓";
            // 
            // btnRun
            // 
            btnRun.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRun.Location = new Point(22, 457);
            btnRun.Margin = new Padding(6);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(225, 79);
            btnRun.TabIndex = 4;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 671);
            Controls.Add(btnRun);
            Controls.Add(lblArrow);
            Controls.Add(tbxOutput);
            Controls.Add(tbxInput);
            Controls.Add(cbxEncode);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "OMAR ALFAROUK ALMOHAMAD - 200205910";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxEncode;
        private TextBox tbxInput;
        private TextBox tbxOutput;
        private Label lblArrow;
        private Button btnRun;
    }
}