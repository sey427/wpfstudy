using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models;


public partial class Person : INotifyPropertyChanged
{
    int _id;
    public int Id//{ get; set; } = default; 
    {
        get=>_id;
        set
        {
            _id = value;
            OnPropertyChanged(nameof(Id));
        }
    }
    int _age;
    public int Age// { get; set; } = default;
    {
        get => _age;
        set
        {
            _age = value;
            OnPropertyChanged(nameof(Age));
        }
    }
    string _name;
    public string Name //{ get; set; } = default;
    {
        get => _name;
        set
        {
            _name = value;
            OnPropertyChanged(nameof(Name));
        }
    }
    bool _gender;
    public bool Gender //{ get; set; } = default;
    {
        get => _gender;
        set
        {
            _gender = value;
            OnPropertyChanged(nameof(Gender));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged(string propertyName)
    {
        PropertyChangedEventHandler? temp = PropertyChanged;
        //if(temp != null) temp(this, new PropertyChangedEventArgs(propertyName));
        temp?.Invoke(this, new PropertyChangedEventArgs(nameof(propertyName)));
    }
}
public partial class Person
{
    public override string ToString()
    => $"Id:{Id} Age:{Age} Name:{Name} Gender:{Gender}";
}