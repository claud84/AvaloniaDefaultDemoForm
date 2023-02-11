using System;
using Avalonia.Controls;

namespace AvaloniaDefaultDemoForm;

public partial class CustomTextBox : UserControl
{
    public bool Readonly
    {
        get => InnerTextBox.IsReadOnly;
        set => InnerTextBox.IsReadOnly = value;
    }
    public string? Value
    {
        get => InnerTextBox.Text;
        set => InnerTextBox.Text = value;
    }

    public string? SupportingText
    {
        get => InnerTextBlock.Text;
        set => InnerTextBlock.Text = value;
    }

    public event EventHandler? FocusChanged;

    public CustomTextBox()
    {
        InitializeComponent();

        InnerTextBox.GotFocus   += (sender, args) => { FocusChanged?.Invoke(this, EventArgs.Empty); };
        InnerTextBox.LostFocus  += (sender, args) => { FocusChanged?.Invoke(this, EventArgs.Empty); };
    }
}