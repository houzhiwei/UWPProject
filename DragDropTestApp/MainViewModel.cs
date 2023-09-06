using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace DragDropTestApp
{
	public class MainViewModel : ObservableObject
    {
        public ObservableCollection<PreviewItem> PreviewItems = new ObservableCollection<PreviewItem>();
        public MainViewModel()
        {
            for (int i = 0; i < 20; i++)
            {
                var item = new PreviewItem();
                item.ImageThumbnail = new Windows.UI.Xaml.Controls.Image();
                ImageSource result = new BitmapImage(new Uri($"ms-appx:///Assets/{i + 1}.png"));
                item.ImageThumbnail.Source = result;

                PreviewItems.Add(item);
            }
        }
    }
}
