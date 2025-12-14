using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace chatBot
{
    public partial class BurbujaDerecha : UserControl
    {
        #region ************************        ATRIBUTOS       *************************

        private DateTime? _dsFechaHora;
        #endregion ************************        ATRIBUTOS       *************************

        #region ************************        CONSTRUCTORES       *************************
        public BurbujaDerecha()
        {
            InitializeComponent();
        }
        #endregion ************************        CONSTRUCTORES       *************************
        #region ***********************     PROPIEDADES     *******************************
        //paPerfil vsible
        [Category("Chat")]
        [Description("Muestra u oculta la imagen de perfil del mensaje")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public bool DSPerfilVisible
        {
            get
            {
                return paPerfil != null && paPerfil.Visible;
            }
            set
            {
                if (paPerfil == null) return;

                paPerfil.Visible = value;

                //// Recalcular layout solo si el control ya está creado
                //if (!IsHandleCreated || IsDisposed) return;

                //RecalcularLayout();
            }
        }

        [Category("Chat")]
        [Description("Texto del mensaje del chat")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public string DSBody
        {
            get { return richTextBox1.Text; }
            set
            {
                richTextBox1.Text = value ?? string.Empty;
                //paRichText.Padding = new Padding(6);
                richTextBox1.BackColor = paBurbuja.BackColor;
                if (string.IsNullOrEmpty(value)) return;

                Action ajustar = () =>
                {
                    AjustarAltoSegunTexto();
                    AjustarAnchoSegunTexto();
                    AjustarAltoSegunTexto();
                };

                // Si el handle aún no existe (Designer / constructor), NO uses BeginInvoke.
                if (!this.IsHandleCreated)
                {
                    // Lo pateamos para cuando ya exista ventana
                    this.HandleCreated -= BurbujaUser_HandleCreated_Ajuste;
                    this.HandleCreated += BurbujaUser_HandleCreated_Ajuste;
                    return;
                }

                // Si ya hay handle, lo ejecutas en UI thread (BeginInvoke está ok aquí)
                if (this.InvokeRequired)
                    this.BeginInvoke(ajustar);
                else
                    ajustar();
            }
        }
        private void BurbujaUser_HandleCreated_Ajuste(object sender, EventArgs e)
        {
            // evitar que se dispare muchas veces
            this.HandleCreated -= BurbujaUser_HandleCreated_Ajuste;

            if (this.IsDisposed) return;

            AjustarAltoSegunTexto();
            AjustarAnchoSegunTexto();
            AjustarAltoSegunTexto();
        }
        [Category("Chat")]
        [Description("Imagen de perfil del mensaje")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public Image DSImageProfile
        {
            get { return pictureBox1.Image; }
            set
            {
                if (pictureBox1 == null) return;

                pictureBox1.Image = value;
                pictureBox1.Refresh();
            }
        }
        [Category("Chat")]
        [Description("Fecha/hora del mensaje. Si es hoy, muestra solo hora (12h am/pm). Si no, muestra fecha + hora.")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public DateTime? DSFechaHora
        {
            get { return _dsFechaHora; }
            set
            {
                _dsFechaHora = value;
                ActualizarTextoHora();
            }
        }

        [Category("Chat")]
        [Description("Color de fondo de la burbuja del mensaje")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public Color DSBackColorBurbuja
        {
            get {return paBurbuja.BackColor;}
            set
            {
                if (paBurbuja == null) return;

                paBurbuja.BackColor = value;

                // Si el RichTextBox debe verse integrado a la burbuja
                if (richTextBox1 != null)
                    richTextBox1.BackColor = value;

                paBurbuja.Invalidate(); // repinta
            }
        }
        #endregion ***********************     PROPIEDADES     *******************************

        #region ************************        METODOS       *************************
        private void AjustarAltoSegunTexto()
        {
            // Asegura que el RichTextBox no meta scroll
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.WordWrap = true;

            // Importante: usar el ancho REAL del área cliente
            int width = richTextBox1.ClientSize.Width;
            if (width <= 1) width = richTextBox1.Width; // fallback

            int paddingVertical = 12;

            var flags = TextFormatFlags.TextBoxControl | TextFormatFlags.WordBreak;
            Size proposed = new Size(width, int.MaxValue);

            // Mide el alto que necesita el texto con wrap
            Size measured = TextRenderer.MeasureText(richTextBox1.Text, richTextBox1.Font, proposed, flags);
            int needed = measured.Height;




            // Si el texto termina con \n, a veces necesita una línea extra
            if (richTextBox1.Text.EndsWith("\n") || richTextBox1.Text.EndsWith("\r\n"))
                needed += richTextBox1.Font.Height;

            paRichText.Height = needed + paddingVertical;// Math.Max(minH, needed) + paddingVertical;
            paContenedor.Height = needed + paddingVertical + paHora.Height;
            this.Height = needed + paddingVertical + paHora.Height;

        }
        private void AjustarAnchoSegunTexto()
        {
            int paddingHorizontal = 12;
            var flagsAncho = TextFormatFlags.NoPadding | TextFormatFlags.SingleLine;
            Size sizeAncho = TextRenderer.MeasureText(richTextBox1.Text, richTextBox1.Font, new Size(int.MaxValue, richTextBox1.Font.Height), flagsAncho);
            int AnchoReaPanelDerecho = sizeAncho.Width < laHora.Width ? laHora.Width : sizeAncho.Width;

            //paContenedor.Width = paPerfil.Width + AnchoReaPanelDerecho + paddingHorizontal;
            int AnchoEstimado = (paPerfil.Visible?paPerfil.Width:0 )+ AnchoReaPanelDerecho + paddingHorizontal;

            int widthPaControlMax = this.Width - 50;
            paContenedor.Width = AnchoEstimado > widthPaControlMax ? widthPaControlMax : AnchoEstimado;

        }
        #endregion ************************        METODOS       *************************
        #region ************************        OTROS METODOS       *************************
        private void ActualizarTextoHora()
        {
            if (laHora == null) return;              // evita problemas en Designer
            if (!_dsFechaHora.HasValue)
            {
                laHora.Text = "hoy";
                return;
            }

            DateTime dt = _dsFechaHora.Value;
            bool esHoy = dt.Date == DateTime.Now.Date;

            laHora.Text = esHoy
                ? dt.ToString("hh:mm tt")             // 12 horas: 03:25 PM
                : dt.ToString("dd/MM/yyyy hh:mm tt"); // 13/12/2025 03:25 PM
        }
        private void Redondear(Control c, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radio * 2;

            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(c.Width - d, 0, d, d, 270, 90);
            path.AddArc(c.Width - d, c.Height - d, d, d, 0, 90);
            path.AddArc(0, c.Height - d, d, d, 90, 90);
            path.CloseFigure();

            c.Region = new Region(path);
        }
        #endregion ************************        OTROS METODOS       *************************
        #region ************************        EVENTOS       *************************
        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }        
        #endregion ************************        EVENTOS       *************************


        private void paRichText_SizeChanged(object sender, EventArgs e)
        {
            Redondear(paBurbuja, 10);

        }

    }
}
