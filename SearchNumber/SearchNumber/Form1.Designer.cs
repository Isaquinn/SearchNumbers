namespace SearchNumber
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
            this.GerarNumeros = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SearchLinear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchBinary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GerarNumeros
            // 
            this.GerarNumeros.Location = new System.Drawing.Point(12, 12);
            this.GerarNumeros.Name = "GerarNumeros";
            this.GerarNumeros.Size = new System.Drawing.Size(121, 40);
            this.GerarNumeros.TabIndex = 0;
            this.GerarNumeros.Text = "Gerar 1000 Numeros Ordenados";
            this.GerarNumeros.UseVisualStyleBackColor = true;
            this.GerarNumeros.Click += new System.EventHandler(this.GerarNumeros_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 173);
            this.listBox1.TabIndex = 1;
            // 
            // SearchLinear
            // 
            this.SearchLinear.Location = new System.Drawing.Point(151, 12);
            this.SearchLinear.Name = "SearchLinear";
            this.SearchLinear.Size = new System.Drawing.Size(121, 41);
            this.SearchLinear.TabIndex = 2;
            this.SearchLinear.Text = "Encontar Número De Forma Linear";
            this.SearchLinear.UseVisualStyleBackColor = true;
            this.SearchLinear.Click += new System.EventHandler(this.SearchLinear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // SearchBinary
            // 
            this.SearchBinary.Location = new System.Drawing.Point(151, 85);
            this.SearchBinary.Name = "SearchBinary";
            this.SearchBinary.Size = new System.Drawing.Size(121, 41);
            this.SearchBinary.TabIndex = 4;
            this.SearchBinary.Text = "Encontar Número De Forma Binária";
            this.SearchBinary.UseVisualStyleBackColor = true;
            this.SearchBinary.Click += new System.EventHandler(this.SearchBinary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SearchBinary);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SearchLinear);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.GerarNumeros);
            this.Name = "Form1";
            this.Text = "Busca Linear e Binária";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GerarNumeros;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button SearchLinear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchBinary;
    }
}

