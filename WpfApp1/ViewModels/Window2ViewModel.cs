﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModels;

public class Window2ViewModel : ObservableCollection<string>
{
    public string DefaultStr { get; set; } = "Window2ViewModel";
}
