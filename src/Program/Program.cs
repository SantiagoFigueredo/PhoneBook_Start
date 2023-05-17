using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            var owner = new Contact("Owner's Name");
            owner.Phone = "<Owner's Phone Number>";
            owner.Email = "<Owner's Email>";

            // Crear la lista de contactos
            var phonebook = new Phonebook(owner);

            // Agregar contactos a la lista
            var contact1 = new Contact("Contact 1");
            contact1.Phone = "<Contact 1 Phone Number>";
            contact1.Email = "<Contact 1 Email>";

            var contact2 = new Contact("Contact 2");
            contact2.Phone = "<Contact 2 Phone Number>";
            contact2.Email = "<Contact 2 Email>";

            phonebook.AddContact(contact1);
            phonebook.AddContact(contact2);

            // Enviar un correo a algunos contactos
            var emailChannel = new EmailChannel();
            var emailMessage = new Message("From Email", "To Email");
            emailMessage.Text = "Email message text";
            emailChannel.Send(emailMessage);

            // Enviar un WhatsApp a algunos contactos
            var whatsAppChannel = new WhatsAppChannel();
            var whatsAppMessage = new Message("From WhatsApp", "To WhatsApp");
            whatsAppMessage.Text = "WhatsApp message text";
            whatsAppChannel.Send(whatsAppMessage);

            // Enviar un mensaje por Twitter a algunos contactos
            var twitterChannel = new TwitterChannel();
            var twitterMessage = new Message("From Twitter", "To Twitter");
            twitterMessage.Text = "Twitter message text";
            twitterChannel.Send(twitterMessage);
        }
    }
}
