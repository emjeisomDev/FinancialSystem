namespace Domain.Interfaces.Generics
{
    public interface GenericInterface<T> where T : class
    {
        Task Add(T Object);
        Task Updade(T Object);
        Task Delete(T Object);
        Task<T> GetEntityById(int id);
        Task<List<T>> List();
    }
}
