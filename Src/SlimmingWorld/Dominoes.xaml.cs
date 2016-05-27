using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace SlimmingWorld
{
    /// <summary>
    /// Interaction logic for Dominoes.xaml
    /// </summary>
    public partial class Dominoes : Window
    {
        private readonly List<string> _zero = new List<string>() {};
        private readonly List<string> _one = new List<string> { "M" };
        private readonly List<string> _two = new List<string> { "L3", "R1" };
        private readonly List<string> _three = new List<string> { "M", "L3", "R1" };
        private readonly List<string> _four = new List<string> { "L1", "L3", "R1", "R3"};
        private readonly List<string> _five = new List<string> { "M", "L1", "L3", "R1", "R3" };
        private readonly List<string> _six = new List<string> { "L1", "L2", "L3", "R1", "R2", "R3" };
        private readonly Dictionary<ContentControl, List<string>> _dots; 

        public Dominoes()
        {
            InitializeComponent();
            _dots = new Dictionary<ContentControl, List<string>>
            {
                {D0, _zero},
                {D1, _one},
                {D2, _two},
                {D3, _three},
                {D4, _four},
                {D5, _five},
                {D6, _six}
            };
            HideDots();
        }

        public void HideDots()
        {
            foreach (var key in _dots.Keys)
            {
                var canvas = key.Content as Canvas;
                Debug.Assert(canvas?.Children != null, "canvas?.Children != null");
                foreach (var ellipse in canvas?.Children.OfType<Ellipse>().Where(e => !_dots[key].Contains(e.Name)))
                {
                    ellipse.Visibility = Visibility.Hidden;
                }
            }
        }
    }
}
