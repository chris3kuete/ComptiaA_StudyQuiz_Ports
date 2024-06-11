namespace my_Quiz
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
            this.QuestionsRtb = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.answer1rbt = new System.Windows.Forms.RadioButton();
            this.nextbtn = new System.Windows.Forms.Button();
            this.answer2rbt = new System.Windows.Forms.RadioButton();
            this.answer3rbt = new System.Windows.Forms.RadioButton();
            this.answer4rbt = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionsRtb
            // 
            this.QuestionsRtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionsRtb.Location = new System.Drawing.Point(12, 12);
            this.QuestionsRtb.Name = "QuestionsRtb";
            this.QuestionsRtb.Size = new System.Drawing.Size(805, 170);
            this.QuestionsRtb.TabIndex = 0;
            this.QuestionsRtb.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(12, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 10);
            this.panel1.TabIndex = 1;
            // 
            // answer1rbt
            // 
            this.answer1rbt.AutoSize = true;
            this.answer1rbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer1rbt.Location = new System.Drawing.Point(12, 276);
            this.answer1rbt.Name = "answer1rbt";
            this.answer1rbt.Size = new System.Drawing.Size(198, 36);
            this.answer1rbt.TabIndex = 0;
            this.answer1rbt.Text = "radioButton1";
            this.answer1rbt.UseVisualStyleBackColor = true;
            this.answer1rbt.Click += new System.EventHandler(this.answer1rbt_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.BackColor = System.Drawing.Color.Gold;
            this.nextbtn.FlatAppearance.BorderSize = 0;
            this.nextbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbtn.ForeColor = System.Drawing.Color.White;
            this.nextbtn.Location = new System.Drawing.Point(120, 566);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(564, 64);
            this.nextbtn.TabIndex = 2;
            this.nextbtn.Text = "Next";
            this.nextbtn.UseVisualStyleBackColor = false;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // answer2rbt
            // 
            this.answer2rbt.AutoSize = true;
            this.answer2rbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer2rbt.Location = new System.Drawing.Point(12, 344);
            this.answer2rbt.Name = "answer2rbt";
            this.answer2rbt.Size = new System.Drawing.Size(198, 36);
            this.answer2rbt.TabIndex = 3;
            this.answer2rbt.Text = "radioButton2";
            this.answer2rbt.UseVisualStyleBackColor = true;
            this.answer2rbt.Click += new System.EventHandler(this.answer2rbt_Click);
            // 
            // answer3rbt
            // 
            this.answer3rbt.AutoSize = true;
            this.answer3rbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer3rbt.Location = new System.Drawing.Point(12, 409);
            this.answer3rbt.Name = "answer3rbt";
            this.answer3rbt.Size = new System.Drawing.Size(198, 36);
            this.answer3rbt.TabIndex = 4;
            this.answer3rbt.Text = "radioButton3";
            this.answer3rbt.UseVisualStyleBackColor = true;
            this.answer3rbt.Click += new System.EventHandler(this.answer3rbt_Click);
            // 
            // answer4rbt
            // 
            this.answer4rbt.AutoSize = true;
            this.answer4rbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer4rbt.Location = new System.Drawing.Point(12, 481);
            this.answer4rbt.Name = "answer4rbt";
            this.answer4rbt.Size = new System.Drawing.Size(198, 36);
            this.answer4rbt.TabIndex = 5;
            this.answer4rbt.Text = "radioButton4";
            this.answer4rbt.UseVisualStyleBackColor = true;
            this.answer4rbt.Click += new System.EventHandler(this.answer4rbt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(638, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 62);
            this.button1.TabIndex = 6;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 657);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answer4rbt);
            this.Controls.Add(this.answer3rbt);
            this.Controls.Add(this.answer2rbt);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.answer1rbt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.QuestionsRtb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox QuestionsRtb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton answer1rbt;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.RadioButton answer2rbt;
        private System.Windows.Forms.RadioButton answer3rbt;
        private System.Windows.Forms.RadioButton answer4rbt;
        private System.Windows.Forms.Button button1;
    }
}

