namespace MauiGroupedCollectionViewRepro;

public partial class GroupedCollectionPage
{
    public GroupedCollectionPage() => InitializeComponent();

    private void SimpleButton_OnClicked(object? sender, EventArgs e) => Shell.Current.GoToAsync("//SimpleCollectionPage");
    private void ListButton_OnClicked(object? sender, EventArgs e) => Shell.Current.GoToAsync("//GroupedListPage");
}