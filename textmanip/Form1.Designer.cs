namespace textmanip
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Close = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Bg = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.letterEveryX = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.chareveryxcharpanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.convertbtn = new System.Windows.Forms.Button();
            this.removepanel = new System.Windows.Forms.Panel();
            this.remlabel = new System.Windows.Forms.Label();
            this.removeRP = new System.Windows.Forms.TextBox();
            this.inplabel = new System.Windows.Forms.Label();
            this.convlabel = new System.Windows.Forms.Label();
            this.outRP = new System.Windows.Forms.RichTextBox();
            this.inputRP = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Bg)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.chareveryxcharpanel.SuspendLayout();
            this.removepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Close.Cursor = System.Windows.Forms.Cursors.Default;
            this.Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(840, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(54, 37);
            this.Close.TabIndex = 0;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // Min
            // 
            this.Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Min.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.Min.FlatAppearance.BorderSize = 0;
            this.Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Min.Image = ((System.Drawing.Image)(resources.GetObject("Min.Image")));
            this.Min.Location = new System.Drawing.Point(787, 0);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(54, 37);
            this.Min.TabIndex = 1;
            this.Min.UseVisualStyleBackColor = false;
            this.Min.Click += new System.EventHandler(this.button2_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Title.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Brown;
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(167, 25);
            this.Title.TabIndex = 2;
            this.Title.Text = "Text Manipulator";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // Bg
            // 
            this.Bg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.Bg.Location = new System.Drawing.Point(-15, 37);
            this.Bg.Name = "Bg";
            this.Bg.Size = new System.Drawing.Size(920, 456);
            this.Bg.TabIndex = 3;
            this.Bg.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.letterEveryX);
            this.flowLayoutPanel1.Controls.Add(this.radioButton1);
            this.flowLayoutPanel1.Controls.Add(this.radioButton2);
            this.flowLayoutPanel1.Controls.Add(this.radioButton3);
            this.flowLayoutPanel1.Controls.Add(this.radioButton4);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(217, 422);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // letterEveryX
            // 
            this.letterEveryX.Appearance = System.Windows.Forms.Appearance.Button;
            this.letterEveryX.AutoSize = true;
            this.letterEveryX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.letterEveryX.Checked = true;
            this.letterEveryX.FlatAppearance.BorderSize = 0;
            this.letterEveryX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterEveryX.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterEveryX.Location = new System.Drawing.Point(3, 3);
            this.letterEveryX.MaximumSize = new System.Drawing.Size(210, 65);
            this.letterEveryX.MinimumSize = new System.Drawing.Size(210, 65);
            this.letterEveryX.Name = "letterEveryX";
            this.letterEveryX.Size = new System.Drawing.Size(210, 65);
            this.letterEveryX.TabIndex = 0;
            this.letterEveryX.TabStop = true;
            this.letterEveryX.Text = "Characters Every X Characters";
            this.letterEveryX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.letterEveryX.UseVisualStyleBackColor = false;
            this.letterEveryX.CheckedChanged += new System.EventHandler(this.letterEveryX_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.radioButton1.FlatAppearance.BorderSize = 0;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(3, 74);
            this.radioButton1.MaximumSize = new System.Drawing.Size(210, 65);
            this.radioButton1.MinimumSize = new System.Drawing.Size(210, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(210, 65);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Remove Characters/String";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.radioButton2.FlatAppearance.BorderSize = 0;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(3, 145);
            this.radioButton2.MaximumSize = new System.Drawing.Size(210, 65);
            this.radioButton2.MinimumSize = new System.Drawing.Size(210, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(210, 65);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Replace";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.radioButton3.FlatAppearance.BorderSize = 0;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(3, 216);
            this.radioButton3.MaximumSize = new System.Drawing.Size(210, 65);
            this.radioButton3.MinimumSize = new System.Drawing.Size(210, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(210, 65);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "Find";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            this.radioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.radioButton4.FlatAppearance.BorderSize = 0;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(3, 287);
            this.radioButton4.MaximumSize = new System.Drawing.Size(210, 65);
            this.radioButton4.MinimumSize = new System.Drawing.Size(210, 65);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(210, 65);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.Text = "Translate";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // chareveryxcharpanel
            // 
            this.chareveryxcharpanel.Controls.Add(this.label6);
            this.chareveryxcharpanel.Controls.Add(this.textBox3);
            this.chareveryxcharpanel.Controls.Add(this.label5);
            this.chareveryxcharpanel.Controls.Add(this.textBox2);
            this.chareveryxcharpanel.Controls.Add(this.label3);
            this.chareveryxcharpanel.Controls.Add(this.label4);
            this.chareveryxcharpanel.Controls.Add(this.label2);
            this.chareveryxcharpanel.Controls.Add(this.richTextBox1);
            this.chareveryxcharpanel.Controls.Add(this.textBox1);
            this.chareveryxcharpanel.Controls.Add(this.convertbtn);
            this.chareveryxcharpanel.Location = new System.Drawing.Point(236, 49);
            this.chareveryxcharpanel.Name = "chareveryxcharpanel";
            this.chareveryxcharpanel.Size = new System.Drawing.Size(645, 422);
            this.chareveryxcharpanel.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(153, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Insert :";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(156, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(470, 13);
            this.textBox3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Insert every :";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(15, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 13);
            this.textBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Input :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(12, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Converted :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(288, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "error";
            this.label2.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(15, 255);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(611, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(15, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(611, 13);
            this.textBox1.TabIndex = 1;
            // 
            // convertbtn
            // 
            this.convertbtn.Location = new System.Drawing.Point(551, 374);
            this.convertbtn.Name = "convertbtn";
            this.convertbtn.Size = new System.Drawing.Size(75, 23);
            this.convertbtn.TabIndex = 0;
            this.convertbtn.Text = "convert";
            this.convertbtn.UseVisualStyleBackColor = true;
            this.convertbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // removepanel
            // 
            this.removepanel.Controls.Add(this.remlabel);
            this.removepanel.Controls.Add(this.removeRP);
            this.removepanel.Controls.Add(this.inplabel);
            this.removepanel.Controls.Add(this.convlabel);
            this.removepanel.Controls.Add(this.outRP);
            this.removepanel.Controls.Add(this.inputRP);
            this.removepanel.Controls.Add(this.button3);
            this.removepanel.Location = new System.Drawing.Point(236, 49);
            this.removepanel.Name = "removepanel";
            this.removepanel.Size = new System.Drawing.Size(645, 422);
            this.removepanel.TabIndex = 11;
            // 
            // remlabel
            // 
            this.remlabel.AutoSize = true;
            this.remlabel.Font = new System.Drawing.Font("Bahnschrift", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.remlabel.Location = new System.Drawing.Point(12, 70);
            this.remlabel.Name = "remlabel";
            this.remlabel.Size = new System.Drawing.Size(52, 13);
            this.remlabel.TabIndex = 10;
            this.remlabel.Text = "Remove :";
            // 
            // removeRP
            // 
            this.removeRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.removeRP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.removeRP.Location = new System.Drawing.Point(15, 86);
            this.removeRP.Name = "removeRP";
            this.removeRP.Size = new System.Drawing.Size(301, 13);
            this.removeRP.TabIndex = 9;
            // 
            // inplabel
            // 
            this.inplabel.AutoSize = true;
            this.inplabel.Font = new System.Drawing.Font("Bahnschrift", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inplabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.inplabel.Location = new System.Drawing.Point(12, 32);
            this.inplabel.Name = "inplabel";
            this.inplabel.Size = new System.Drawing.Size(37, 13);
            this.inplabel.TabIndex = 6;
            this.inplabel.Text = "Input :";
            // 
            // convlabel
            // 
            this.convlabel.AutoSize = true;
            this.convlabel.Font = new System.Drawing.Font("Bahnschrift", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.convlabel.Location = new System.Drawing.Point(12, 239);
            this.convlabel.Name = "convlabel";
            this.convlabel.Size = new System.Drawing.Size(64, 13);
            this.convlabel.TabIndex = 5;
            this.convlabel.Text = "Converted :";
            // 
            // outRP
            // 
            this.outRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.outRP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outRP.Location = new System.Drawing.Point(15, 255);
            this.outRP.Name = "outRP";
            this.outRP.Size = new System.Drawing.Size(611, 96);
            this.outRP.TabIndex = 2;
            this.outRP.Text = "";
            // 
            // inputRP
            // 
            this.inputRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.inputRP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputRP.Location = new System.Drawing.Point(15, 48);
            this.inputRP.Name = "inputRP";
            this.inputRP.Size = new System.Drawing.Size(611, 13);
            this.inputRP.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(551, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "convert";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(893, 483);
            this.Controls.Add(this.removepanel);
            this.Controls.Add(this.chareveryxcharpanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Text manipulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bg)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.chareveryxcharpanel.ResumeLayout(false);
            this.chareveryxcharpanel.PerformLayout();
            this.removepanel.ResumeLayout(false);
            this.removepanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox Bg;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton letterEveryX;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel chareveryxcharpanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button convertbtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel removepanel;
        private System.Windows.Forms.Label remlabel;
        private System.Windows.Forms.TextBox removeRP;
        private System.Windows.Forms.Label inplabel;
        private System.Windows.Forms.Label convlabel;
        private System.Windows.Forms.RichTextBox outRP;
        private System.Windows.Forms.TextBox inputRP;
        private System.Windows.Forms.Button button3;
    }
}

