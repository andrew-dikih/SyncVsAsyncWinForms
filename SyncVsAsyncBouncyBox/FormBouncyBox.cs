namespace SyncVsAsyncBouncyBox;

public partial class FormBouncyBox : Form
{
    public FormBouncyBox()
    {
        InitializeComponent();
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
