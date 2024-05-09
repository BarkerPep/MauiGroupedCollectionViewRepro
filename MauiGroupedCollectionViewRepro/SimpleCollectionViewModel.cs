using System.Collections.ObjectModel;

namespace MauiGroupedCollectionViewRepro;

public sealed class SimpleCollectionViewModel : ViewModelBase
{
    private string? _selectedItem;

    public SimpleCollectionViewModel() => InitializeItems();

    private void InitializeItems()
    {
        var testItems = Enumerable.Range(1, 25)
            .Select(itemId => $"ItemId: {itemId}");

        foreach (var testItem in testItems)
        {
            Items.Add(testItem);
        }
    }

    public ObservableCollection<string> Items { get; } = new();

    public string? SelectedItem
    {
        get => _selectedItem;
        set => SetField(ref _selectedItem, value);
    }
}