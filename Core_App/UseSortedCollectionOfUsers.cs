namespace Core_App;

public class UseSortedCollectionOfUsers
{
    public User GetUserFromCollection(SortedCollectionOfUsers collection, int index)
    {
        return collection[index];
    }
}