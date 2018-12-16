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
	public partial class ProgressBarPage : ContentPage
	{
		public ProgressBarPage ()
		{
			InitializeComponent ();
		}
        private void Modificar(object sender, EventArgs args)
        {
            Barra1.Progress = 1;
            Barra2.ProgressTo(1,5000,Easing.Linear); // traz uma animação
            Barra3.ProgressTo(1, 5000, Easing.BounceOut);
        }
    }
}