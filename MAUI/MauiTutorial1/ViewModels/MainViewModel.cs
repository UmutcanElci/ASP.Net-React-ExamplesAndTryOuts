using MauiTutorial1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTutorial1.ViewModels
{
    public class MainViewModel : ViewModel
    {
        private readonly INewsService newsService;
        public MainViewModel(INewsService newsService) 
        {
            this.newsService = newsService;
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            var data = await newsService.Get();
        }
    }
}
