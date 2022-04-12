using System.Windows;
using System.Windows.Controls;

namespace GameStore.CustomControls
{
    public class CustomText:Control
    {
        static CustomText()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomText), new FrameworkPropertyMetadata(typeof(CustomText)));
        }
    }
}