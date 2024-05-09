namespace MauiGroupedCollectionViewRepro;

public partial class GroupedListPage
{
    public GroupedListPage() => InitializeComponent();

    private void SimpleButton_OnClicked(object? sender, EventArgs e) => Shell.Current.GoToAsync("//SimpleCollectionPage");
    private void CollectionButton_OnClicked(object? sender, EventArgs e) => Shell.Current.GoToAsync("//GroupedCollectionPage");
}