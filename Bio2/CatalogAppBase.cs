using Data.InMemory.Interfaces;
using Extensions.Model.Implementation;

namespace Bio2
{
    public class CatalogAppBase<T> : FilePersistableCatalogWithoutTransformationAsync<T>
        where T : class, IStorable, ICopyable, new()
    {
    }
}