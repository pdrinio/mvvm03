using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm03
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private HabitantesService habitantesService;

        #region Properties
        private string _nuevoIntegrante;
        public string NuevoIntegrante
        {
            get { return _nuevoIntegrante; }
            set
            {
                _nuevoIntegrante = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NuevoIntegrante)));
            }
        }

        #endregion

    }
}
