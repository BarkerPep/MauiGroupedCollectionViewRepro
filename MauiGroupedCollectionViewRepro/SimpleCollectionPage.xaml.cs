namespace MauiGroupedCollectionViewRepro;

public partial class SimpleCollectionPage
{
    public SimpleCollectionPage() => InitializeComponent();

    private void CollectionButton_OnClicked(object? sender, EventArgs e) => Shell.Current.GoToAsync("//GroupedCollectionPage");
    private void ListButton_OnClicked(object? sender, EventArgs e) => Shell.Current.GoToAsync("//GroupedListPage");
}