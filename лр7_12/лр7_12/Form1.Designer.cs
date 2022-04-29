namespace лр7_12
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
            this.исходник = new System.Windows.Forms.ListBox();
            this.сумма = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // исходник
            // 
            this.исходник.FormattingEnabled = true;
            this.исходник.ItemHeight = 20;
            this.исходник.Location = new System.Drawing.Point(0, 0);
            this.исходник.Name = "исходник";
            this.исходник.Size = new System.Drawing.Size(172, 384);
            this.исходник.TabIndex = 0;
            // 
            // сумма
            // 
            this.сумма.FormattingEnabled = true;
            this.сумма.ItemHeight = 20;
            this.сумма.Location = new System.Drawing.Point(228, 20);
            this.сумма.Name = "сумма";
            this.сумма.Size = new System.Drawing.Size(418, 364);
            this.сумма.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "массив";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "сумма положительных";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.сумма);
            this.Controls.Add(this.исходник);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox исходник;
        private ListBox сумма;
        private Button button1;
        private Button button2;
    }
}