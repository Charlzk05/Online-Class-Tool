using System;
using System.Collections.Generic;
using System.Data;
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
using Microsoft.Win32;
using System.IO;

namespace OnlineClassTool
{
    /// <summary>
    /// Interaction logic for TextEditor.xaml
    /// </summary>
    public partial class TextEditor : Window
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = "Text File Name";
            saveFileDialog.DefaultExt = "*.txt";
            saveFileDialog.Filter = "Text File (.txt)|*.txt";

            Nullable<bool> result = saveFileDialog.ShowDialog();

            if (result == true)
            {
                string filename = saveFileDialog.FileName;
                string richText = new TextRange(rTextBox.Document.ContentStart, rTextBox.Document.ContentEnd).Text;
                File.WriteAllText(filename, richText);
            }
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                string writeTextBox = File.ReadAllText(openFileDialog.FileName);
                rTextBox.Document.Blocks.Clear();
                rTextBox.Document.Blocks.Add(new Paragraph(new Run(writeTextBox)));
            }
        }

        private void MFS10_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontSize = 10;
        }

        private void MFS12_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontSize = 12;
        }

        private void MFS14_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontSize = 14;
        }

        private void MFS16_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontSize = 16;
        }

        private void MFS18_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontSize = 18;
        }

        private void MFS20_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontSize = 20;
        }

        private void MFS22_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontSize = 22;
        }

        private void MFS24_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontSize = 24;
        }

        private void MFS26_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontSize = 26;
        }

        private void MFS28_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontSize = 28;
        }

        private void MFS30_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontSize = 30;
        }

        private void FFConsolas_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontFamily = new FontFamily("Consolas");
        }

        private void FFSegeoUI_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontFamily = new FontFamily("Segeo UI");
        }

        private void FFArial_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontFamily = new FontFamily("Arial");
        }

        private void FFBahnschrift_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontFamily = new FontFamily("Bahnschrift");
        }

        private void FFYuGothicUI_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontFamily = new FontFamily("Yu Gothic UI");
        }

        private void FFVerdana_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontFamily = new FontFamily("Verdana");
        }

        private void FWUltraLight_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontWeight = FontWeights.UltraLight;
        }

        private void FWLight_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontWeight = FontWeights.Light;
        }

        private void FWNormal_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontWeight = FontWeights.Normal;
        }

        private void FWMedium_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontWeight = FontWeights.Medium;
        }

        private void FWSemiBold_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontWeight = FontWeights.SemiBold;
        }

        private void FWBold_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontWeight = FontWeights.Bold;
        }

        private void FWUltraBold_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontWeight = FontWeights.UltraBold;
        }

        private void FWBlack_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontWeight = FontWeights.Black;
        }

        private void FWHeavy_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontWeight = FontWeights.Heavy;
        }

        private void FWUltraBlack_Click(object sender, RoutedEventArgs e)
        {
            rTextBox.FontWeight = FontWeights.UltraBlack;
        }
    }
}
