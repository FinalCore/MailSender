using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities;

namespace MailSender.lib.Data
{
    public static class TestData
    {
        public static List<Server> Servers { get; } = new List<Server>
        {
            new Server(1, "Яндекс", "smtp.yandex.ru", 587, "UserLogin", "Password"),
            new Server(2, "Mail", "smtp.mail.ru", 587, "UserLogin", "Password"),
            new Server(3, "Google", "smtp.gmail.com", 587, "UserLogin", "Password")
        };

        public static List<Sender> Senders { get; } = new List<Sender>
        {
            new Sender(1, "Пупкин", "v.pupkin@mail.ru"),
            new Sender(2, "Петросян", "e.petrosyan@gamil.com"),
            new Sender(3, "Хабибулин", "a.habibulin@yandex.ru")
        };

        public static List<Recipient> Recepients { get; } = new List<Recipient>
        {
            new Recipient(1, "Васильев", "ee-vasya@mail.ru"),
            new Recipient(2, "Смирнов", "smirnoff@gamil.com"),
            new Recipient(3, "Бобров", "biber@yandex.ru")
        };
    }
}

