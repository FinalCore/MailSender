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
            new Server(0, "Яндекс", "smtp.yandex.ru", 587, "UserLogin", "Password"),
            new Server(1, "Mail", "smtp.mail.ru", 587, "UserLogin", "Password"),
            new Server(2, "Google", "smtp.gmail.com", 587, "UserLogin", "Password")
        };

        public static List<Sender> Senders { get; } = new List<Sender>
        {
            new Sender(0, "Пупкин", "v.pupkin@mail.ru"),
            new Sender(1, "Петросян", "e.petrosyan@gamil.com"),
            new Sender(2, "Хабибулин", "a.habibulin@yandex.ru")
        };
        
MVVM_pattern_self-studying
        public static List<Recipient> Recepients { get; } = new List<Recipient>

master
        {
            new Recipient(0, "Васильев", "ee-vasya@mail.ru"),
            new Recipient(1, "Смирнов", "smirnoff@gamil.com"),
            new Recipient(2, "Бобров", "biber@yandex.ru")
        };
    }
}
