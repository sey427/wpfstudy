using System.Windows;
using System.Windows.Controls;
using WpfApp1.Models;

namespace WpfApp1.Controls;

public class PersonButton : Button
{

    
    //CLR property
    //static property service step 3: reference
    public int Id //{ get; set; } = default;
    {
        //store tech  entityFramework
        get => (int)GetValue(IdProperty);
        set => SetValue(IdProperty, value);
    }
    public int Age //{ get; set; } = default;
    {
        get => (int)GetValue(AgeProperty);
        set => SetValue(AgeProperty, value);
    }
    public string Irum //{ get; set; } = default;
    {
        get => (string)GetValue(NameProperty);
        set => SetValue(NameProperty, value);
    }
    public bool Gender //{ get; set; } = default;
    {
        get => (bool)GetValue(GenderProperty);
        set => SetValue(GenderProperty, value);
    }

    public event RoutedEventHandler CustomClick
    {
        add { AddHandler(CustomClickEvent, value); }
        remove { RemoveHandler(CustomClickEvent, value); }
    }
    public event RealRoutedEventHandler RealCustomClick
    {
        add { AddHandler(RealCustomClickEvent, value); }
        remove { RemoveHandler(RealCustomClickEvent, value); }
    }
    public event RealWorldRoutedEventHandler RealWorldCustomClick
    {
        add { AddHandler(RealWorldCustomClickEvent, value); }
        remove { RemoveHandler(RealWorldCustomClickEvent, value); }
    }
    public void CustomEventTest1()
    {
        //raise our custom CustomClickEvent event
        RoutedEventArgs args = new RoutedEventArgs(CustomClickEvent);
        RaiseEvent(args);
    }
    public void RealCustomEventTest()
    {
        //RoutedEventArgs args = new RoutedEventArgs(CustomClickEvent);
        CustomEventArgs args = new CustomEventArgs(RealCustomClickEvent, new Person { Id = this.Id , Age = this.Age, Gender = this.Gender, Name = this.Irum});
        RaiseEvent(args);
    }
    public void RealWorldCustomEventTest()
    {
        //RoutedEventArgs args = new RoutedEventArgs(CustomClickEvent);
        RealWorldCustomEventArgs args = new RealWorldCustomEventArgs(RealWorldCustomClickEvent, this.Irum);
        RaiseEvent(args);
    }
    //Dependency property

    //static property service step 1: declare
    public static readonly DependencyProperty IdProperty;
    public static readonly DependencyProperty AgeProperty;
    public static new readonly DependencyProperty NameProperty;
    public static readonly DependencyProperty GenderProperty;

    public static readonly RoutedEvent CustomClickEvent;
    public static readonly RoutedEvent RealCustomClickEvent;
    public static readonly RoutedEvent RealWorldCustomClickEvent;


    //static property service step 2: define
    static PersonButton()
    {
        IdProperty = DependencyProperty.Register("Id", typeof(int), typeof(PersonButton), new PropertyMetadata(0));
        AgeProperty = DependencyProperty.Register("Age", typeof(int), typeof(PersonButton), new PropertyMetadata(0));
        NameProperty = DependencyProperty.Register("Irum", typeof(string), typeof(PersonButton), new PropertyMetadata("CHAN"));
        GenderProperty = DependencyProperty.Register("Gender", typeof(bool), typeof(PersonButton), new PropertyMetadata(true));

        CustomClickEvent = EventManager.RegisterRoutedEvent("CustomClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(PersonButton));
        RealCustomClickEvent = EventManager.RegisterRoutedEvent("RealCustomClick", RoutingStrategy.Bubble, typeof(RealRoutedEventHandler), typeof(PersonButton));
        RealWorldCustomClickEvent = EventManager.RegisterRoutedEvent("RealWorldCustomClick", RoutingStrategy.Bubble, typeof(RealWorldRoutedEventHandler), typeof(PersonButton));
    }

}

public delegate void RealRoutedEventHandler(object sender, CustomEventArgs e);
public class CustomEventArgs : RoutedEventArgs {
    public Person? Saram { get; set; } = default;
    public CustomEventArgs(RoutedEvent routedEvent,Person per)
        : base(routedEvent)
    {
        Saram = per;
    }
}
public delegate void RealWorldRoutedEventHandler(object sender, RealWorldCustomEventArgs e);
public class RealWorldCustomEventArgs : RoutedEventArgs
{
    public string Name { get; set; } = default;
    public RealWorldCustomEventArgs(RoutedEvent routedEvent, string name)
        : base(routedEvent)
    {
        Name = name;
    }
}