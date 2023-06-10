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

namespace WordPad_Wpf_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool checkBold = false;
        bool checkItalic = false;
        bool checkUnderLine = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        void SetSelectedTextBold(RichTextBox richTextBox)
        {
            if (richTextBox.Selection != null)
            {
                if (!richTextBox.Selection.IsEmpty)
                {
                    richTextBox.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
                    checkBold = true;
                    Bold_btn.Foreground = new SolidColorBrush(Colors.Black);

                }
            }
        }

        void SetSelectedTextItalic(RichTextBox richTextBox)
        {
            if (richTextBox.Selection != null)
            {
                if (!richTextBox.Selection.IsEmpty)
                {
                    richTextBox.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic);
                    checkItalic = true;
                    Italic_btn.Foreground = new SolidColorBrush(Colors.Black);
                }
            }
        }

       

        void SetSelectedTextUnderline(RichTextBox richTextBox)
        {
            if (richTextBox.Selection != null)
            {
                if (!richTextBox.Selection.IsEmpty)
                {
                    richTextBox.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
                    checkUnderLine = true;

                }
            }
        }



        private void Bold_btn_Click(object sender, RoutedEventArgs e)
        {

            if(checkBold)
            {
                if (my_txtBox.Selection != null)
                {
                    if (!my_txtBox.Selection.IsEmpty)
                    {
                        my_txtBox.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Normal);
                        checkBold = false;
                        Bold_btn.Foreground = new SolidColorBrush(Colors.White);

                    }
                }
            }
            else
            {
                SetSelectedTextBold(my_txtBox);

            }


        }

        private void Italic_btn_Click(object sender, RoutedEventArgs e)
        {
            if(checkItalic)
            {
                if (my_txtBox.Selection != null)
                {
                    if (!my_txtBox.Selection.IsEmpty)
                    {
                        my_txtBox.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Normal);
                        checkItalic = false;
                        Italic_btn.Foreground = new SolidColorBrush(Colors.White);
                    }
                }
            }

            else
            {
                SetSelectedTextItalic(my_txtBox);

            }

        }

        private void ULine_btn_Click(object sender, RoutedEventArgs e)
        {
            if(checkUnderLine)
            {
                if (my_txtBox.Selection != null)
                {
                    if (!my_txtBox.Selection.IsEmpty)
                    {
                        my_txtBox.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
                        checkUnderLine = false;
                    }
                }
            }

            else
            {
                SetSelectedTextUnderline(my_txtBox);
            }

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            if (my_txtBox.Selection != null)
            {
                if (!my_txtBox.Selection.IsEmpty)
                {
                    my_txtBox.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic);
                   
                }
            }
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            if (my_txtBox.Selection != null)
            {
                if (!my_txtBox.Selection.IsEmpty)
                {
                    my_txtBox.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Normal);
                }
            }
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            if (my_txtBox.Selection != null)
            {
                if (!my_txtBox.Selection.IsEmpty)
                {
                    my_txtBox.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Oblique);
                }
            }
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            if (my_txtBox.Selection != null)
            {
                if (!my_txtBox.Selection.IsEmpty)
                {
                    my_txtBox.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
                   

                }
            }
        }
    }
}
