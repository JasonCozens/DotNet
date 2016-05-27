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
using System.Windows.Shapes;
using Microsoft.AspNet.SignalR.Client;

namespace SlimmingWorld
{
    /// <summary>
    /// Interaction logic for SignalRClient.xaml
    /// </summary>
    public partial class SignalRClient : Window
    {
        public SignalRClient()
        {
            InitializeComponent();
            var c = new Connection("http://localhost:29575/chat");
            var t = c.Start();
            t.Wait();
            c.Send("I'm here!");
        }
    }
}
