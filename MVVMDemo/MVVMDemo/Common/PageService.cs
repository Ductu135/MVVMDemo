using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMDemo.Common
{
    public class PageService : IPageService
    {
        public Task<bool> DisplayAlert(string title, string message, string ok, string cancel)
        {
            return Application.Current.MainPage.DisplayAlert(title, message, ok, cancel);
        }

        public Task PushAsycn(Page page)
        {
            return Application.Current.MainPage.Navigation.PushAsync(page);
        }
    }
}
