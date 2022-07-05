using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace DragDropTestApp
{
	public class PreviewItem : ObservableObject
    {
        private Image _imageThumbnail;
        public Image ImageThumbnail { get => _imageThumbnail; set => SetProperty(ref _imageThumbnail, value); }


        public PreviewItem()
        {

        }

    }
}
