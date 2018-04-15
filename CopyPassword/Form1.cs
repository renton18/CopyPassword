using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyPassword
{
    public partial class Form1 : Form
    {
        private List<string[]> accountList = new List<string[]>();
        private string backupFileName = Properties.Settings.Default.backupFileName;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setAccountLb();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //設定モード F1
            if (e.KeyCode == Keys.F1)
            {
                new AddAccount().ShowDialog();
                setAccountLb();
            }
            if (e.KeyCode == Keys.Right)
            {
                id_lb.Focus();
                e.Handled = true;

            }
            if (e.Shift && e.Control)
            {
                password_tb.PasswordChar = '\0';
            }
            if (e.KeyCode == Keys.Left)
            {
                account_lb.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                Clipboard.SetText(password_tb.Text);
                this.Close();
                this.Dispose();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = false;
            if (e.Shift || e.Control)
            {
                password_tb.PasswordChar = '*';
            }
        }

        private void account_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idList = accountList.Where(a => a[0] == account_lb.SelectedItem.ToString());

            id_lb.Items.Clear();
            foreach (var item in idList)
            {
                id_lb.Items.Add(item[1].ToString());
            }
            id_lb.SelectedIndex = 0;
        }

        private void id_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var passwordText = accountList.Where(a => a[0] == account_lb.SelectedItem.ToString())
                              .Where(a => a[1] == id_lb.SelectedItem.ToString()).Single();

            password_tb.Text = passwordText[2];
        }

        private void setAccountLb()
        {
            account_lb.Items.Clear();
            id_lb.Items.Clear();

            if (File.Exists(backupFileName) != true)
            {
                return;
            }

            accountList.Clear();
            foreach (string row in File.ReadLines(backupFileName))
            {
                var datas = row.Split(',');
                var item = new string[] { datas[0], datas[1], datas[2] };
                accountList.Add(item);

                if (account_lb.Items.Contains(datas[0]) == false)
                {
                    account_lb.Items.Add(datas[0]);
                }
            }

            account_lb.SelectedIndex = 0;
            id_lb.SelectedIndex = 0;
        }
    }
}
