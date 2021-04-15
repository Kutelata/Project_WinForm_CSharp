using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafe
{
    public partial class myValidate : UserControl
    {
        public string myTextBox { get; set; }
        public string FieldName { get; set; }
        public string Pattern { get; set; }
        public myValidate()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            label1.Text = "";
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                label1.Text = $"Trường {FieldName} không được bỏ trống!";
            }
            if (String.IsNullOrEmpty(Pattern))
            {
                if (Regex.IsMatch(textBox1.Text,Pattern))
                {
                    e.Cancel = true;
                    label1.Text = $"Trường {FieldName} không hợp lệ!";
                    return;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            myTextBox = textBox1.Text;
        }
    }
}
