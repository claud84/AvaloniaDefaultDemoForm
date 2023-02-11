using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace AvaloniaDefaultDemoForm;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ToggleButton_OnChecked(object? sender, RoutedEventArgs e)
    {
        CustomTextBox.Readonly = !CustomTextBox.Readonly;
    }

    private void CustomTextBox_OnFocusChanged(object? sender, EventArgs e)
    {
        CustomTextBox.SupportingText = $"TextBox {(CustomTextBox.InnerTextBox.IsFocused?"has focus":"lost focus")}";
    }
}