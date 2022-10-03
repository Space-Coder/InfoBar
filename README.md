# InfoBar - Simple info bar in Windows 11 style
[![NuGet version](https://badge.fury.io/nu/InfoBar.svg)](https://badge.fury.io/nu/InfoBar)
____
## How to use
- Install [NuGet](https://www.nuget.org/packages/InfoBar) package in your WPF Application.
- Add this code in MainWindow.xaml.

```XML
xmlns:InfoBar="clr-namespace:InfoBar;assembly=InfoBar"
```
- Create InfoBar element and set x:Name property.

```XML
<InfoBar:InfoBarBox
            x:Name="InfoBarBox"
            Margin="0,-79,0,0"
            VerticalAlignment="Top" />
```

- For showing message call **ShowMessage()** method from InfoBar element.

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


