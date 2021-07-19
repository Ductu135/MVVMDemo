using MVVMDemo.ViewModel;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace MVVMDemo.Model
{
    public class Playlist : BaseViewModel
    {
        public string Title { get; set; }
        public bool IsFavorite { get; set; }
    }
}
