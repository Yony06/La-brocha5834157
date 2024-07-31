using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_brocha5834157.model
{
    partial class Presupuesto : ObservableObject
    {
        [ObservableProperty]
        public string m2;
        [ObservableProperty]
        public string precio;
        [ObservableProperty]
        public string resultado;

        [RelayCommand]
        private void Costo()
        {
            if (double.TryParse(m2, out double M2) && double.TryParse(precio, out double Precio))
            {
                Resultado = (M2 * Precio).ToString();
            }
            else
            {
                Resultado = "Ingrese números válidos";
            }
        }
    }
}
