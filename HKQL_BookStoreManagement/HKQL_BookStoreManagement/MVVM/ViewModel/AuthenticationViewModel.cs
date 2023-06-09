﻿using HKQL_BookStoreManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HKQL_BookStoreManagement.MVVM.ViewModel
{
    class AuthenticationViewModel : ObservableObject
    {
        public RelayCommand DragWindowCommand { get; set; }

        public RelayCommand MinimizedWindowCommand { get; set; }

        public RelayCommand WindowStateCommand { get; set; }

        public RelayCommand ExitWindowCommand { get; set; }

        public RelayCommand LoginViewCommand { get; set; }

        public RelayCommand SignUpViewCommand { get; set; }

        public RelayCommand RecoverPassViewCommand { get; set; }

        public LoginViewModel LoginVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public AuthenticationViewModel()
        {
            LoginVM = new LoginViewModel(this);

            CurrentView = LoginVM;

            DragWindowCommand = new RelayCommand(o =>
            {
                Application.Current.Windows[0].DragMove();
            });

            MinimizedWindowCommand = new RelayCommand(o => {
                Application.Current.Windows[0].WindowState = WindowState.Minimized;
            });

            WindowStateCommand = new RelayCommand(o => {
                if (Application.Current.Windows[0].WindowState != WindowState.Maximized)
                {
                    Application.Current.Windows[0].WindowState = WindowState.Maximized;
                }
                else
                {
                    Application.Current.Windows[0].WindowState = WindowState.Normal;
                }
            });

            ExitWindowCommand = new RelayCommand(o =>
            {
                Application.Current.Shutdown();
            });

            LoginViewCommand = new RelayCommand(o =>
            {
                CurrentView = LoginVM;
            });

        }
    }
}
