# InfoBar - Simple info bar in Windows 11 style
[![NuGet version](https://badge.fury.io/nu/InfoBar.svg)](https://badge.fury.io/nu/InfoBar)
____
## How to use
- 1. Install NuGet package in your WPF Application
- 2. Add this code in MainWindow.xaml
```XML
xmlns:InfoBar="clr-namespace:InfoBar;assembly=InfoBar"
```
- 3. Create InfoBar element and set x:Name property
<InfoBar:InfoBarBox
            x:Name="InfoBarBox"
            Margin="0,-79,0,0"
            VerticalAlignment="Top" />
```XML

- 4. For showing message call **ShowMessage()** method from InfoBar element
```C#
 public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InfoBarBox.ShowMessage("Your message", InfoBarStatus.CRITICAL, InfoBarPosition.TOP);
        }
    }
}
```


