using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using coursework24.DataBase;
using coursework24.Model;
using coursework24.Helpers;

namespace coursework24.ViewModels
{
    public class CalculateRoomAreaViewModel : INotifyPropertyChanged
    {
        private UniversityContext _context;
        public ObservableCollection<string> RoomNumbers { get; set; }
        public string SelectedRoomNumber { get; set; }
        public string CalculationResult { get; set; }

        public ICommand CalculateAreaAndVolumeCommand { get; }

        public CalculateRoomAreaViewModel()
        {
            _context = new UniversityContext();
            RoomNumbers = new ObservableCollection<string>(_context.Rooms.Select(r => r.RoomNumber).ToList());
            CalculateAreaAndVolumeCommand = new RelayCommand(CalculateAreaAndVolume);
        }

        private void CalculateAreaAndVolume()
        {
            var room = _context.Rooms.FirstOrDefault(r => r.RoomNumber == SelectedRoomNumber);
            if (room != null)
            {
                var area = room.Width * room.Length;
                var volume = room.Width * room.Length * room.Height;
                CalculationResult = $"Room {SelectedRoomNumber}: Area = {area} sq.m., Volume = {volume} cu.m.";
            }
            else
            {
                CalculationResult = "Room not found.";
            }

            OnPropertyChanged(nameof(CalculationResult));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}