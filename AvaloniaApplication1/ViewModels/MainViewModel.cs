using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace AvaloniaApplication1.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private string Greeting => "Welcome to Avalonia!";
    [ObservableProperty]
    private string allowInput;
    [ObservableProperty]
    private ObservableCollection<string> items;


    public MainViewModel()
    {
        Items = new ObservableCollection<string>();
    }
    [RelayCommand]
    private void Count()
    {
        if(Items == null)
            Items = new ObservableCollection<string>();

        Items.Add (Greeting);
    }
}
