using ShopList.Gui.Models;
using System.Collections.ObjectModel;

namespace ShopList.Gui.ViewModels
{
    public class ShopListViewModel
    {
        public ObservableCollection<ShopListItem> ShopList { get; }

        public ShopListViewModel()
        {
            ShopList = new ObservableCollection<ShopListItem>();
            CargarDatos();
        }

        private void CargarDatos()
        {
            ShopList.Add(new ShopListItem()
            {
                Id = 1,
                Nombre = "Pan de caja",
                Cantidad = 1,
                Comprado = false,
            });
            ShopList.Add(new ShopListItem()
            {
                Id = 2,
                Nombre = "Leche",
                Cantidad = 3,
                Comprado = false,
            });
            ShopList.Add(new ShopListItem()
            {
                Id = 3,
                Nombre = "Queso",
                Cantidad = 100,
                Comprado = false,
            });
        }
    }
}
