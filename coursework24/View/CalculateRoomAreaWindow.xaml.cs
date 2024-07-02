using System.Windows;
using coursework24.ViewModels;

namespace coursework24.View;

public partial class CalculateRoomAreaWindow : Window
{
    public CalculateRoomAreaWindow()
    {
        InitializeComponent();
        DataContext = new CalculateRoomAreaViewModel();
    }
}