﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SoundCloudClone.Views;
using SoundCloudClone.Interfaces;
using SoundCloudClone.Services;
using SoundCloudClone.Enums;

namespace SoundCloudClone
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            RegisterDependencies();
            CheckTheme();
            MainPage = new MainPage();
        }

        private void RegisterDependencies()
        {
            DependencyService.Register<IApi, ApiService>();
            DependencyService.Register<ITheme, ThemeService>();
            DependencyService.Register<IStorage, StorageService>();
        }

        private void CheckTheme()
        {
            var storage = DependencyService.Get<IStorage>();
            var theme = storage.Get(Constants.SelectedThemeKey, (int)ThemeEnum.NonSelected);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
