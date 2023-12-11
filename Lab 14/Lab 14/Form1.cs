using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace YourNamespace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            displayRichTextBox1.Clear();
            richTextBox1.SelectionBullet = true;
            richTextBox1.BulletIndent = 50;
            richTextBox1.SelectionFont = new Font("Arial", 16);
            richTextBox1.SelectedText = "Below is a list\n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.SelectedText = "Apple\n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            richTextBox1.SelectionColor = Color.Orange;
            richTextBox1.SelectedText = "Orange\n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            richTextBox1.SelectionColor = Color.Purple;
            richTextBox1.SelectedText = "Grapes\n";
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionFont = new Font("Verdana", 10);
            richTextBox1.SelectedText = "The list is over\n";
        }

        private void buttonLink_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "My site http://moi.ru";
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void buttonUseFonts_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string sText1, sText2, sText3, sText4, sText5;
            for (int i = 1; i <= 5; i++)
            {
                richTextBox1.Text += "String" + i.ToString() + System.Environment.NewLine;
            }

            sText1 = "String1";
            sText2 = "String2";
            sText3 = "String3";
            sText4 = "String4";
            sText5 = "String5";

            richTextBox1.Select(richTextBox1.Find(sText1), sText1.Length);
            richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Regular);
            richTextBox1.SelectionColor = Color.Red;

            richTextBox1.Select(richTextBox1.Find(sText2), sText2.Length);
            richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Underline);
            richTextBox1.SelectionColor = Color.Blue;

            richTextBox1.Select(richTextBox1.Find(sText3), sText3.Length);
            richTextBox1.SelectionFont = new Font("Arial", 14, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Aqua;

            richTextBox1.Select(richTextBox1.Find(sText4), sText4.Length);
            richTextBox1.SelectionFont = new Font("Arial", 16, FontStyle.Bold | FontStyle.Italic);
            richTextBox1.SelectionColor = Color.Cyan;

            richTextBox1.Select(richTextBox1.Find(sText5), sText5.Length);
            richTextBox1.SelectionFont = new Font("Arial", 18, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout);
            richTextBox1.SelectionColor = Color.Brown;

            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = 0;
        }

        private void buttonSaveAndLoad_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile("a.rtf", RichTextBoxStreamType.RichText);
            richTextBox1.Clear();
            richTextBox1.LoadFile("a.rtf", RichTextBoxStreamType.RichText);
        }
    }
}
