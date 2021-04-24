using System.Windows.Controls;

namespace MaterialDesignDemo
{
    /// <summary>
    /// ColorTool.xaml 的交互逻辑
    /// </summary>
    public partial class ColorTool : UserControl
    {
        public ColorTool()
        {
            DataContext = new ColorToolViewModel();
            InitializeComponent();
        }
    }
}
