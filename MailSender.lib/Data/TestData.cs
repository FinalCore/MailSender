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
            new Server("Яндекс", "smtp.yandex.ru", 587, "UserLogin", "Password"),
            new Server("Mail", "smtp.mail.ru", 587, "UserLogin", "Password"),
            new Server("Google", "smtp.gmail.com", 587, "UserLogin", "Password")
        };

        public static List<Sender> Senders { get; } = new List<Sender>
        {
            new Sender("Пупкин", "v.pupkin@mail.ru"),
            new Sender("Петросян", "e.petrosyan@gamil.com"),
            new Sender("Хабибулин", "a.habibulin@yandex.ru")
        };
    }
}
