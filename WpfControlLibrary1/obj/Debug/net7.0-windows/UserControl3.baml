   M S B A M L   `   `   `  ????M  IWpfControlLibrary1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfControlLibrary1WpfControlLibrary1  5      %    WpfControlLibrary1.UserControl3   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:WpfControlLibrary1     5      .??5      ? .+?5	   
   ?? $??10q?5
        ?? SelectionMode$  Single=?5      $
??Left=?5      $	??Top=?5      ??5	      ?? ??5      ?? 5      .?5      ??  ?? Property ? ?? ?? Value$ Stretch=?6K   ?? 5       ? ??$ Stretch=?6I   5       ?? View 5      ?? 5      .P?5      ?? -   5        
ageColumn1??$	??Age??5   9    ?? Width$ 80??6F    ?? CellTemplate 5      ?? 5      .R?5   "   ?? $??
6,-1,-6,-1q?6*   ??6>   ?? *Age+ ?? Mode$ TwoWay=? ?? NotifyOnValidationError$
 true?? ?? ValidatesOnExceptions$
 true??5      5      ?? 5      -   5        genderColumn1??$??Gender??5   <   $ 80??6L    5      ?? 5      .R?5    "   ?? $??-6,-1q?6?   	 d? 	IsChecked	 6+   ?? *Gender+$ TwoWay=?$
 true??$
 true??6?   5!      5#      ?? 5$      -   5        	idColumn1??$??Id??5$   8   $ 80??6D    5%      ?? 5&      .R?5'   "   ?? $??-6,-1q?6*   ??69   ?? *Id+$ TwoWay=?$
 true??$
 true??5(      5*      ?? 5+      -   5        nameColumn1??$
??Name??5+   :   $ 80??6H    5,      ?? 5-      .R?5.   "   ?? $??-6,-1q?6*   ??69   ?? *Name+$ TwoWay=?$
 true??$
 true??5/      51      52      54      55      56      