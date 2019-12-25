﻿using Domain;
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

namespace ChatClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List <Message> Messages;
        public MainWindow()
        {
            InitializeComponent();
            Messages = new List<Message>
            {
                new Message
                {
                    From = "Essss",
                    Text = "na xxxxx"
                },
                new Message
                {
                    From = "wewwew",
                    Text = "asd"
                },
                new Message
                {
                    From = "qweqwe",
                    Text = "asdasd"
                }
            };
            itemsControl.ItemsSource = Messages;
        }

        private void SendMessage(object sender, RoutedEventArgs e)
        {

        }
    }
}
