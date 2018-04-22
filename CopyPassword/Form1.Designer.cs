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
            this.id_lb = new System.Windows.Forms.ListBox();
            this.Remark_tb = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // account_lb
            // 
            this.account_lb.BackColor = System.Drawing.Color.LightGreen;
            this.account_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.account_lb.FormattingEnabled = true;
            this.account_lb.ItemHeight = 12;
            this.account_lb.Location = new System.Drawing.Point(3, 3);
            this.account_lb.Name = "account_lb";
            this.account_lb.Size = new System.Drawing.Size(231, 134);
            this.account_lb.Sorted = true;
            this.account_lb.TabIndex = 0;
            this.account_lb.SelectedIndexChanged += new System.EventHandler(this.account_lb_SelectedIndexChanged);
            // 
            // id_lb
            // 
            this.id_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.id_lb.FormattingEnabled = true;
            this.id_lb.ItemHeight = 12;
            this.id_lb.Location = new System.Drawing.Point(240, 3);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(231, 134);
            this.id_lb.Sorted = true;
            this.id_lb.TabIndex = 0;
            this.id_lb.SelectedIndexChanged += new System.EventHandler(this.id_lb_SelectedIndexChanged);
            // 
            // Remark_tb
            // 
            this.Remark_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Remark_tb.Location = new System.Drawing.Point(477, 3);
            this.Remark_tb.Multiline = true;
            this.Remark_tb.Name = "Remark_tb";
            this.Remark_tb.Size = new System.Drawing.Size(234, 134);
            this.Remark_tb.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.account_lb, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Remark_tb, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.id_lb, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(714, 140);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(720, 196);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(70, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "F1:追加　Ctrl + Shift:パスワード表示 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "password";
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(72, 3);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(239, 19);
            this.password_tb.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.password_tb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 44);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 196);
            this.Controls.Add(this.tableLayoutPanel2);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "CopyPassword";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox account_lb;
        private System.Windows.Forms.ListBox id_lb;
        private System.Windows.Forms.TextBox Remark_tb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label label1;
    }
}

