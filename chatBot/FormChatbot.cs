using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chatBot
{
    public partial class FormChatbot : Form
    {
        string aMsnInicialBot = @"¡Hola! Soy [Nombre del Bot], tu asistente aquí."+Environment.NewLine+
                            @"Estoy para ayudarte con [mencionar propósito principal: ej: responder preguntas, gestionar pedidos, brindar soporte, etc.]. "+
                            Environment.NewLine+ "¿En qué puedo asistirte hoy?";
        List<string> respuestasBot = new List<string>
        {
            "Claro 😊, dime en qué puedo ayudarte.",
            "¡Con gusto! ¿Qué necesitas saber?",
            "Estoy aquí para ayudarte, cuéntame.",
            "Perfecto, veamos eso juntos.",
            "Entendido 👍, dame un momento.",
            "Buena pregunta 🤔, déjame revisarlo.",
            "Vamos paso a paso para que quede claro.",
            "Te explico de forma sencilla.",
            "Déjame analizarlo un momento.",
            "Con gusto te ayudo con ese tema.",
            "¿Podrías darme un poco más de detalle?",
            "Interesante consulta, vamos a ello.",
            "Eso tiene solución, no te preocupes.",
            "Perfecto, ahora te explico.",
            "Vamos a revisarlo juntos.",
            "Estoy procesando la información…",
            "Un momento por favor ⏳.",
            "Gracias por la consulta.",
            "Claro, te explico a continuación.",
            "Eso es muy común, no te preocupes.",
            "Buena observación.",
            "Correcto, ese punto es importante.",
            "Te ayudo con gusto.",
            "Estoy aquí para apoyarte.",
            "Déjame darte una respuesta clara.",
            "Vamos con calma 🙂.",
            "Excelente pregunta.",
            "Entendido, sigamos.",
            "Ahora te lo explico mejor.",
            "Listo, aquí va la respuesta."
        };
        enum TipoUsuario { 
            Bot,
            Usuario
        }
        public FormChatbot()
        {
            InitializeComponent();
        }

        private void AgregarBurbuja(string pMensajeTexto,TipoUsuario pTipoUsuario)
        {
            if (pTipoUsuario == TipoUsuario.Bot)
            {
                var contenedor = new BurbujaDerecha();
                contenedor.DSPerfilVisible = true;
                contenedor.Margin = new Padding(0, 6, 0, 6);
                contenedor.Padding = new Padding(10, 0, 10, 0);
                contenedor.Height = 1; // se ajusta luego
                contenedor.Width = xscChat.ClientSize.Width - 20; // ancho útil
                contenedor.DSBody = pMensajeTexto;
                contenedor.DSFechaHora = DateTime.Now;
                contenedor.DSBackColorBurbuja = ColorTranslator.FromHtml("#F1F3F6");
                flpMessages.Controls.Add(contenedor);
                // 5) Scroll al último mensaje (más confiable)
                xscChat.ScrollControlIntoView(contenedor);
            }
            else {
                var contenedor = new BurbujaIzquierda();
                contenedor.DSPerfilVisible = true;
                contenedor.Margin = new Padding(0, 6, 0, 6);
                contenedor.Padding = new Padding(10, 0, 10, 0);
                contenedor.Height = 1; // se ajusta luego
                contenedor.Width = xscChat.ClientSize.Width - 20; // ancho útil
                contenedor.DSBody = pMensajeTexto;
                contenedor.DSFechaHora = DateTime.Now;
                contenedor.DSBackColorBurbuja = ColorTranslator.FromHtml("#E3F2FD");
                flpMessages.Controls.Add(contenedor);
                // 5) Scroll al último mensaje (más confiable)
                xscChat.ScrollControlIntoView(contenedor);
            }
        }
        private void PreguntarAlBotIA(string pMsnQuestion)
        {
            this.Cursor = Cursors.WaitCursor;
            pMsnQuestion = pMsnQuestion.Trim();
            if (pMsnQuestion == "") return;

            tbMensaje.Clear();

            // 1) Mostrar lo que escribió el usuario
            AgregarBurbuja(pMsnQuestion, TipoUsuario.Usuario);

            // 2) Evitar doble envío mientras "piensa"
            btnEnviar.Enabled = false;

            // 3) Lanzar worker
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync(pMsnQuestion);

        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {            
            PreguntarAlBotIA(tbMensaje.Text);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string pregunta = e.Argument as string;

            // Simula tiempo de "pensando..."
            System.Threading.Thread.Sleep(800);

            // Respuesta aleatoria (luego aquí llamas a tu API real)
            int idx = new Random().Next(respuestasBot.Count);
            string respuesta = respuestasBot[idx];

            e.Result = respuesta;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Cursor = Cursors.Default;

            btnEnviar.Enabled = true;

            if (e.Cancelled)
            {
                AgregarBurbuja("Se canceló la operación.", TipoUsuario.Bot);
                return;
            }

            if (e.Error != null)
            {
                AgregarBurbuja("Ocurrió un error: " + e.Error.Message, TipoUsuario.Bot);
                return;
            }

            string respuesta = e.Result as string;
            if (string.IsNullOrEmpty(respuesta))
                respuesta = "No tengo respuesta por ahora 😅";

            AgregarBurbuja(respuesta, TipoUsuario.Bot);
            tbMensaje.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            AgregarBurbuja(aMsnInicialBot, TipoUsuario.Bot);
        }

        private void tbMensaje_KeyDown(object sender, KeyEventArgs e)
        {
            // ENTER sin SHIFT → enviar mensaje
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                e.SuppressKeyPress = true; // evita salto de línea
                e.Handled = true;

                PreguntarAlBotIA(tbMensaje.Text);
                return;
            }

            // SHIFT + ENTER → permitir nueva línea
            if (e.KeyCode == Keys.Enter && e.Shift)
            {
                // No hacemos nada, el RichTextBox
                // se encarga de insertar el salto de línea
                return;
            }
        }
            

    }
}
