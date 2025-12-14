# ChatBot WinForms — Interfaz tipo WhatsApp (.NET Framework 4.0)

Proyecto de **interfaz gráfica tipo chatbot estilo WhatsApp**, desarrollado en **C# WinForms sobre .NET Framework 4.0**.  
La aplicación permite interactuar con un bot mediante mensajes en formato de burbujas, simulando una conversación moderna similar a WhatsApp Desktop.

Este proyecto está enfocado en **UI/UX**, integración con **API REST** y manejo asíncrono para no bloquear la interfaz.

---

## 📸 Vista previa

![ChatBot WinForms UI](docs/chatbot-preview.png)

> Interfaz con burbujas de chat (usuario / bot), timestamps, avatar y scroll automático.

---

## ✨ Características

- 💬 Interfaz tipo **WhatsApp**
- 🧩 Burbujas de mensaje diferenciadas (usuario / bot)
- 🕒 Timestamps por mensaje
- 🔽 Scroll vertical automático al último mensaje
- 🔗 Soporte para mensajes largos y texto multilínea
- 🌐 Preparado para consumir **API REST**
- ⚙️ Procesamiento asíncrono (BackgroundWorker)
- 🖥️ Compatible con **.NET Framework 4.0**

---

## 🧰 Tecnologías utilizadas

- C#
- WinForms
- .NET Framework 4.0
- HTTP REST
- Controles personalizados / WinForms nativo  
*(Compatible con DevExpress u otras librerías si se desea ampliar)*

---

## 🧠 Flujo de funcionamiento

1. El bot muestra un mensaje inicial de bienvenida.
2. El usuario escribe un mensaje y presiona **Enviar**.
3. Se agrega la burbuja del usuario al panel de conversación.
4. El mensaje se envía a un servicio REST en segundo plano.
5. El bot responde y se muestra su burbuja automáticamente.
6. La vista hace **autoscroll** al último mensaje.

---

## 🗂️ Estructura del proyecto (sugerida)

```text
/src
 ├── UI
 │   ├── ChatForm.cs
 │   └── Controls
 │       ├── BotBubble.cs
 │       └── UserBubble.cs
 ├── Services
 │   └── ChatApiClient.cs
 ├── Models
 │   └── ChatMessage.cs
 └── Utils
     └── UrlHelper.cs
/docs
 └── chatbot-preview.png
