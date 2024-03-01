namespace TriviaQuiz
{
    partial class results
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.number_of_wrong_answers = new System.Windows.Forms.Label();
            this.number_of_correct_answers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.number_of_wrong_answers);
            this.panel1.Controls.Add(this.number_of_correct_answers);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 153);
            this.panel1.TabIndex = 0;
            // 
            // number_of_wrong_answers
            // 
            this.number_of_wrong_answers.AutoSize = true;
            this.number_of_wrong_answers.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number_of_wrong_answers.Location = new System.Drawing.Point(631, 96);
            this.number_of_wrong_answers.Name = "number_of_wrong_answers";
            this.number_of_wrong_answers.Size = new System.Drawing.Size(87, 34);
            this.number_of_wrong_answers.TabIndex = 3;
            this.number_of_wrong_answers.Text = "label4";
            // 
            // number_of_correct_answers
            // 
            this.number_of_correct_answers.AutoSize = true;
            this.number_of_correct_answers.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number_of_correct_answers.Location = new System.Drawing.Point(631, 22);
            this.number_of_correct_answers.Name = "number_of_correct_answers";
            this.number_of_correct_answers.Size = new System.Drawing.Size(87, 34);
            this.number_of_correct_answers.TabIndex = 2;
            this.number_of_correct_answers.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(105, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUMBER OF WRONG ANSWERS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(82, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMBER OF CORRECT ANSWERS:";
            // 
            // bttn_close
            // 
            this.bttn_close.BackColor = System.Drawing.Color.Wheat;
            this.bttn_close.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttn_close.Location = new System.Drawing.Point(390, 354);
            this.bttn_close.Name = "bttn_close";
            this.bttn_close.Size = new System.Drawing.Size(334, 62);
            this.bttn_close.TabIndex = 1;
            this.bttn_close.Text = "CLOSE";
            this.bttn_close.UseVisualStyleBackColor = false;
            this.bttn_close.Click += new System.EventHandler(this.bttn_close_Click);
            // 
            // results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1073, 497);
            this.ControlBox = false;
            this.Controls.Add(this.bttn_close);
            this.Controls.Add(this.panel1);
            this.Name = "results";
            this.Text = "RESULTS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label number_of_wrong_answers;
        private Label number_of_correct_answers;
        private Label label2;
        private Label label1;
        private Button bttn_close;
    }
}