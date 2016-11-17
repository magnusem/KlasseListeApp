using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace KlasseListeApp.ViewModel
{
    class KlasseViewModel : INotifyPropertyChanged
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
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
