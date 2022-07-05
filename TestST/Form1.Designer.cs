namespace TestST
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_date = new System.Windows.Forms.TabPage();
            this.tab_ora = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tab_univ = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.tab_csv = new System.Windows.Forms.TabPage();
            this.tab_image = new System.Windows.Forms.TabPage();
            this.tab_chart = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_ora.SuspendLayout();
            this.tab_univ.SuspendLayout();
            this.tab_csv.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_date);
            this.tabControl1.Controls.Add(this.tab_ora);
            this.tabControl1.Controls.Add(this.tab_univ);
            this.tabControl1.Controls.Add(this.tab_csv);
            this.tabControl1.Controls.Add(this.tab_image);
            this.tabControl1.Controls.Add(this.tab_chart);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_date
            // 
            this.tab_date.Location = new System.Drawing.Point(4, 24);
            this.tab_date.Name = "tab_date";
            this.tab_date.Padding = new System.Windows.Forms.Padding(3);
            this.tab_date.Size = new System.Drawing.Size(768, 398);
            this.tab_date.TabIndex = 0;
            this.tab_date.Text = "Date personale";
            this.tab_date.UseVisualStyleBackColor = true;
            // 
            // tab_ora
            // 
            this.tab_ora.Controls.Add(this.button2);
            this.tab_ora.Controls.Add(this.button1);
            this.tab_ora.Location = new System.Drawing.Point(4, 24);
            this.tab_ora.Name = "tab_ora";
            this.tab_ora.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ora.Size = new System.Drawing.Size(768, 398);
            this.tab_ora.TabIndex = 1;
            this.tab_ora.Text = "Schimbare format ora";
            this.tab_ora.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "FORMAT FARA AM/PM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "FORMAT AM/PM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tab_univ
            // 
            this.tab_univ.Controls.Add(this.button3);
            this.tab_univ.Location = new System.Drawing.Point(4, 24);
            this.tab_univ.Name = "tab_univ";
            this.tab_univ.Size = new System.Drawing.Size(768, 398);
            this.tab_univ.TabIndex = 2;
            this.tab_univ.Text = "Universitati";
            this.tab_univ.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Arata Universitati";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // tab_csv
            // 
            this.tab_csv.Controls.Add(this.button4);
            this.tab_csv.Location = new System.Drawing.Point(4, 24);
            this.tab_csv.Name = "tab_csv";
            this.tab_csv.Size = new System.Drawing.Size(768, 398);
            this.tab_csv.TabIndex = 3;
            this.tab_csv.Text = "csv";
            this.tab_csv.UseVisualStyleBackColor = true;
            // 
            // tab_image
            // 
            this.tab_image.Location = new System.Drawing.Point(4, 24);
            this.tab_image.Name = "tab_image";
            this.tab_image.Size = new System.Drawing.Size(768, 398);
            this.tab_image.TabIndex = 4;
            this.tab_image.Text = "Imagini";
            this.tab_image.UseVisualStyleBackColor = true;
            // 
            // tab_chart
            // 
            this.tab_chart.Location = new System.Drawing.Point(4, 24);
            this.tab_chart.Name = "tab_chart";
            this.tab_chart.Size = new System.Drawing.Size(768, 398);
            this.tab_chart.TabIndex = 5;
            this.tab_chart.Text = "Chart";
            this.tab_chart.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(318, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 77);
            this.button4.TabIndex = 0;
            this.button4.Text = "CSV";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_ora.ResumeLayout(false);
            this.tab_univ.ResumeLayout(false);
            this.tab_csv.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tab_date;
        private TabPage tab_ora;
        private TabPage tab_univ;
        private TabPage tab_csv;
        private TabPage tab_image;
        private TabPage tab_chart;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}