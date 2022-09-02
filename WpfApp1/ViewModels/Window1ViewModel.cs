using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfApp1.Models;

namespace WpfApp1.ViewModels;

public class Window1ViewModel : ObservableCollection<Person>
{
    public Person Person1 { get; set; } = default;
    public Person Person2 { get; set; } = default;
    public Person Person3 { get; set; } = default;
    public Person Person4 { get; set; } = default;
    public Person Person5 { get; set; } = default;

    public string DefaultStr { get; set; } = "Window1ViewModel";

	public Window1ViewModel()
    {
        Person1 = new Person { Id = 1, Age = 11, Name = "chan1", Gender = true };
        Person2 = new Person { Id = 2, Age = 21, Name = "chan2", Gender = false };
        Person3 = new Person { Id = 3, Age = 31, Name = "chan3", Gender = true };
        Person4 = new Person { Id = 4, Age = 4, Name = "chan4", Gender = false };
        Person5 = new Person { Id = 5, Age = 5, Name = "chan5", Gender = false };
        Add(Person1);
        Add(Person2);
        Add(Person3);
        Add(Person4);
        Add(Person5);
        
    }
}
