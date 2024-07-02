using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using coursework24.DataBase;
using coursework24.Model;
using coursework24.Helpers;

namespace coursework24.ViewModels
{
    public class AddRoomViewModel : INotifyPropertyChanged
    {
        private UniversityContext _context;
        public ObservableCollection<Department> Departments { get; set; }
        public string RoomNumber { get; set; }
        public string Location { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public string Purpose { get; set; }
        public string RoomType { get; set; }
        public Department SelectedDepartment { get; set; }

        public ICommand AddRoomCommand { get; }

        public AddRoomViewModel()
        {
            _context = new UniversityContext();
            Departments = new ObservableCollection<Department>(_context.Departments.ToList());
            AddRoomCommand = new RelayCommand(AddRoom);
        }

        private void AddRoom()
        {
            var newRoom = new Room
            {
                RoomNumber = RoomNumber,
                Location = Location,
                Width = Width,
                Length = Length,
                Height = Height,
                Purpose = Purpose,
                RoomType = RoomType,
                DepartmentId = SelectedDepartment.DepartmentId
            };

            _context.Rooms.Add(newRoom);
            _context.SaveChanges();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}