namespace AsyncTest.Application
{
    public interface ISearchEngine
    {
        Task<IEnumerable<string>> Search(string searchString);
    }
}
