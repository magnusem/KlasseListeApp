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
        public KlasseViewModel()
        {
            KListe = new Model.KlasseListe();
        }
    }
}
