namespace Core_App;

public interface IWorldMap<TNodeId, TRoadId>
    where TNodeId : struct
    where TRoadId : notnull
{
    void GetAttraction<TNodeId>(TNodeId it) where TNodeId : struct
    {
        // Implementation logic here
        Console.WriteLine($"Getting attraction for node: {it}");
    }
}

public class UseInterface<TNodeId, TRoadId> : IWorldMap<TNodeId, TRoadId>
    where TNodeId : struct
    where TRoadId : notnull
{
    public void Test(IWorldMap<TNodeId, TRoadId> map, TNodeId it)
    {
        map.GetAttraction(it);
    }
}