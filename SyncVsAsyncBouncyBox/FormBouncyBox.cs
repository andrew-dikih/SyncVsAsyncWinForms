namespace SyncVsAsyncBouncyBox;

public partial class FormBouncyBox : Form
{
    private readonly IDatabase _database;

    public FormBouncyBox(IDatabase database)
    {
        InitializeComponent();
        _database = database;
    }

    private void butSync_Click(object sender, EventArgs e)
    {

    }

    private void butAsync_Click(object sender, EventArgs e)
    {

    }

    private void FormBouncyBox_Shown(object sender, EventArgs e)
    {
        bouncyBox.Start();
    }
}
