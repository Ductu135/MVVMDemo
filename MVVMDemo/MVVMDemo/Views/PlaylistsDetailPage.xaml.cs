using MVVMDemo.Model;
using MVVMDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlaylistsDetailPage : ContentPage
    {
        private PlaylistViewModel _playlist;

        public PlaylistsDetailPage(PlaylistViewModel playlist)
        {
            _playlist = playlist;

            InitializeComponent();

            title.Text = _playlist.Title;
        }
    }
}