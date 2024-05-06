using AsyncTest.Application;

namespace AsyncTest
{
    public partial class Form1 : Form
    {
        private readonly ISearchEngine _searchEngine;

        public Form1(ISearchEngine searchEngine)
        {
            InitializeComponent();

            _searchEngine = searchEngine;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();

            var result = await _searchEngine.Search(txtFilter.Text);

            lstResult.Items.AddRange(result.ToArray());

            txtMessage.Text = $"Found {result.Count()} items";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFilter.Text = string.Empty;
            txtMessage.Text = string.Empty;
            lstResult.Items.Clear();
        }
    }
}
