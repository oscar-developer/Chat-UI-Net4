namespace chatBot
{
    partial class BurbujaDerecha
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BurbujaDerecha));
            this.paContenedor = new System.Windows.Forms.Panel();
            this.paBurbuja = new System.Windows.Forms.Panel();
            this.paRichText = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.paHora = new System.Windows.Forms.Panel();
            this.laHora = new System.Windows.Forms.Label();
            this.paPerfil = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paContenedor.SuspendLayout();
            this.paBurbuja.SuspendLayout();
            this.paRichText.SuspendLayout();
            this.paHora.SuspendLayout();
            this.paPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // paContenedor
            // 
            this.paContenedor.Controls.Add(this.paBurbuja);
            this.paContenedor.Controls.Add(this.paPerfil);
            this.paContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.paContenedor.Location = new System.Drawing.Point(0, 0);
            this.paContenedor.Name = "paContenedor";
            this.paContenedor.Size = new System.Drawing.Size(209, 91);
            this.paContenedor.TabIndex = 4;
            // 
            // paBurbuja
            // 
            this.paBurbuja.Controls.Add(this.paRichText);
            this.paBurbuja.Controls.Add(this.paHora);
            this.paBurbuja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paBurbuja.Location = new System.Drawing.Point(30, 0);
            this.paBurbuja.Name = "paBurbuja";
            this.paBurbuja.Size = new System.Drawing.Size(179, 91);
            this.paBurbuja.TabIndex = 3;
            // 
            // paRichText
            // 
            this.paRichText.Controls.Add(this.richTextBox1);
            this.paRichText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paRichText.Location = new System.Drawing.Point(0, 0);
            this.paRichText.Name = "paRichText";
            this.paRichText.Padding = new System.Windows.Forms.Padding(6);
            this.paRichText.Size = new System.Drawing.Size(179, 77);
            this.paRichText.TabIndex = 2;
            this.paRichText.SizeChanged += new System.EventHandler(this.paRichText_SizeChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(167, 65);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "¡Hola! Soy un bot aquí para ayudarte. ¿En qué puedo asistirte hoy? ";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // paHora
            // 
            this.paHora.BackColor = System.Drawing.Color.Transparent;
            this.paHora.Controls.Add(this.laHora);
            this.paHora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paHora.Location = new System.Drawing.Point(0, 77);
            this.paHora.Name = "paHora";
            this.paHora.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.paHora.Size = new System.Drawing.Size(179, 14);
            this.paHora.TabIndex = 1;
            // 
            // laHora
            // 
            this.laHora.AutoSize = true;
            this.laHora.Dock = System.Windows.Forms.DockStyle.Right;
            this.laHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.laHora.Location = new System.Drawing.Point(136, 1);
            this.laHora.Name = "laHora";
            this.laHora.Size = new System.Drawing.Size(43, 12);
            this.laHora.TabIndex = 0;
            this.laHora.Text = "06:40 am";
            this.laHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paPerfil
            // 
            this.paPerfil.BackColor = System.Drawing.Color.Transparent;
            this.paPerfil.Controls.Add(this.pictureBox1);
            this.paPerfil.Dock = System.Windows.Forms.DockStyle.Left;
            this.paPerfil.Location = new System.Drawing.Point(0, 0);
            this.paPerfil.Name = "paPerfil";
            this.paPerfil.Size = new System.Drawing.Size(30, 91);
            this.paPerfil.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // BurbujaDerecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paContenedor);
            this.Name = "BurbujaDerecha";
            this.Size = new System.Drawing.Size(292, 91);
            this.paContenedor.ResumeLayout(false);
            this.paBurbuja.ResumeLayout(false);
            this.paRichText.ResumeLayout(false);
            this.paHora.ResumeLayout(false);
            this.paHora.PerformLayout();
            this.paPerfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paContenedor;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel paHora;
        private System.Windows.Forms.Label laHora;
        private System.Windows.Forms.Panel paPerfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel paRichText;
        private System.Windows.Forms.Panel paBurbuja;

    }
}
