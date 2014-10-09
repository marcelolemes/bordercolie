namespace BorderColie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bordaTxt = new System.Windows.Forms.TextBox();
            this.fotoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Borda = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bordaTxt
            // 
            this.bordaTxt.AllowDrop = true;
            this.bordaTxt.Location = new System.Drawing.Point(12, 26);
            this.bordaTxt.Name = "bordaTxt";
            this.bordaTxt.Size = new System.Drawing.Size(257, 20);
            this.bordaTxt.TabIndex = 0;
            this.bordaTxt.Text = "N:/Bordas Jpg/borda.jpg";
            this.bordaTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.bordaTxt.DragDrop += new System.Windows.Forms.DragEventHandler(this.bordaTxt_DragDrop);
            this.bordaTxt.DragOver += new System.Windows.Forms.DragEventHandler(this.bordaTxt_DragOver);
            this.bordaTxt.DragLeave += new System.EventHandler(this.bordaTxt_DragLeave);
            // 
            // fotoTxt
            // 
            this.fotoTxt.AllowDrop = true;
            this.fotoTxt.Location = new System.Drawing.Point(12, 92);
            this.fotoTxt.Name = "fotoTxt";
            this.fotoTxt.Size = new System.Drawing.Size(236, 20);
            this.fotoTxt.TabIndex = 1;
            this.fotoTxt.TextChanged += new System.EventHandler(this.fotoTxt_TextChanged);
            this.fotoTxt.DragDrop += new System.Windows.Forms.DragEventHandler(this.fotoTxt_DragDrop);
            this.fotoTxt.DragEnter += new System.Windows.Forms.DragEventHandler(this.fotoTxt_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caminho Foto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Borda
            // 
            this.Borda.AutoSize = true;
            this.Borda.Location = new System.Drawing.Point(38, 10);
            this.Borda.Name = "Borda";
            this.Borda.Size = new System.Drawing.Size(79, 13);
            this.Borda.TabIndex = 3;
            this.Borda.Text = "Caminho Borda";
            this.Borda.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(290, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(51, 34);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(259, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Marca Dágua";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(270, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(71, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Tamanho";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 134);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.Borda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fotoTxt);
            this.Controls.Add(this.bordaTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BorderColie";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bordaTxt;
        private System.Windows.Forms.TextBox fotoTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Borda;
        private System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

