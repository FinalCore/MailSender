using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MailSender.lib.Entities;
using MailSender.lib.Services;

namespace MailSender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() 
        {
            InitializeComponent();
        }


        //private void OnSendButtonClick(object Sender, RoutedEventArgs e)
        //{
        //    var recipient = recipientsList.SelectedItem as Recipient;
        //    var sender = sendersList.SelectedItem as Sender;
        //    var server = serversList.SelectedItem as Server;

        //    if (editSend.IsChecked == false)
        //    {
        //        var mailSender = new lib.Services.MailSender(server.Address, server.Port, server.UseSSL, server.Login, server.Password);

        //        mailSender.Send(mailTopic.Text, mailText.Text, sender.Address, recipient.Address);
        //    }
        //    else
        //    {
        //        SenderEditor senderEditor = new SenderEditor();
        //        senderEditor.Show();
        //        var mailSender = new lib.Services.MailSender("smtp.yandex.ru", 25, true, senderEditor.editSenderName.Text, senderEditor.editSenderName.Text);

        //        mailSender.Send(mailTopic.Text, mailText.Text, "rimedheart@yandex.ru", "rimedheart@yandex.ru");
        //    }            
        //}

       

        private void editSend_Checked(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
