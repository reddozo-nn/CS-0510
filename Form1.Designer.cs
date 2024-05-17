namespace CS_0510
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
            mybutton = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // mybutton
            // 
            mybutton.BackColor = Color.FromArgb(0, 192, 0);
            mybutton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mybutton.Location = new Point(434, 52);
            mybutton.Name = "mybutton";
            mybutton.Size = new Size(193, 174);
            mybutton.TabIndex = 0;
            mybutton.Text = "押すなよ??";
            mybutton.UseVisualStyleBackColor = false;
            mybutton.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(133, 254);
            button2.Name = "button2";
            button2.Size = new Size(244, 165);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(mybutton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button mybutton;
        private Button button2;
    }
}