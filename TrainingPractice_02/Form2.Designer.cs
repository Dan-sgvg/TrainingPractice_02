namespace TrainingPractice_02
{
    partial class Form2
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.first_button_tab_index = new System.Windows.Forms.Label();
            this.second_button_tab_index = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.place_in_list1 = new System.Windows.Forms.Label();
            this.place_in_list2 = new System.Windows.Forms.Label();
            this.wanted_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Время:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(182, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "с.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Ходы:";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Location = new System.Drawing.Point(98, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(78, 22);
            this.textBox1.TabIndex = 42;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Location = new System.Drawing.Point(98, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(78, 22);
            this.textBox2.TabIndex = 43;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "label1";
            // 
            // first_button_tab_index
            // 
            this.first_button_tab_index.AutoSize = true;
            this.first_button_tab_index.Location = new System.Drawing.Point(228, 0);
            this.first_button_tab_index.Name = "first_button_tab_index";
            this.first_button_tab_index.Size = new System.Drawing.Size(46, 17);
            this.first_button_tab_index.TabIndex = 45;
            this.first_button_tab_index.Text = "label5";
            // 
            // second_button_tab_index
            // 
            this.second_button_tab_index.AutoSize = true;
            this.second_button_tab_index.Location = new System.Drawing.Point(289, 0);
            this.second_button_tab_index.Name = "second_button_tab_index";
            this.second_button_tab_index.Size = new System.Drawing.Size(46, 17);
            this.second_button_tab_index.TabIndex = 47;
            this.second_button_tab_index.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // place_in_list1
            // 
            this.place_in_list1.AutoSize = true;
            this.place_in_list1.Location = new System.Drawing.Point(228, 29);
            this.place_in_list1.Name = "place_in_list1";
            this.place_in_list1.Size = new System.Drawing.Size(46, 17);
            this.place_in_list1.TabIndex = 49;
            this.place_in_list1.Text = "label6";
            // 
            // place_in_list2
            // 
            this.place_in_list2.AutoSize = true;
            this.place_in_list2.Location = new System.Drawing.Point(289, 29);
            this.place_in_list2.Name = "place_in_list2";
            this.place_in_list2.Size = new System.Drawing.Size(46, 17);
            this.place_in_list2.TabIndex = 50;
            this.place_in_list2.Text = "label6";
            // 
            // wanted_result
            // 
            this.wanted_result.AutoSize = true;
            this.wanted_result.Location = new System.Drawing.Point(256, 49);
            this.wanted_result.Name = "wanted_result";
            this.wanted_result.Size = new System.Drawing.Size(46, 17);
            this.wanted_result.TabIndex = 51;
            this.wanted_result.Text = "label6";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.wanted_result);
            this.Controls.Add(this.place_in_list2);
            this.Controls.Add(this.place_in_list1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.second_button_tab_index);
            this.Controls.Add(this.first_button_tab_index);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label first_button_tab_index;
        private System.Windows.Forms.Label second_button_tab_index;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label place_in_list1;
        private System.Windows.Forms.Label place_in_list2;
        private System.Windows.Forms.Label wanted_result;
    }
}