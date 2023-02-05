using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textmanip
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }

        private void hideAllPanels()
        {
            chareveryxcharpanel.Hide();
            removepanel.Hide();
            replacepanel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                hideAllPanels();
                removepanel.Show();
        }

        private void letterEveryX_CheckedChanged(object sender, EventArgs e)
        {
            if (letterEveryX.Checked)
                hideAllPanels();
                chareveryxcharpanel.Show();
        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (radioButton2.Checked)
                    hideAllPanels();
                    replacepanel.Show();
            }
        }

        //
        //ADD EVERY X THING
        //
        private void button3_Click(object sender, EventArgs e)
        {
            string initialText = textBox1.Text;
            string spacerText = textBox3.Text;
            int jumpTrack = 0;
            bool successfullyParsed = int.TryParse(textBox2.Text, out jumpTrack);
            if (!successfullyParsed)
            {
                label2.Show();
                return;
            }

            if (initialText.Length == 0)
            {
                label2.Show();
                return;
            }
            else
            {
                label2.Hide();
                string processedText = string.Empty;
                int trackerText = 0;
                for(int i = 0; i < initialText.Length; i++)
                {
                    processedText += initialText[i];
                    trackerText++;
                    if(trackerText == jumpTrack)
                    {
                        processedText += spacerText;
                        trackerText = 0;
                    }
                }
                richTextBox1.Text = processedText;
            }
        }
        //
        //END ADD EVERY X THING
        //


        //
        //REMOVE START
        //
        private void button3_Click_1(object sender, EventArgs e)
        {
            string initialText = inputRP.Text;
            string removerText = removeRP.Text;
            Console.WriteLine(removerText);

            if (initialText.Length == 0)
            {
                //error
                return;
            }
            else
            {
                string processedText = string.Empty;    //creating processedtext empy string
                for (int i = 0; i < initialText.Length; i++)//for loop scanning each letter
                {
                    char c = initialText[i];    //getting letter
                    string letterBeingUsed = c.ToString(); //for some reason i have to do this very unpractical black magic
                    if (!letterBeingUsed.Contains(removerText)) //if the letter doesn't match with the remover text, then add letter
                    {
                        processedText += initialText[i];
                    }
                }
                outRP.Text = processedText;
            }

        }

        //
        //END REMOVE
        //

        //
        //REPLACE START
        //

        private void convBtn_Click(object sender, EventArgs e)
        {
            string initialText = input.Text; //initial text
            string replaceThis = repInput.Text; //replace this
            string replaceWith = replacerInput.Text; //with that


            if (initialText.Length == 0)
            {
                //error
                return;
            }
            else
            {
                convertedOut.Text = initialText.Replace(replaceThis, replaceWith);
            }
        }

    }
}
