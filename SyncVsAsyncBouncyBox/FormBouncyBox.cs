namespace SyncVsAsyncBouncyBox;

public partial class FormBouncyBox : Form
{
    private readonly IDatabase _database;
    private SyncState _syncState;

    public FormBouncyBox(IDatabase database)
    {
        InitializeComponent();
        _database = database;
        bouncyBox.Interval = (int)dbInterval.Value;
        bouncyBox.OnTick += BouncyBox_OnTick;
    }

    private void FormBouncyBox_Shown(object sender, EventArgs e)
    {
        WireButtons();
        bouncyBox.Start();
    }

    private void butSync_Click(object sender, EventArgs e)
    {
        Toggle(SyncState.Sync);
        WireButtons();
    }

    private void butAsync_Click(object sender, EventArgs e)
    {
        Toggle(SyncState.Async);
        WireButtons();
    }

    private void Toggle(SyncState syncState)
    {
        if (_syncState == syncState)
        {
            _syncState = SyncState.None;
        }
        else
        {
            _syncState = syncState;
        }
    }

    private void WireButtons()
    {
        Color enabled = Color.Green;
        Color disabled = Color.White;
        butAsync.BackColor = _syncState == SyncState.Async ? enabled : disabled;
        butSync.BackColor = _syncState == SyncState.Sync ? enabled : disabled;
    }

    private async void BouncyBox_OnTick(BouncyBox bouncyBox,double elapsed)
    {
        string value = "";
        bouncyBox.BackColor = Color.Red;
        if (_syncState==SyncState.Async)
        {
            value = await _database.GetSyncAsync((int)elapsed);
        }
        else if (_syncState==SyncState.Sync)
        {
            Application.DoEvents();
            value=_database.GetSync((int)elapsed);
        }
        bouncyBox.BackColor = Color.White;
        bouncyBox.CustomText = value;
    }

    public enum SyncState
    {
        None,
        Sync,
        Async,
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
        bouncyBox.Interval = (int)dbInterval.Value;
        bouncyBox.Reset();
    }

    private void dbDelay_ValueChanged(object sender, EventArgs e)
    {
        if(_database is FakeDatabaseService fakeDatabaseService)
        {
            fakeDatabaseService.Delay = (int)dbDelay.Value;
            bouncyBox.Reset();
        }
    }
}
