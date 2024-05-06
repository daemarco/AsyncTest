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
            Task[] tasks = new Task[3];

            SearchProducts();

            tasks[0] = ChangePanelColor(Color.Green);
            tasks[1] = ChangePanelColor(Color.AliceBlue);
            tasks[2] = ChangePanelColor(Color.IndianRed);

            Task t = Task.WhenAll(tasks);
            try
            {
                await t;
            }
            catch { }

            if (t.Status == TaskStatus.RanToCompletion)
            {
                Console.WriteLine("All attempts succeeded.");
            }            
            else if (t.Status == TaskStatus.Faulted)
                Console.WriteLine("Attempts failed");
        }

        private async Task SearchProducts() 
        {
            pnlColors.BackColor = SystemColors.Control;
            lstResult.Items.Clear();
            txtMessage.Text = "Searching...";

            var result = await _searchEngine.Search(txtFilter.Text);

            lstResult.Items.AddRange(result.ToArray());
            txtMessage.Text = $"Found {result.Count()} items";
        }

        private async Task ChangePanelColor(Color color) 
        {
            await Task.Run(() => 
            {
                Random rnd = new();
                Thread.Sleep(rnd.Next(4, 8) * 1000);
                pnlColors.BackColor = color;
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pnlColors.BackColor = SystemColors.Control;
            txtFilter.Text = string.Empty;
            txtMessage.Text = string.Empty;
            lstResult.Items.Clear();
        }
    }
}
