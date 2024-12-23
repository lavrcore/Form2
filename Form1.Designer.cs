namespace Form2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            trackBar1 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(-2, 12);
            button1.Name = "button1";
            button1.Size = new Size(174, 121);
            button1.TabIndex = 0;
            button1.Text = "ФИО";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Chocolate;
            button2.Image = Properties.Resources.loupe;
            button2.Location = new Point(22, 185);
            button2.Name = "button2";
            button2.Size = new Size(161, 105);
            button2.TabIndex = 1;
            button2.Text = "Время";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuHighlight;
            button3.ForeColor = Color.HotPink;
            button3.Location = new Point(447, 88);
            button3.Name = "button3";
            button3.Size = new Size(221, 280);
            button3.TabIndex = 2;
            button3.Text = "Всё";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.CadetBlue;
            button4.Location = new Point(221, 40);
            button4.Name = "button4";
            button4.Size = new Size(180, 105);
            button4.TabIndex = 3;
            button4.Text = "Дата рождения";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "Шакиров Карим Фанилевич";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(221, 139);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(180, 23);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.свинка_пепа;
            pictureBox1.Location = new Point(423, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(11, 10);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(341, 298);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 7;
            progressBar1.Click += progressBar1_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(365, 383);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(157, 45);
            trackBar1.TabIndex = 8;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.patek_phikipe;
            ClientSize = new Size(803, 440);
            Controls.Add(trackBar1);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.InactiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private TrackBar trackBar1;
    }
}