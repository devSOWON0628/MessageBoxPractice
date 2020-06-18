using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("아 누르지 말라니까 왜 눌러요;;");
            MessageBox.Show("진짜 누르지 마라 복숭아 물 나온다ㅡㅡ","경고한다");
            DialogResult result;
            do
            {
                result = MessageBox.Show("진짜 진짜로 안누를거지", "경고한다", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);

            } while (result==DialogResult.Retry);




        }
    }
}
