using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace App3.ViewModels
{
    public class NombreCompletoViewModel : BaseViewModel
    {
        private string _nombre;
        private string _paterno;
        private string _materno;

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.Equals(_nombre, value)) return;
                _nombre = value;
                OnPropertyChanged(nameof(Nombre));
                OnPropertyChanged(nameof(Completo));
            }
        }
        public string Paterno
        {
            get => _paterno;
            set
            {
                if (string.Equals(_paterno, value)) return;
                _paterno = value;
                OnPropertyChanged(nameof(Paterno));
                OnPropertyChanged(nameof(Completo));
            }
        }
        public string Materno
        {
            get => _materno;
            set
            {
                if (string.Equals(_materno, value)) return;
                _materno = value;
                OnPropertyChanged(nameof(Materno));
                OnPropertyChanged(nameof(Completo));
            }
        }

        public string Completo => $"{Nombre} {Paterno} {Materno}";
    }
}
