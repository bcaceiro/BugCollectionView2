namespace BugCollectionView
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        List<string>  list = new List<string>();
        public MainPage()
        {
            InitializeComponent();
            list.Add("a");
            list.Add("a");
            list.Add("a");
            list.Add("a");
            collection.ItemsSource = list;
        }

        void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string previous = (e.PreviousSelection.FirstOrDefault() as string);
            string current = (e.CurrentSelection.FirstOrDefault() as string);
        }

    }



}
