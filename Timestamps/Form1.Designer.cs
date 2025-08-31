namespace Timestamps
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label8 = new System.Windows.Forms.Label();
            this.minuteDebut = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.heureDebut = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.secondesDebut = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ader = new System.Windows.Forms.TextBox();
            this.SilverWeek = new System.Windows.Forms.RadioButton();
            this.bronzeWeek = new System.Windows.Forms.RadioButton();
            this.radioButtonArray1 = new Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(this.components);
            this.goldWeek = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.minuteDebut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heureDebut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondesDebut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonArray1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(17, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1234567890";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(249, 49);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "minutes";
            // 
            // minuteDebut
            // 
            this.minuteDebut.AutoSize = true;
            this.minuteDebut.Location = new System.Drawing.Point(325, 224);
            this.minuteDebut.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteDebut.Name = "minuteDebut";
            this.minuteDebut.Size = new System.Drawing.Size(35, 20);
            this.minuteDebut.TabIndex = 23;
            this.minuteDebut.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "heure";
            // 
            // heureDebut
            // 
            this.heureDebut.Location = new System.Drawing.Point(249, 223);
            this.heureDebut.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.heureDebut.Name = "heureDebut";
            this.heureDebut.Size = new System.Drawing.Size(35, 20);
            this.heureDebut.TabIndex = 21;
            this.heureDebut.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "=>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "<=";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(350, 23);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 17);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "UTC";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 30);
            this.label2.TabIndex = 30;
            this.label2.Text = "Unix Timestamp Converter";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(443, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "D";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(404, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 23);
            this.button4.TabIndex = 32;
            this.button4.Text = "T";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 226);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "n° semaine / week #";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // secondesDebut
            // 
            this.secondesDebut.AutoSize = true;
            this.secondesDebut.Location = new System.Drawing.Point(410, 224);
            this.secondesDebut.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondesDebut.Name = "secondesDebut";
            this.secondesDebut.Size = new System.Drawing.Size(35, 20);
            this.secondesDebut.TabIndex = 34;
            this.secondesDebut.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "secondes";
            // 
            // ader
            // 
            this.ader.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ader.Location = new System.Drawing.Point(130, 224);
            this.ader.Name = "ader";
            this.ader.Size = new System.Drawing.Size(36, 25);
            this.ader.TabIndex = 36;
            this.ader.Text = "w52";
            // 
            // SilverWeek
            // 
            this.SilverWeek.AutoSize = true;
            this.SilverWeek.Enabled = false;
            this.SilverWeek.Location = new System.Drawing.Point(26, 164);
            this.SilverWeek.Name = "SilverWeek";
            this.SilverWeek.Size = new System.Drawing.Size(104, 17);
            this.SilverWeek.TabIndex = 37;
            this.SilverWeek.TabStop = true;
            this.SilverWeek.Text = "starts january 1st";
            this.SilverWeek.UseVisualStyleBackColor = true;
            // 
            // bronzeWeek
            // 
            this.bronzeWeek.AutoSize = true;
            this.bronzeWeek.Enabled = false;
            this.bronzeWeek.Location = new System.Drawing.Point(26, 187);
            this.bronzeWeek.Name = "bronzeWeek";
            this.bronzeWeek.Size = new System.Drawing.Size(75, 17);
            this.bronzeWeek.TabIndex = 38;
            this.bronzeWeek.TabStop = true;
            this.bronzeWeek.Text = "first 4 days";
            this.bronzeWeek.UseVisualStyleBackColor = true;
            // 
            // goldWeek
            // 
            this.goldWeek.AutoSize = true;
            this.goldWeek.Enabled = false;
            this.goldWeek.Location = new System.Drawing.Point(26, 210);
            this.goldWeek.Name = "goldWeek";
            this.goldWeek.Size = new System.Drawing.Size(86, 17);
            this.goldWeek.TabIndex = 39;
            this.goldWeek.TabStop = true;
            this.goldWeek.Text = "first full week";
            this.goldWeek.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 261);
            this.Controls.Add(this.goldWeek);
            this.Controls.Add(this.bronzeWeek);
            this.Controls.Add(this.SilverWeek);
            this.Controls.Add(this.ader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondesDebut);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.minuteDebut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.heureDebut);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minuteDebut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heureDebut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondesDebut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonArray1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown minuteDebut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown heureDebut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown secondesDebut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ader;
        private System.Windows.Forms.RadioButton SilverWeek;
        private System.Windows.Forms.RadioButton bronzeWeek;
        private Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray radioButtonArray1;
        private System.Windows.Forms.RadioButton goldWeek;
    }
}

