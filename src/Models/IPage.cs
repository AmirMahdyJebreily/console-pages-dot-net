﻿namespace ConsolePages.Models
{
    public interface IPage
    {
        IAppContentLayout ContentLayout { get; }
        string MainContent { get; set; }
    }
}