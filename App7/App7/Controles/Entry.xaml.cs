using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App7.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Entry : ContentPage
    {
        public Entry()
        {
            InitializeComponent();

            idade.TextChanged += delegate (object sender, TextChangedEventArgs args)
            {
                lbl_duplicado.Text = args.NewTextValue;


            };
            Comentario.Completed += delegate (object sender, EventArgs args)
            {
                lblquantidade.Text =  Comentario.Text.Length.ToString();
               
            };
        }
    }
}