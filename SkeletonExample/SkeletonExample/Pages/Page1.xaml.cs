﻿using SkeletonExample.ViewModels;

namespace SkeletonExample.Pages
{
    public partial class Page1 : BasePage
    {
        public Page1()
        {
            InitializeComponent();
            this.BindingContext = new Page1ViewModel();
        }
    }
}
