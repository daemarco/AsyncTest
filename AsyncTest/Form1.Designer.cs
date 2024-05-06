namespace AsyncTest
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
            txtFilter = new TextBox();
            btnSearch = new Button();
            lstResult = new ListBox();
            txtMessage = new TextBox();
            lblMessage = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(7, 5);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(397, 23);
            txtFilter.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(410, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(97, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lstResult
            // 
            lstResult.FormattingEnabled = true;
            lstResult.ItemHeight = 15;
            lstResult.Location = new Point(7, 34);
            lstResult.Name = "lstResult";
            lstResult.Size = new Size(397, 274);
            lstResult.TabIndex = 2;
            // 
            // txtMessage
            // 
            txtMessage.BackColor = Color.SeaShell;
            txtMessage.Location = new Point(7, 347);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.ReadOnly = true;
            txtMessage.Size = new Size(397, 91);
            txtMessage.TabIndex = 3;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(7, 329);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(53, 15);
            lblMessage.TabIndex = 4;
            lblMessage.Text = "Message";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(410, 34);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 450);
            Controls.Add(btnClear);
            Controls.Add(lblMessage);
            Controls.Add(txtMessage);
            Controls.Add(lstResult);
            Controls.Add(btnSearch);
            Controls.Add(txtFilter);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilter;
        private Button btnSearch;
        private ListBox lstResult;
        private TextBox txtMessage;
        private Label lblMessage;
        private Button btnClear;
    }
}
