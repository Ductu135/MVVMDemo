using MVVMDemo.Common;
using MVVMDemo.Model;
using MVVMDemo.Views;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMDemo.ViewModel
{
    public class PlaylistsViewModel : BaseViewModel
    {
        public ObservableCollection<PlaylistViewModel> Playlists { get; set; } = new ObservableCollection<PlaylistViewModel>();
        private readonly IPageService pageService;
        
        private PlaylistViewModel selectedPlaylist;
        public PlaylistViewModel SelectedPlaylist
        {
            get => selectedPlaylist;
            set
            {
                SetValue(ref selectedPlaylist, value);
                OnPropertyChanged();
            }
        }

        public ICommand AddPlaylistCommand { get; private set; }
        public ICommand SelectPlaylistCommand { get; private set; }

        public PlaylistsViewModel(IPageService pageService)
        {
            this.pageService = pageService;
            AddPlaylistCommand = new Command(AddPlaylist);
            SelectPlaylistCommand = new Command<PlaylistViewModel>(async vm => await SelectPlaylistAsync(vm));
        }

        private void AddPlaylist()
        {
            var newPlaylist = "Playlist " + (Playlists.Count + 1);
            Playlists.Add(new PlaylistViewModel { Title = newPlaylist });
        }

        private async Task SelectPlaylistAsync(PlaylistViewModel playlist)
        {
            if (playlist == null)
                return;

            playlist.IsFavorite = !playlist.IsFavorite;

            SelectedPlaylist = null;

            await pageService.PushAsycn(new PlaylistsDetailPage(playlist));
        }
    }
}
