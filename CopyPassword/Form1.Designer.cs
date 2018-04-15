namespace CopyPassword
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.account_lb = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.id_lb = new System.Windows.Forms.ListBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // account_lb
            // 
            this.account_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.account_lb.FormattingEnabled = true;
            this.account_lb.ItemHeight = 12;
            this.account_lb.Location = new System.Drawing.Point(0, 0);
            this.account_lb.Name = "account_lb";
            this.account_lb.Size = new System.Drawing.Size(146, 216);
            this.account_lb.TabIndex = 0;
            this.account_lb.SelectedIndexChanged += new System.EventHandler(this.account_lb_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.account_lb);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 216);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.id_lb);
            this.panel2.Location = new System.Drawing.Point(164, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 216);
            this.panel2.TabIndex = 2;
            // 
            // id_lb
            // 
            this.id_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.id_lb.FormattingEnabled = true;
            this.id_lb.ItemHeight = 12;
            this.id_lb.Location = new System.Drawing.Point(0, 0);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(146, 216);
            this.id_lb.TabIndex = 0;
            this.id_lb.SelectedIndexChanged += new System.EventHandler(this.id_lb_SelectedIndexChanged);
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(82, 12);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(228, 19);
            this.password_tb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(244, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ctrl + Shift ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 277);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "CopyPassword";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox account_lb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox id_lb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

