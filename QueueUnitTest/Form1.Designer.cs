namespace QueueUnitTest
{
    partial class QueueUnitTest
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
            this.EnqueueBttn = new System.Windows.Forms.Button();
            this.DisplayText = new System.Windows.Forms.TextBox();
            this.DequeueBttn = new System.Windows.Forms.Button();
            this.ClearBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnqueueBttn
            // 
            this.EnqueueBttn.Location = new System.Drawing.Point(12, 238);
            this.EnqueueBttn.Name = "EnqueueBttn";
            this.EnqueueBttn.Size = new System.Drawing.Size(75, 23);
            this.EnqueueBttn.TabIndex = 0;
            this.EnqueueBttn.Text = "Enqueue";
            this.EnqueueBttn.UseVisualStyleBackColor = true;
            this.EnqueueBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisplayText
            // 
            this.DisplayText.Location = new System.Drawing.Point(12, 13);
            this.DisplayText.Multiline = true;
            this.DisplayText.Name = "DisplayText";
            this.DisplayText.Size = new System.Drawing.Size(268, 219);
            this.DisplayText.TabIndex = 1;
            // 
            // DequeueBttn
            // 
            this.DequeueBttn.Location = new System.Drawing.Point(93, 237);
            this.DequeueBttn.Name = "DequeueBttn";
            this.DequeueBttn.Size = new System.Drawing.Size(75, 23);
            this.DequeueBttn.TabIndex = 2;
            this.DequeueBttn.Text = "Dequeue";
            this.DequeueBttn.UseVisualStyleBackColor = true;
            this.DequeueBttn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ClearBttn
            // 
            this.ClearBttn.Location = new System.Drawing.Point(174, 237);
            this.ClearBttn.Name = "ClearBttn";
            this.ClearBttn.Size = new System.Drawing.Size(75, 23);
            this.ClearBttn.TabIndex = 3;
            this.ClearBttn.Text = "Clear";
            this.ClearBttn.UseVisualStyleBackColor = true;
            this.ClearBttn.Click += new System.EventHandler(this.ClearBttn_Click);
            // 
            // QueueUnitTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.ClearBttn);
            this.Controls.Add(this.DequeueBttn);
            this.Controls.Add(this.DisplayText);
            this.Controls.Add(this.EnqueueBttn);
            this.Name = "QueueUnitTest";
            this.Text = "Queue Unit Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnqueueBttn;
        private System.Windows.Forms.TextBox DisplayText;
        private System.Windows.Forms.Button DequeueBttn;
        private System.Windows.Forms.Button ClearBttn;
    }
}

