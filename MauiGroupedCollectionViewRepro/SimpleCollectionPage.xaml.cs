namespace MauiGroupedCollectionViewRepro;

public partial class SimpleCollectionPage
{
    public SimpleCollectionPage() => InitializeComponent();

    private void Button_OnClicked(object? sender, EventArgs e) => Shell.Current.GoToAsync("//GroupedCollectionPage");
}