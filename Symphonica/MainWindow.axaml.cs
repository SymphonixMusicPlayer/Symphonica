using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Platform;

namespace Symphonica
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            // Charger une image à partir des ressources empaquetées
            var image = new Bitmap("avares://MyApp/Assets/image.png");

            // Afficher l'image dans un contrôle Image
            var imageView = new Image();
            imageView.Source = image;

            // Ajouter l'image à un conteneur
            // ...
        }

        private void OnSidePanelItemSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems?.Count > 0)
            {
                var selectedItem = e.AddedItems[0];

                if (selectedItem == HomeListItem) 
                {
                    ContentArea.Content = new HomePage();
                }
                else if (selectedItem == LibraryListItem)
                {

                    ContentArea.Content = new LibraryPage();
                }
                else if (selectedItem == PlaylistsListItem)
                {
                    ContentArea.Content = new PlaylistsPage();
                }
                else if (selectedItem == PluginsListItem)
                {
                    ContentArea.Content = new PluginsPage();
                }
                else if (selectedItem == SettingsListItem)
                {
                    ContentArea.Content = new SettingsPage();
                }

            }
        }
    }
}