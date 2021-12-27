
namespace Lab4
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
            this.btnGet = new System.Windows.Forms.Button();
            this.RichTxtInfo = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.queue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(238, 90);
            this.btnGet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(82, 112);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Взять";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // RichTxtInfo
            // 
            this.RichTxtInfo.Location = new System.Drawing.Point(25, 90);
            this.RichTxtInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RichTxtInfo.Multiline = true;
            this.RichTxtInfo.Name = "RichTxtInfo";
            this.RichTxtInfo.Size = new System.Drawing.Size(209, 81);
            this.RichTxtInfo.TabIndex = 2;
            // 
            // txtInfo
            // 
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Location = new System.Drawing.Point(58, 46);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(143, 24);
            this.txtInfo.TabIndex = 3;
            // 
            // queue
            // 
            this.queue.Location = new System.Drawing.Point(25, 175);
            this.queue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.queue.Multiline = true;
            this.queue.Name = "queue";
            this.queue.Size = new System.Drawing.Size(209, 27);
            this.queue.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Перезаполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 225);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.queue);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.RichTxtInfo);
            this.Controls.Add(this.btnGet);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox RichTxtInfo;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox queue;
        private System.Windows.Forms.Button button1;
    }
}

