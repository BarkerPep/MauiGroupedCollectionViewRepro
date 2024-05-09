namespace MauiGroupedCollectionViewRepro;

public partial class GroupedCollectionPage
{
    public GroupedCollectionPage() => InitializeComponent();

    private void Button_OnClicked(object? sender, EventArgs e) => Shell.Current.GoToAsync("//SimpleCollectionPage");
}