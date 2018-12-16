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
    public partial class Search : ContentPage
    {
        private List<String> empresaTi;

        public Search()
        {
            InitializeComponent();

            empresaTi = new List<string>();
            empresaTi.Add("Microsoft");
            empresaTi.Add("CocaCola");
            empresaTi.Add("Uber");
            empresaTi.Add("Cinemark");
            empresaTi.Add("Americanas");
            empresaTi.Add("Walmart");
            empresaTi.Add("PagCerto");
            empresaTi.Add("Vivo");
            preencher(empresaTi);
         

        }
        private void preencher(List<string> empresaTi)
        {
            listaresultados.Children.Clear();
            foreach (var empresa in empresaTi)
            {
                listaresultados.Children.Add(new Label { Text = empresa });
            }
        }
        private void pesquisa(object sender,TextChangedEventArgs args)
        {
            var resultado = empresaTi.Where(a => a.Contains(args.NewTextValue)).ToList<string>();
            preencher(resultado);
        }

    }
}