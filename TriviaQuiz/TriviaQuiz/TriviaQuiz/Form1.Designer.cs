namespace TriviaQuiz
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnA = new System.Windows.Forms.Button();
            this.bttnD = new System.Windows.Forms.Button();
            this.bttnC = new System.Windows.Forms.Button();
            this.bttnB = new System.Windows.Forms.Button();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.remain_time = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 99);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Olive;
            this.label5.Font = new System.Drawing.Font("Goudy Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(423, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(520, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "TRIVIA QUIZ CHALLANGE";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.bttnA);
            this.groupBox1.Controls.Add(this.bttnD);
            this.groupBox1.Controls.Add(this.bttnC);
            this.groupBox1.Controls.Add(this.bttnB);
            this.groupBox1.Controls.Add(this.txtQuestion);
            this.groupBox1.Location = new System.Drawing.Point(12, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1259, 320);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // bttnA
            // 
            this.bttnA.BackColor = System.Drawing.Color.Olive;
            this.bttnA.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.bttnA.FlatAppearance.BorderSize = 2;
            this.bttnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnA.Location = new System.Drawing.Point(25, 165);
            this.bttnA.Name = "bttnA";
            this.bttnA.Size = new System.Drawing.Size(455, 45);
            this.bttnA.TabIndex = 5;
            this.bttnA.Text = "button5";
            this.bttnA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnA.UseVisualStyleBackColor = false;
            this.bttnA.Click += new System.EventHandler(this.button_Click);
            // 
            // bttnD
            // 
            this.bttnD.BackColor = System.Drawing.Color.Olive;
            this.bttnD.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.bttnD.FlatAppearance.BorderSize = 2;
            this.bttnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnD.Location = new System.Drawing.Point(784, 243);
            this.bttnD.Name = "bttnD";
            this.bttnD.Size = new System.Drawing.Size(455, 45);
            this.bttnD.TabIndex = 4;
            this.bttnD.Text = "button4";
            this.bttnD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnD.UseVisualStyleBackColor = false;
            this.bttnD.Click += new System.EventHandler(this.button_Click);
            // 
            // bttnC
            // 
            this.bttnC.BackColor = System.Drawing.Color.Olive;
            this.bttnC.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.bttnC.FlatAppearance.BorderSize = 2;
            this.bttnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnC.Location = new System.Drawing.Point(25, 243);
            this.bttnC.Name = "bttnC";
            this.bttnC.Size = new System.Drawing.Size(455, 45);
            this.bttnC.TabIndex = 3;
            this.bttnC.Text = "button3";
            this.bttnC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnC.UseVisualStyleBackColor = false;
            this.bttnC.Click += new System.EventHandler(this.button_Click);
            // 
            // bttnB
            // 
            this.bttnB.BackColor = System.Drawing.Color.Olive;
            this.bttnB.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.bttnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnB.Location = new System.Drawing.Point(784, 165);
            this.bttnB.Name = "bttnB";
            this.bttnB.Size = new System.Drawing.Size(455, 45);
            this.bttnB.TabIndex = 2;
            this.bttnB.Text = "button2";
            this.bttnB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnB.UseVisualStyleBackColor = false;
            this.bttnB.Click += new System.EventHandler(this.button_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtQuestion.Enabled = false;
            this.txtQuestion.Location = new System.Drawing.Point(25, 39);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(1214, 77);
            this.txtQuestion.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Olive;
            this.panel2.Controls.Add(this.remain_time);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 501);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1283, 106);
            this.panel2.TabIndex = 1;
            // 
            // remain_time
            // 
            this.remain_time.AutoSize = true;
            this.remain_time.BackColor = System.Drawing.Color.Olive;
            this.remain_time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remain_time.Location = new System.Drawing.Point(37, 37);
            this.remain_time.Name = "remain_time";
            this.remain_time.Size = new System.Drawing.Size(80, 32);
            this.remain_time.TabIndex = 4;
            this.remain_time.Text = "label6";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(123, 32);
            this.progressBar1.Maximum = 20;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1128, 37);
            this.progressBar1.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1283, 637);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Goudy Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "TRIVIA QUIZ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox txtQuestion;
        private Button bttnD;
        private Button bttnC;
        private Button bttnB;
        private Button bttnA;
        private Label label5;
        private Label label2;
        private Label label4;
        private Panel panel2;
        private Label remain_time;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer;
    }
}