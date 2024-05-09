using System.Collections;

namespace MauiGroupedCollectionViewRepro;

public class ItemGroup : IEnumerable<string>
{
    private readonly string _key;
    private readonly IEnumerable<string> _items;

    public ItemGroup(string key, IEnumerable<string> items)
    {
        _key = key;
        _items = items;
    }

    public string Key => _key;

    public IEnumerator<string> GetEnumerator() => _items.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}