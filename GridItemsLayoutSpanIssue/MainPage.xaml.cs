namespace GridItemsLayoutSpanIssue
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void CollectionView_SizeChanged(object sender, EventArgs e)
        {
            CollectionView collectionView = sender as CollectionView;
            GridItemsLayout gridItemsLayout = (GridItemsLayout)collectionView.ItemsLayout;
            if (collectionView.Width < 1000)
            {
                gridItemsLayout.Span = 1;
            }
            else
            {
                gridItemsLayout.Span = 2;
            }
        }
    }

}
