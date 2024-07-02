using System.Windows;
using coursework24.ViewModels;

namespace coursework24.View;

public partial class DepartmentsWindow : Window
{
    public DepartmentsWindow()
    {
        InitializeComponent();
        DataContext = new DepartmentsViewModel();
    }
}