using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
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
using RegexForm.ViewModel;

namespace RegexForm
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

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

            ArrayList errorList = new ArrayList();

            if (!Validator.IsNameValid(TextName.Text))
            {
                errorList.Add("Invalid name format, please only use alphabetical characters.");
            }

            if (!Validator.IsEmailValid(TextMail.Text))
            {
                errorList.Add("Invalid email address, please enter a valid email address.");
            }

            if (!Validator.IsPhoneNumberValid(TextPhone.Text))
            {
                errorList.Add("Invalid phone number, please enter a valid phone number");
            }

            DisplayMessage(errorList);
        }

        private void DisplayMessage(ArrayList errors)
        {
            if (errors.Count > 0)
            {
                string errorMessage = "";

                foreach (var error in errors)
                {
                    errorMessage += error + "\n";
                }

                MessageBox.Show("The following errors have occured: \n" + errorMessage);
            }
            else
            {
                MessageBox.Show("Sucess!");
            }
            
        }
    }
    }
