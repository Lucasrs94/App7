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
	public partial class DatePick : ContentPage
	{
		public DatePick ()
		{
			InitializeComponent ();
		}
        public void ActionDateSelected(object sander,DateChangedEventArgs args)
        {
            lbl_resultado.Text = args.OldDate.ToString("dd/MM/yyyy") + " > " +args.NewDate.ToString("dd/MM/yyyy");

        }

    }
}