namespace Ariketa8
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
            Hasi_DeskargakButton = new Button();
            barra1 = new ProgressBar();
            barra2 = new ProgressBar();
            etiketa1 = new Label();
            etiketa2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Hasi_DeskargakButton
            // 
            Hasi_DeskargakButton.Location = new Point(53, 64);
            Hasi_DeskargakButton.Margin = new Padding(3, 4, 3, 4);
            Hasi_DeskargakButton.Name = "Hasi_DeskargakButton";
            Hasi_DeskargakButton.Size = new Size(123, 31);
            Hasi_DeskargakButton.TabIndex = 0;
            Hasi_DeskargakButton.Text = "Hasi deskargak";
            Hasi_DeskargakButton.UseVisualStyleBackColor = true;
            Hasi_DeskargakButton.Click += Hasi_DeskargaButton;
            // 
            // barra1
            // 
            barra1.Location = new Point(53, 171);
            barra1.Margin = new Padding(3, 4, 3, 4);
            barra1.Name = "barra1";
            barra1.Size = new Size(409, 80);
            barra1.TabIndex = 1;
            // 
            // barra2
            // 
            barra2.Location = new Point(53, 361);
            barra2.Margin = new Padding(3, 4, 3, 4);
            barra2.Name = "barra2";
            barra2.Size = new Size(409, 80);
            barra2.TabIndex = 2;
            // 
            // etiketa1
            // 
            etiketa1.AutoSize = true;
            etiketa1.Location = new Point(217, 255);
            etiketa1.Name = "etiketa1";
            etiketa1.Size = new Size(74, 20);
            etiketa1.TabIndex = 3;
            etiketa1.Text = "Fitxategia";
            // 
            // etiketa2
            // 
            etiketa2.AutoSize = true;
            etiketa2.Location = new Point(217, 445);
            etiketa2.Name = "etiketa2";
            etiketa2.Size = new Size(74, 20);
            etiketa2.TabIndex = 4;
            etiketa2.Text = "Fitxategia";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(561, 171);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 270);
            textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(textBox1);
            Controls.Add(etiketa2);
            Controls.Add(etiketa1);
            Controls.Add(barra2);
            Controls.Add(barra1);
            Controls.Add(Hasi_DeskargakButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Hasi_DeskargakButton;
        private ProgressBar barra1;
        private ProgressBar barra2;
        private Label etiketa1;
        private Label etiketa2;
        private TextBox textBox1;
    }
}
