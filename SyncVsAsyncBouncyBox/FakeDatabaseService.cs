namespace SyncVsAsyncBouncyBox;

public class FakeDatabaseService : IDatabase
{
    private List<string> _values;
    public int _delay {  get; set; }

    public FakeDatabaseService()
    {
        _delay = 500;
        _values = new List<string>() { "A", "B", "C", "D", "E" };
    }

    public string GetSync(int index)
    {
        Thread.Sleep(_delay);
        return GetOne(index);
    }

    public async Task<string> GetSyncAsync(int index)
    {
        await Task.Delay(_delay);
        return GetOne(index);
    }

    private string GetOne(int index)
    {
        return _values[index % _values.Count];
    }
}
