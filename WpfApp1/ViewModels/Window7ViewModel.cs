using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using WpfApp1.Models;

namespace WpfApp1.ViewModels;

public class Window7ViewModel : ObservableCollection<Person>
{
    private Person _displayPerson = new();
    private Person _insertPerson = new();

    public ICommand InsertCommand { get; set; }
    public ICommand UpdateCommand { get; set; }
    public ICommand DeleteCommand { get; set; }

    public ICollectionView PersonView { get; private set; }
    
    public Person DisplayPerson
    {
        get => _displayPerson;
        set
        {
            _displayPerson = value;
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(DisplayPerson)));
        }
    } 

    public Person InsertPerson
    {
        get => _insertPerson;
        set
        {
            _insertPerson = value;
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(InsertPerson)));
        }
    }

    public Window7ViewModel()
	{
        CreatePerson();
        PersonView = new CollectionView(this);
        PersonView.CurrentChanged += SelectedItemChanged;

        InsertCommand = new Command(Insert);
        UpdateCommand = new Command(Update);
        DeleteCommand = new Command(Delete);
    }
    
    private void Insert(object obj)
    {
        this.Add(_insertPerson);
        _insertPerson = new();
        PersonView.Refresh();
    }

    private void Update(object obj)
    {
        _displayPerson = DisplayPerson;
        PersonView.Refresh();
    }

    private void Delete(object obj)
    {
        this.Remove(_displayPerson);
        PersonView.Refresh();
    }

    private void SelectedItemChanged(object sender, EventArgs e)
    {
        Person? current = PersonView.CurrentItem as Person;
        DisplayPerson = current;
    }

    private void CreatePerson()
    {
        for (int i = 0; i < 3; i++)
        {
            this.Add(new Person()
            {
                Name = String.Format("name {0}", i),
                Gender = true,
                Age = 10 + i,
                Id = i
            });
        }
    }
}

public class Command : ICommand
{
    Action<object> _executeMethod;
    Func<object, bool> _canexecuteMethod;

    public Command(Action<object> executeMethod)
    {
        this._executeMethod = executeMethod;
    }

    public event EventHandler CanExecuteChanged;

    public bool CanExecute(object parameter)
    {
        return true;
    }

    public void Execute(object parameter)
    {
        _executeMethod(parameter);
    }
}