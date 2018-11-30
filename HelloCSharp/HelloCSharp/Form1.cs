using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace HelloCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fontsize;
            fontsize = "<font color=#ff0000 size=5 face=\"黑体\">" + richTextBox1.SelectedText + "</font>";
            //richTextBox1.AppendText("你已经被选中");
            richTextBox1.Text = "";
            richTextBox1.AppendText(fontsize);
           // MessageBox.Show("你已经被选中");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "3":
                    setFormat("<font size=3 >", "</font>");
                    break;
                case "4":
                    setFormat("<font size=4 >", "</font>");
                    break;
                case "5":
                    setFormat("<font size=5 >", "</font>");
                    break;
                default:
                    break;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string boldstr = "**";
            string tempstr;
            tempstr = richTextBox1.SelectedText;
            richTextBox1.SelectionColor = Color.FromName("red");
            richTextBox1.SelectedText = boldstr;
            richTextBox1.SelectionColor = Color.FromName("yellow");
            richTextBox1.SelectedText = tempstr;
            richTextBox1.SelectionColor = Color.FromName("red");
            richTextBox1.SelectedText = boldstr;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string highstr = "==";
            string tempstr ;
            tempstr = richTextBox1.SelectedText;
            richTextBox1.SelectionColor = Color.FromName("red");
            richTextBox1.SelectedText = highstr;
            richTextBox1.SelectionColor = Color.FromName("yellow");
            //richTextBox1.SelectionColor = Color.FromArgb(222,33,44);
            richTextBox1.SelectedText = tempstr;
            richTextBox1.SelectionColor = Color.FromName("red");
            richTextBox1.SelectedText = highstr;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int firstCharPosition = richTextBox1.GetFirstCharIndexOfCurrentLine();
            int lineNumber = richTextBox1.GetLineFromCharIndex(firstCharPosition);
            int lastCharPosition = richTextBox1.GetFirstCharIndexFromLine(lineNumber + 1);

            richTextBox1.Select(firstCharPosition, lastCharPosition - firstCharPosition);
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.SelectedText = "//" + richTextBox1.SelectedText.ToString();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {         
            switch (comboBox2.Text)
            {
                case "红":
                    setFormat("<font color=#ff0000 >**", "**</font>");
                    break;
                case "橙":
                    setFormat("<font color=#ffa500 >**", "**</font>");
                    break;
                case "黄":
                    setFormat("<font color=#ffff00 >**", "**</font>");
                    break;
                case "绿":
                    setFormat("<font color=#00ff00 >**", "**</font>");
                    break;
                case "蓝":
                    setFormat("<font color=#0000ff >**", "**</font>");
                    break;
                case "靛":
                    setFormat("<font color=#ff0000 >**", "**</font>");
                    break;
                case "紫":
                    setFormat("<font color=#800080 >**", "**</font>");
                    break;
                default:
                    break;
            }
        }
        private void setFormat(string str1, string str2) {
            string tmp = richTextBox1.SelectedText;
            richTextBox1.SelectionColor = Color.FromName("red");
            richTextBox1.SelectedText = str1;
            richTextBox1.SelectionColor = Color.FromName("yellow");
            richTextBox1.SelectedText = tmp;
            richTextBox1.SelectionColor = Color.FromName("red");
            richTextBox1.SelectedText = str2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tmp = richTextBox2.SelectedText;
            //tmp.Replace("*", "");
            tmp =tmp.Replace("*", string.Empty);
            //tmp.Trim('*');
            richTextBox2.SelectedText = tmp;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string tmp = richTextBox2.SelectedText;
            //tmp.Replace("*", "");
           // tmp = tmp.Replace(" ", "|");
            string pattern = @"[\f\t\r\v]";
            tmp = Regex.Replace(tmp, pattern, "|");
            //tmp.Trim('*');
            richTextBox2.SelectedText = tmp;
        }
    }
}
