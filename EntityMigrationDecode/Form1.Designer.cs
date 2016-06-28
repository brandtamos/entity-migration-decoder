namespace EntityMigrationDecode
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
            this.txtBase64String = new System.Windows.Forms.TextBox();
            this.txtXmlOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBase64String
            // 
            this.txtBase64String.Location = new System.Drawing.Point(11, 30);
            this.txtBase64String.MaxLength = 131072;
            this.txtBase64String.MinimumSize = new System.Drawing.Size(0, 100);
            this.txtBase64String.Name = "txtBase64String";
            this.txtBase64String.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBase64String.Size = new System.Drawing.Size(602, 100);
            this.txtBase64String.TabIndex = 0;
            // 
            // txtXmlOutput
            // 
            this.txtXmlOutput.Location = new System.Drawing.Point(11, 228);
            this.txtXmlOutput.MaxLength = 131072;
            this.txtXmlOutput.MinimumSize = new System.Drawing.Size(0, 200);
            this.txtXmlOutput.Name = "txtXmlOutput";
            this.txtXmlOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXmlOutput.Size = new System.Drawing.Size(602, 200);
            this.txtXmlOutput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Base64 Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "XML Output";
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(11, 137);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 4;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(538, 137);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 457);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtXmlOutput);
            this.Controls.Add(this.txtBase64String);
            this.Name = "Form1";
            this.Text = "Decode Entity Migration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBase64String;
        private System.Windows.Forms.TextBox txtXmlOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnClear;
    }
}

