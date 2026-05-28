namespace AimPractice
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
        /// the contents of this method by the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1 (Dugme mete - zeleno)
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.button1.Location = new System.Drawing.Point(305, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Meta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1 (Tajmer za odbrojavanje vremena - svake sekunde)
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1 (Prikaz poena)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(83, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Poeni: 0";
            // 
            // label2 (Prikaz vremena)
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(280, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vreme: 30";
            // 
            // label3 (Prikaz preciznosti - procenat uspešnih pogodaka)
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(480, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preciznost: 100%";
            // 
            // button2 (Prepreka 1 - crveno dugme)
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.button2.Location = new System.Drawing.Point(75, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "D";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3 (Prepreka 2 - crveno dugme)
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.button3.Location = new System.Drawing.Point(222, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 5;
            this.button3.Text = "D";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4 (Prepreka 3 - crveno dugme)
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.button4.Location = new System.Drawing.Point(471, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 6;
            this.button4.Text = "D";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5 (Prepreka 4 - crveno dugme)
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.button5.Location = new System.Drawing.Point(543, 152);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 7;
            this.button5.Text = "D";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer2 (Tajmer za nasumično pomeranje prepreka - svakih ~2.35 sekundi)
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1 (Glavna forma igre)
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "AimPraktika - Igra za Treniranje Preciznosti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer2;
    }
}
