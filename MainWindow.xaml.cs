using System.Collections.ObjectModel;
using System.Numerics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog122_S24_L12_ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Character> characterNames = new List<Character>();

        public MainWindow()
        {
            InitializeComponent();


            // We've changed our List<string> to List<Character> and populated it with 3 new characters
            // We have only added our player names so far
            characterNames.Add(new Character("Will", "McDurken", 14, 9));
            characterNames.Add(new Character("Rafael", "Ragavan Quicksmith", 18, 16));
            characterNames.Add(new Character("Charles", "Conan", 10, 17));

            lvCharacters.ItemsSource = characterNames;

        } // MainWindow()

        private void btnDisplayInfo_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = lvCharacters.SelectedIndex;

            if(lvCharacters.SelectedIndex != -1)
            {
                //Character selectedCharacter = (Character)lvCharacters.SelectedValue;
                Character selectedCharacter = lvCharacters.SelectedValue as Character;

                MessageBox.Show(selectedCharacter.PlayerName);

            }
            else
            {
                MessageBox.Show("Select a row from the list view");
            }

        }
    } // class

} // namespace