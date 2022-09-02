using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace WpfApp1.ViewModels;

public partial class Window8ViewModel : ObservableObject
{

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(FullName))]
    [NotifyCanExecuteChangedFor(nameof(SubmitCommand))]
    string _firstName = "";

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(FullName))]
    [NotifyCanExecuteChangedFor(nameof(SubmitCommand))]
    string _lastName = "";

    public string FullName => $"{FirstName} {LastName}";

    [RelayCommand]
    void Submit()
    {
        Debug.WriteLine("DEBUG: Submit entered");
        FirstName = string.Empty;
        LastName = string.Empty;
    }

}