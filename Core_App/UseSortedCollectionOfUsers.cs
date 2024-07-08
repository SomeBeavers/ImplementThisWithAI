namespace Core_App;

public class UseSortedCollectionOfUsers
{
    public User GetUserFromCollection(SortedCollectionOfUsers collection, int index)
    {
        if (collection == null)
        {
            throw new ArgumentNullException(nameof(collection));
        }

        if (index < 0 || index >= collection[index].Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        return collection[index];
    }
}