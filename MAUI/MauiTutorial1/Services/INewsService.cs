﻿using MauiTutorial1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTutorial1.Services
{
    public interface INewsService
    {
        Task<List<NewsItem>> Get();
    }
}
