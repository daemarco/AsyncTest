
namespace AsyncTest.Infrastructure
{
    public class CatalogRepo : ICatalogRepo
    {
        private string[] _catalog =
        [
            "Picks",
            "Cables",
            "Saddles",
            "Neck",
            "Pickups",
            "Pick Guard",
            "Locking Tuners",
            "Strings",
            "Pots",
            "Strap Locks"
        ];

        public async Task<IEnumerable<string>> SearchProducts(string searchString)
        {
            Thread.Sleep(5000);

            return _catalog.Where(p => p.Contains(searchString));
        }
    }
}
