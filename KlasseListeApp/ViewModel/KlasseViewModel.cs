using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseListeApp.ViewModel
{
    class KlasseViewModel
    {
        public Model.KlasseListe KListe { get; set; }

        private Model.KlasseInfo SelectedElev;

        public Model.KlasseInfo selectedElev
        {
            get { return SelectedElev; }
            set { SelectedElev = value; }
        }


        public KlasseViewModel()
        {
            KListe = new Model.KlasseListe();
        }
    }
}
