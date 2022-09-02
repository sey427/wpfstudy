using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using WpfApp1.Models;

namespace WpfApp1.ViewModels;

public class Window6ViewModel
{/*
    private ObservableCollection<Person> _people = new();
    private Person _displayPerson = new();
    private Person _insertPerson = new();

    public ICollectionView Customers { get; private set; }

    public DelegateCommand InsertCommand { get; private set; }
    public DelegateCommand UpdateCommand { get; private set; }
    public DelegateCommand DeleteCommand { get; private set; }

    public ObservableCollection<Person> People
    {
        get { return _people; }
        set { SetProperty(ref _people, value); }
    }

    public Person DisplayPerson
    {
        get => _displayPerson;
        set { SetProperty(ref _displayPerson, value); }
    }

    public Person InsertPerson
    {
        get => _insertPerson;
        set { SetProperty(ref _insertPerson, value); }
    }
    
    public Window6ViewModel()
    {
        CreatePeople();
        Customers = new ListCollectionView(People);
        Customers.CurrentChanged += SelectedItemChanged;

        InsertCommand = new DelegateCommand(Insert);
        UpdateCommand = new DelegateCommand(Update);
        DeleteCommand = new DelegateCommand(Delete);
    }
    private void Insert()
    {
        People.Add(InsertPerson);
        InsertPerson = new();
        Customers.Refresh();
    }

    private void Update()
    {
        DisplayPerson = DisplayPerson;
        Customers.Refresh();

    }

    private void Delete()
    {
        People.Remove(DisplayPerson);
        Customers.Refresh();
    }

    private void SelectedItemChanged(object sender, EventArgs e)
    {
        Person? current = Customers.CurrentItem as Person;
        DisplayPerson = current;
    }

    private void CreatePeople()
    {
        var people = new ObservableCollection<Person>();
        for (int i = 0; i < 3; i++)
        {
            people.Add(new Person()
            {
                Name = String.Format("name {0}", i),
                Gender = true,
                Age = 40 + i,
                Id = i
            });
        }

        People = people;
    }
    */
}
