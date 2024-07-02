using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using coursework24.DataBase;
using coursework24.Model;
using coursework24.Helpers;

namespace coursework24.ViewModels
{
    public class DepartmentsViewModel : INotifyPropertyChanged
    {
        private UniversityContext _context;
        public ObservableCollection<Department> Departments { get; set; }
        public Department SelectedDepartment { get; set; }
        public Department ParentDepartment { get; set; }
        public string DepartmentName { get; set; }

        public ICommand AddDepartmentCommand { get; }

        public DepartmentsViewModel()
        {
            _context = new UniversityContext();
            Departments = new ObservableCollection<Department>(_context.Departments.ToList());
            AddDepartmentCommand = new RelayCommand(AddDepartment);
        }

        private void AddDepartment()
        {
            if (string.IsNullOrWhiteSpace(DepartmentName))
            {
                return;
            }

            var newDepartment = new Department
            {
                Name = DepartmentName,
                ParentDepartmentId = ParentDepartment?.DepartmentId
            };

            _context.Departments.Add(newDepartment);
            _context.SaveChanges();

            // Обновляем коллекцию с учетом новых данных
            Departments.Clear();
            foreach (var department in _context.Departments.ToList())
            {
                Departments.Add(department);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}