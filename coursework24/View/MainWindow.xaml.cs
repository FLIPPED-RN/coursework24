using System.Windows;
using coursework24.ViewModels;

namespace coursework24.View;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}