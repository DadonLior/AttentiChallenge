namespace AttentiHomeCallengeUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.solveBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.numberOfIslandsLabel = new System.Windows.Forms.Label();
            this.invalidMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter bitmap size:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Bitmap size: n,m";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(169, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Randomize";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(169, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Draw";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // solveBtn
            // 
            this.solveBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.solveBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.solveBtn.Location = new System.Drawing.Point(169, 582);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(133, 47);
            this.solveBtn.TabIndex = 4;
            this.solveBtn.Text = "Solve";
            this.solveBtn.UseVisualStyleBackColor = false;
            this.solveBtn.Visible = false;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click_1);
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.restartBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.restartBtn.Location = new System.Drawing.Point(169, 582);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(133, 47);
            this.restartBtn.TabIndex = 5;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = false;
            this.restartBtn.Visible = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click_1);
            // 
            // numberOfIslandsLabel
            // 
            this.numberOfIslandsLabel.AutoSize = true;
            this.numberOfIslandsLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfIslandsLabel.Location = new System.Drawing.Point(124, 549);
            this.numberOfIslandsLabel.Name = "numberOfIslandsLabel";
            this.numberOfIslandsLabel.Size = new System.Drawing.Size(0, 27);
            this.numberOfIslandsLabel.TabIndex = 6;
            this.numberOfIslandsLabel.Visible = false;
            // 
            // invalidMessage
            // 
            this.invalidMessage.AutoSize = true;
            this.invalidMessage.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidMessage.ForeColor = System.Drawing.Color.Red;
            this.invalidMessage.Location = new System.Drawing.Point(114, 238);
            this.invalidMessage.Name = "invalidMessage";
            this.invalidMessage.Size = new System.Drawing.Size(246, 18);
            this.invalidMessage.TabIndex = 7;
            this.invalidMessage.Text = "Invalid input, please try again";
            this.invalidMessage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(478, 744);
            this.Controls.Add(this.invalidMessage);
            this.Controls.Add(this.numberOfIslandsLabel);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.solveBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Attenti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.textBox1_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button solveBtn;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Label numberOfIslandsLabel;
        private System.Windows.Forms.Label invalidMessage;
    }
}

