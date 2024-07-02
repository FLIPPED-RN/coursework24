using System.ComponentModel;
using coursework24.View;
using System.Windows;
using System.Windows.Input;
using coursework24.Helpers;

namespace coursework24.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ICommand ViewDepartmentsCommand { get; }
        public ICommand ViewRoomsCommand { get; }
        public ICommand AddRoomCommand { get; }
        public ICommand CalculateRoomAreaCommand { get; }

        public MainViewModel()
        {
            ViewDepartmentsCommand = new RelayCommand(ViewDepartments);
            ViewRoomsCommand = new RelayCommand(ViewRooms);
            AddRoomCommand = new RelayCommand(AddRoom);
            CalculateRoomAreaCommand = new RelayCommand(CalculateRoomArea);
        }

        private void ViewDepartments()
        {
            var departmentsWindow = new DepartmentsWindow();
            departmentsWindow.Show();
        }

        private void ViewRooms()
        {
            var viewRoomsWindow = new ViewRoomsWindow();
            viewRoomsWindow.Show();
        }

        private void AddRoom()
        {
            var addRoomWindow = new AddRoomWindow();
            addRoomWindow.Show();
        }

        private void CalculateRoomArea()
        {
            var calculateRoomAreaWindow = new CalculateRoomAreaWindow();
            calculateRoomAreaWindow.Show();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}