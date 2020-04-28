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

namespace Z9_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int allAnswerCount = 0;
        Dictionary<string, int> answers = new Dictionary<string, int>()
        {
            {"A",0 },
            {"B",0 },
            {"C",0 },
            {"D",0 }
        };
        public MainWindow()
        {
            InitializeComponent();
            QuestionTextBlock.Text = "Wolisz A, B, C, D?";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var choice = button.Content.ToString();
            answers[choice]++;
            allAnswerCount++;
            AllAnswers.Text = allAnswerCount.ToString();
            RedrawGraph();
                
        }

        private void RedrawGraph()
        {
            var maxHeight = Canva.ActualHeight;
            R1.Height = maxHeight * (answers["A"] / (double)allAnswerCount);
            R2.Height = maxHeight * (answers["B"] / (double)allAnswerCount);
            R3.Height = maxHeight * (answers["C"] / (double)allAnswerCount);
            R4.Height = maxHeight * (answers["D"] / (double)allAnswerCount);
            
        }
    }
}
