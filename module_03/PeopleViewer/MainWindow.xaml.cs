using PersonRepository.Interface;
using System.Windows;
using PersonRepository.CSV;
using PersonRepository.Service;
using PersonRepository.SQL;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ServiceFetchButton_Click(object sender, RoutedEventArgs e)
        {
            IPersonRepository repository = new ServiceRepository();
            PopulateListBox(repository);
        }

        private void CSVFetchButton_Click(object sender, RoutedEventArgs e)
        {
            IPersonRepository repository = new CSVRepository();
            PopulateListBox(repository);
        }

        private void SQLFetchButton_Click(object sender, RoutedEventArgs e)
        {
            IPersonRepository repository = new SQLRepository();
            PopulateListBox(repository);
        }

        private void PopulateListBox(IPersonRepository repository)
        {
            ClearListBox();

            var people = repository.GetPeople();
            foreach (var person in people)
            {
                PersonListBox.Items.Add(person);
            }

            ShowRepositoryType(repository);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            PersonListBox.Items.Clear();
            RepositoryTypeTextBlock.Text = string.Empty;
        }

        private void ShowRepositoryType(IPersonRepository repository)
        {
            RepositoryTypeTextBlock.Text = repository.GetType().ToString();
        }
    }
}
