using System.Windows;
using coursework24.ViewModels;

namespace coursework24.View;

public partial class AddRoomWindow : Window
{
    public AddRoomWindow()
    {
        InitializeComponent();
        DataContext = new AddRoomViewModel();
    }
}