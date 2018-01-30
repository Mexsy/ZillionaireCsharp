namespace Zillionaire
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
            this.components = new System.ComponentModel.Container();
            this.option1 = new System.Windows.Forms.TextBox();
            this.option2 = new System.Windows.Forms.TextBox();
            this.option3 = new System.Windows.Forms.TextBox();
            this.option4 = new System.Windows.Forms.TextBox();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Chance = new System.Windows.Forms.Button();
            this.audience_button = new System.Windows.Forms.Button();
            this.call_button = new System.Windows.Forms.Button();
            this.fifty_fifty_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.listBoxScore = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // option1
            // 
            this.option1.Enabled = false;
            this.option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.option1.Location = new System.Drawing.Point(120, 305);
            this.option1.Name = "option1";
            this.option1.ReadOnly = true;
            this.option1.Size = new System.Drawing.Size(332, 20);
            this.option1.TabIndex = 0;
            this.option1.TextChanged += new System.EventHandler(this.option1_TextChanged);
            // 
            // option2
            // 
            this.option2.Enabled = false;
            this.option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.option2.Location = new System.Drawing.Point(120, 367);
            this.option2.Name = "option2";
            this.option2.ReadOnly = true;
            this.option2.Size = new System.Drawing.Size(332, 20);
            this.option2.TabIndex = 1;
            // 
            // option3
            // 
            this.option3.Enabled = false;
            this.option3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.option3.Location = new System.Drawing.Point(564, 302);
            this.option3.Name = "option3";
            this.option3.ReadOnly = true;
            this.option3.Size = new System.Drawing.Size(332, 20);
            this.option3.TabIndex = 5;
            // 
            // option4
            // 
            this.option4.Enabled = false;
            this.option4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.option4.Location = new System.Drawing.Point(564, 364);
            this.option4.Name = "option4";
            this.option4.ReadOnly = true;
            this.option4.Size = new System.Drawing.Size(332, 20);
            this.option4.TabIndex = 6;
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(55, 302);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(40, 23);
            this.buttonA.TabIndex = 7;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(494, 365);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(40, 23);
            this.buttonD.TabIndex = 8;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.ButtonD_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(494, 303);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(40, 23);
            this.buttonC.TabIndex = 9;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(55, 364);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(40, 23);
            this.buttonB.TabIndex = 10;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Score:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Chance);
            this.panel1.Controls.Add(this.audience_button);
            this.panel1.Controls.Add(this.call_button);
            this.panel1.Controls.Add(this.fifty_fifty_button);
            this.panel1.Location = new System.Drawing.Point(766, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 146);
            this.panel1.TabIndex = 13;
            // 
            // Chance
            // 
            this.Chance.Location = new System.Drawing.Point(16, 93);
            this.Chance.Name = "Chance";
            this.Chance.Size = new System.Drawing.Size(122, 23);
            this.Chance.TabIndex = 3;
            this.Chance.Text = "Chance";
            this.Chance.UseVisualStyleBackColor = true;
            this.Chance.Click += new System.EventHandler(this.Chance_Click);
            // 
            // audience_button
            // 
            this.audience_button.Location = new System.Drawing.Point(16, 64);
            this.audience_button.Name = "audience_button";
            this.audience_button.Size = new System.Drawing.Size(122, 23);
            this.audience_button.TabIndex = 2;
            this.audience_button.Text = "Ask Audience";
            this.audience_button.UseVisualStyleBackColor = true;
            this.audience_button.Click += new System.EventHandler(this.audience_button_Click);
            // 
            // call_button
            // 
            this.call_button.Location = new System.Drawing.Point(17, 35);
            this.call_button.Name = "call_button";
            this.call_button.Size = new System.Drawing.Size(122, 23);
            this.call_button.TabIndex = 1;
            this.call_button.Text = "Call a friend";
            this.call_button.UseVisualStyleBackColor = true;
            this.call_button.Click += new System.EventHandler(this.call_button_Click);
            // 
            // fifty_fifty_button
            // 
            this.fifty_fifty_button.Location = new System.Drawing.Point(17, 8);
            this.fifty_fifty_button.Name = "fifty_fifty_button";
            this.fifty_fifty_button.Size = new System.Drawing.Size(122, 23);
            this.fifty_fifty_button.TabIndex = 0;
            this.fifty_fifty_button.Text = "50/50";
            this.fifty_fifty_button.UseVisualStyleBackColor = true;
            this.fifty_fifty_button.Click += new System.EventHandler(this.fifty_fifty_button_click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // questionTextBox
            // 
            this.questionTextBox.Enabled = false;
            this.questionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.questionTextBox.Location = new System.Drawing.Point(55, 241);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.Size = new System.Drawing.Size(841, 20);
            this.questionTextBox.TabIndex = 16;
            this.questionTextBox.TextChanged += new System.EventHandler(this.questionTextBox_TextChanged);
            // 
            // listBoxScore
            // 
            this.listBoxScore.Enabled = false;
            this.listBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxScore.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listBoxScore.FormattingEnabled = true;
            this.listBoxScore.Location = new System.Drawing.Point(55, 20);
            this.listBoxScore.Name = "listBoxScore";
            this.listBoxScore.Size = new System.Drawing.Size(158, 173);
            this.listBoxScore.TabIndex = 17;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(343, 20);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(240, 23);
            this.progressBar1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(934, 419);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listBoxScore);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.option4);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox option1;
        private System.Windows.Forms.TextBox option2;
        private System.Windows.Forms.TextBox option3;
        private System.Windows.Forms.TextBox option4;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button audience_button;
        private System.Windows.Forms.Button call_button;
        private System.Windows.Forms.Button fifty_fifty_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.ListBox listBoxScore;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Chance;
    }
}

