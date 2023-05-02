using Avalonia.Controls;

namespace Symphonica.Controls
{
    public partial class LibraryAlbumTile : UserControl
    {
        internal bool isPlaying { get; set; } = false;

        public LibraryAlbumTile()
        {
            InitializeComponent();
        }
    }
}
