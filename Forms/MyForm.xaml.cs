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


namespace RAA_Lvl2_Skills_01
{
    /// <summary>
    /// Interaction logic for Window.xaml
    /// </summary>
    public partial class MyForm : Window
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {

            tbxFile.Text = "I clicked the button";
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {            
            this.DialogResult = false;
            this.Close();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true; 
            this.Close();

        }

        public string GetTextBoxValue()
        {
            return tbxFile.Text;
        }

        public bool GetCheckBox1Value()
        {
           // return (bool)chbCheck1.IsChecked;
           if (chbCheck1.IsChecked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetGroup1()
        {
            if (rb1.IsChecked == true)
            {
                return rb1.Content.ToString();
            }
            else if (rb2.IsChecked == true)
            {
                return rb2.Content.ToString();
            }
            else if (rb3.IsChecked == true)
            {
                return rb3.Content.ToString();
            }
            else
            {
                return "None";
            }
        }
    }
}
