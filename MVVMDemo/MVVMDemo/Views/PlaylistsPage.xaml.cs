using MVVMDemo.Common;
using MVVMDemo.Model;
using MVVMDemo.ViewModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlaylistsPage : ContentPage
    {
        public PlaylistsPage()
        {
            ViewModel = new PlaylistsViewModel(new PageService());
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        //private void OnAddPlaylist(object sender, System.EventArgs e)
        //{
        //    (BindingContext as PlaylistsViewModel).AddPlaylist();
        //}

        private void OnPlaylistSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ViewModel.SelectPlaylistCommand.Execute(e.SelectedItem);
        }

        private PlaylistsViewModel ViewModel
        {
            get => BindingContext as PlaylistsViewModel;

            set => BindingContext = value;
        }
    }
}