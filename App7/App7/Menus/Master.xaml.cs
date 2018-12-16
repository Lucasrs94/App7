using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App7.Menus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }
        private void Go(object sender, EventArgs args)
        {
            Detail = new Controles.Active();
        }
        private void GoProgressBarPage(object sender, EventArgs args)
        {
            Detail = new Controles.ProgressBarPage();
        }
        private void GoEntryEditor(object sender, EventArgs args)
        {
            Detail = new Controles.Entry();
        }
        private void GoDatePick(object sender, EventArgs args)
        {
            Detail = new Controles.DatePick();
        }
        private void TimePicker(object sender, EventArgs args)
        {
            Detail = new Controles.ImePicker();
        }
        private void Pesquisar
(object sender, EventArgs args)
        {
            Detail = new Controles.Search();
        }
     

    }
}