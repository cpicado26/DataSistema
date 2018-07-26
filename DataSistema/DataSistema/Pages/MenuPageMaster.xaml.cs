using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataSistema.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPageMaster : ContentPage
    {
        public ListView ListView;

        public MenuPageMaster()
        {
            InitializeComponent();

            BindingContext = new MenuPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MenuPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MenuPageMenuItem> MenuItems { get; set; }
            
            public MenuPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MenuPageMenuItem>(new[]
                {
                    new MenuPageMenuItem { Id = 0, Title = "Page 1",Icon ="web_hi_res_512.png" },
                    new MenuPageMenuItem { Id = 1, Title = "Page 2" ,Icon ="web_hi_res_512.png"},
                    new MenuPageMenuItem { Id = 2, Title = "Page 3" ,Icon ="web_hi_res_512.png"},
                    new MenuPageMenuItem { Id = 3, Title = "Page 4" ,Icon ="web_hi_res_512.png"},
                    new MenuPageMenuItem { Id = 4, Title = "Page 5" ,Icon ="web_hi_res_512.png"},
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}