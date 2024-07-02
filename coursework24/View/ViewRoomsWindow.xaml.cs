using System.Windows;
using coursework24.ViewModels;

namespace coursework24.View;

public partial class ViewRoomsWindow : Window
{
    public ViewRoomsWindow()
    {
        InitializeComponent();
        DataContext = new ViewRoomsViewModel();
    }
}