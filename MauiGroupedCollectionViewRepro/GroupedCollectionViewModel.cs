using System.Collections.ObjectModel;

namespace MauiGroupedCollectionViewRepro;

public sealed class GroupedCollectionViewModel
{
    public GroupedCollectionViewModel() => InitializeItems();

    private void InitializeItems()
    {
        var testGroups = Enumerable.Range(1, 5)
            .Select(groupId => $"GroupId: {groupId}");

        foreach (var testGroup in testGroups)
        {
            var testItems = Enumerable.Range(1, 5)
                .Select(itemId => $"{testGroup}, ItemId: {itemId}");

            Items.Add(new ItemGroup(testGroup, testItems));
        }
    }

    public ObservableCollection<ItemGroup> Items { get; } = new();
}