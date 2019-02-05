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
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (name_tb.Text.Trim() == "")
            {
                return;
            }

            if (id_tb.Text.Trim() == "")
            {
                return;
            }

            if (pass_tb.Text.Trim() == "")
            {
                return;
            }

            string FileName = Properties.Settings.Default.backupFileName;
            string accountData =  name_tb.Text + "\t" + id_tb.Text + "\t" + pass_tb.Text + "\t" + detailbTb.Text + "\t" + mailTb.Text + Environment.NewLine;
            File.AppendAllText(FileName, accountData);

            this.Close();
            this.Dispose();
        }
    }
}
