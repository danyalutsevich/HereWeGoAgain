using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using HTMLConverter;
using System.Net;
using System.Windows.Markup;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DocReader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<RecipeItem> recipes = new List<RecipeItem>();
        
        private void FlowDocumentReader_Loaded(object sender, RoutedEventArgs e)
        {
            //recipes.Add(new RecipeItem { Name = "fasd", Image = "asdas", Ingridients = "12e12e", Steps = "adsdasd" });
            //recipes.Add(new RecipeItem { Name = "asda", Image = "ar3fd2w", Ingridients = "12sdfase", Steps = "adsdasasdasdad" });

            //using (StreamWriter sw = new StreamWriter("recipes.json"))
            //{
            //    sw.Write(JsonSerializer.Serialize(recipes));
            //}

            using(var sr = new StreamReader("recipes.json"))
            {
                recipes = JsonSerializer.Deserialize<List<RecipeItem>>(sr.ReadToEnd());
            }

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            image.Source = new BitmapImage(new Uri(recipes[Recipies.SelectedIndex].Image));
            var fd = new FlowDocument();
            fd.Blocks.Add(new Paragraph(new Run(recipes[Recipies.SelectedIndex].Name)));
            fd.Blocks.Add(new Paragraph(new Run(recipes[Recipies.SelectedIndex].Ingridients)));
            fd.Blocks.Add(new Paragraph(new Run(recipes[Recipies.SelectedIndex].Steps)));
            Document.Document = fd;
        }
    }
}
