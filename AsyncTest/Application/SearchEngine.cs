namespace AsyncTest.Application
{
    public class SearchEngine : ISearchEngine
    {
        public SearchEngine()
        {
            
        }

        public async Task<IEnumerable<string>> Search(string searchString)
        {
            //throw new NotImplementedException("TODO-Marco");

            return new List<string> { "sdfsdf", "sfd;fkjh", "sdfljghdflkgh" };
        }
    }
}
