using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace KlasseListeApp.ViewModel
{
    class KlasseViewModel : INotifyPropertyChanged
    {
        public Model.KlasseListe KListe { get; set; }

        private Model.KlasseInfo SelectedElev;

        

        public Model.KlasseInfo selectedElev
        {
            get { return SelectedElev; }
            set { SelectedElev = value;
                OnPropertyChanged(nameof(selectedElev));
            }
        }


        public KlasseViewModel()
        {
            KListe = new Model.KlasseListe();
            AddElevCommand = new AddElevCommand(AddNewElev);
            selectedElev = new Model.KlasseInfo();
            //AddElevCommand = new RelayCommand(AddNewElev, null);
            NewElev = new Model.KlasseInfo();
            SletElevCommand = new SletElevCommand(SletElev);
            
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public AddElevCommand AddElevCommand { get; set; }

        public Model.KlasseInfo NewElev { get; set; }

        public void AddNewElev()
        {
            KListe.Add(NewElev);
        }
        //public RelayCommand AddElevCommand { get; set; }

        public SletElevCommand SletElevCommand { get; set; }


        public void SletElev()
        {
            KListe.Remove(SelectedElev);
        }


        public string GetKlasseListAsJson()
        {
            string jsonText = JsonConvert.SerializeObject(KListe);
            return jsonText;
        }

    }
}
