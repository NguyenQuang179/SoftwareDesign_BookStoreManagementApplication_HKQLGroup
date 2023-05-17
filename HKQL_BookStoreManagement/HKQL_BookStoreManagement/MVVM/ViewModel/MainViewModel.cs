using HKQL_BookStoreManagement.Core;
using HMQL_Project01_QuanLyBanHang.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HKQL_BookStoreManagement.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand DragWindowCommand { get; set; }

        public RelayCommand MinimizedWindowCommand { get; set; }

        public RelayCommand WindowStateCommand { get; set; }

        public RelayCommand ExitWindowCommand { get; set; }


        //Order
        public RelayCommand OrderManagementViewCommand { get; set; }

        public RelayCommand OrderDetailViewCommand { get; set; }
        public RelayCommand OrderAddBookViewCommand { get; set; }
        public RelayCommand OrderAddViewCommand { get; set; }

        //Category
        public RelayCommand CategoryManagementViewCommand { get; set; }


        //COrder
        public OrderMangementViewModel OrderManagementVM { get; set; }

        public OrderDetailViewModel ORderDetailVM { get; set; }
        public OrderAddBookViewModel OrderAddBookVM { get; set; }

        //Category
        public CategoryManagementViewModel CategoryManagementVM { get; set; }

        private bool dashboardIsSelected;
        public bool DashboardIsSelected
        {
            get => dashboardIsSelected;
            set
            {
                dashboardIsSelected = value;
                OnPropertyChanged(nameof(DashboardIsSelected));
            }
        }
        
        private bool productIsSelected;
        public bool ProductIsSelected
        {
            get => productIsSelected;
            set
            {
                productIsSelected = value;
                OnPropertyChanged(nameof(ProductIsSelected));
            }
        }
        
        private bool categoryIsSelected;
        public bool CategoryIsSelected
        {
            get => categoryIsSelected;
            set
            {
                categoryIsSelected = value;
                OnPropertyChanged(nameof(CategoryIsSelected));
            }
        }
        
        private bool orderIsSelected;
        public bool OrderIsSelected
        {
            get => orderIsSelected;
            set
            {
                orderIsSelected = value;
                OnPropertyChanged(nameof(OrderIsSelected));
            }
        }

        private bool salesReportIsSelected;
        public bool SalesReportIsSelected
        {
            get => salesReportIsSelected;
            set
            {
                salesReportIsSelected = value;
                OnPropertyChanged(nameof(SalesReportIsSelected));
            }
        }

        public RelayCommand DashboardViewCommand { get; set; }

        public DashboardViewModel DashboardVM { get; set; }

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



        public MainViewModel() {

            DashboardVM = new DashboardViewModel();

            CurrentView = DashboardVM;

            DashboardIsSelected = true;
            ProductIsSelected = false;
            CategoryIsSelected = false;
            OrderIsSelected = false;
            SalesReportIsSelected = false;

            DragWindowCommand = new RelayCommand(o =>
            {
                Application.Current.Windows[0].DragMove();
            });

            MinimizedWindowCommand = new RelayCommand(o =>
            {
                Application.Current.Windows[0].WindowState = WindowState.Minimized;
            });

            WindowStateCommand = new RelayCommand(o =>
            {
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

            //Order
            OrderManagementViewCommand = new RelayCommand(o =>
            {
                CurrentView = OrderManagementVM;
                OrderIsSelected = true;
            });
            OrderAddBookViewCommand = new RelayCommand(o =>
            {
                CurrentView = OrderAddBookVM;
                OrderIsSelected = true;
            });
            //Category
            CategoryManagementViewCommand = new RelayCommand(o =>
            {
                CurrentView = CategoryManagementVM;
                CategoryIsSelected = true;
            });
        }
    }
}
