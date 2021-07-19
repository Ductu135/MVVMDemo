using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMDemo.Common
{
    public interface IPageService
    {
        Task PushAsycn(Page page);
        Task<bool> DisplayAlert(string title, string message, string ok, string cancel);
    }
}
