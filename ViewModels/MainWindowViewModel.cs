using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using _365WPF.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace _365WPF.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {

        [ObservableProperty]
        private int readRating;

        [ObservableProperty]
        private int exerciseRating;

        [ObservableProperty]
        private int healthyRating;

        [ObservableProperty]
        private int sleepRating;

        //[RelayCommand]
        //private void SaveLog()
        //{
        //    var log = new Log(readRating, exerciseRating, healthyRating, sleepRating);

        //}
      
    }
}
