using MauiTutorial1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTutorial1.Services
{
    public class NewsService : INewsService
    {
        public Task<List<NewsItem>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
