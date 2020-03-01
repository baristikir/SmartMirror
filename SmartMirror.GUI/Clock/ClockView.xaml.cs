using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SmartMirror.GUI.Clock
{
    public class ClockView : UserControl
    {
        public ClockView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
