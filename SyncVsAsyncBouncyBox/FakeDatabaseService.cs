namespace SyncVsAsyncBouncyBox;

public class FakeDatabaseService : IDatabase
{
    private List<string> _values;
    public int Delay {  get; set; }

    public FakeDatabaseService()
    {
        Delay = 500;
        _values = new List<string>() { "A", "B", "C", "D", "E" };
    }

    public string GetSync(int index)
    {
        Thread.Sleep(Delay);
        return GetOne(index);
    }

    public async Task<string> GetSyncAsync(int index)
    {
        await Task.Delay(Delay);
        return GetOne(index);
    }

    private string GetOne(int index)
    {
        return _values[index % _values.Count];
    }
}
