namespace chatBot
{
    partial class FormChatbot
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.tbMensaje = new System.Windows.Forms.RichTextBox();
            this.xscChat = new DevExpress.XtraEditors.XtraScrollableControl();
            this.flpMessages = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.laTitulo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.xscChat.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Controls.Add(this.tbMensaje);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 74);
            this.panel1.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(284, 15);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(66, 37);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // tbMensaje
            // 
            this.tbMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMensaje.BackColor = System.Drawing.Color.White;
            this.tbMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.tbMensaje.Location = new System.Drawing.Point(12, 15);
            this.tbMensaje.Name = "tbMensaje";
            this.tbMensaje.Size = new System.Drawing.Size(259, 37);
            this.tbMensaje.TabIndex = 0;
            this.tbMensaje.Text = "";
            this.tbMensaje.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMensaje_KeyDown);
            // 
            // xscChat
            // 
            this.xscChat.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.xscChat.Appearance.Options.UseBackColor = true;
            this.xscChat.Controls.Add(this.flpMessages);
            this.xscChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xscChat.Location = new System.Drawing.Point(0, 57);
            this.xscChat.Name = "xscChat";
            this.xscChat.Size = new System.Drawing.Size(375, 443);
            this.xscChat.TabIndex = 1;
            // 
            // flpMessages
            // 
            this.flpMessages.AutoSize = true;
            this.flpMessages.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMessages.Location = new System.Drawing.Point(1, 0);
            this.flpMessages.Name = "flpMessages";
            this.flpMessages.Size = new System.Drawing.Size(372, 209);
            this.flpMessages.TabIndex = 0;
            this.flpMessages.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.panel2.Controls.Add(this.laTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 57);
            this.panel2.TabIndex = 2;
            // 
            // laTitulo
            // 
            this.laTitulo.AutoSize = true;
            this.laTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitulo.ForeColor = System.Drawing.Color.White;
            this.laTitulo.Location = new System.Drawing.Point(30, 22);
            this.laTitulo.Name = "laTitulo";
            this.laTitulo.Size = new System.Drawing.Size(243, 16);
            this.laTitulo.TabIndex = 0;
            this.laTitulo.Text = "Chat Bot (discpouesto a ayudarte)";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FormChatbot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 574);
            this.Controls.Add(this.xscChat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChatbot";
            this.ShowIcon = false;
            this.Text = "ChatBot";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.xscChat.ResumeLayout(false);
            this.xscChat.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.XtraScrollableControl xscChat;
        private System.Windows.Forms.FlowLayoutPanel flpMessages;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.RichTextBox tbMensaje;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label laTitulo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

