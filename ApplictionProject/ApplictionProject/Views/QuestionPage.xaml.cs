
using ApplictionProject.Models;
using ApplictionProject.ViewModels;
using ApplictionProject.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ApplictionProject.Views
{
    public partial class QuestionPage : ContentPage
    {
        public QuestionPage()
        {
            InitializeComponent();

            BindingContext = new QuestionViewModel();
        }
    }
}
