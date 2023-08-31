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

namespace MyMM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "텍스트 파일 (*.txt)|*.txt";
            openFileDialog1.ShowDialog(this);

            textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
        }

        private void 저장_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt";
            saveFileDialog1.ShowDialog(this);
            File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 마이메모장정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("제작자: 조예서\n제작일: 2023.08.31목",
            "마이메모장 정보", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
    }
}
