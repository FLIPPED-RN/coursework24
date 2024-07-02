using System.Collections.ObjectModel;
using System.ComponentModel;
using coursework24.DataBase;
using coursework24.Model;

namespace coursework24.ViewModels
{
    public class ViewRoomsViewModel : INotifyPropertyChanged
    {
        private UniversityContext _context;
        public ObservableCollection<Room> Rooms { get; set; }

        public ViewRoomsViewModel()
        {
            _context = new UniversityContext();
            Rooms = new ObservableCollection<Room>(_context.Rooms.ToList());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}