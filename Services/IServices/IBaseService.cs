using DbObjects;

namespace Services;

public interface IBaseService<T>
{
    Guid Create(T entity);

    bool Delete(Guid id);

    bool Update(T entity);

    List<T> Get();

    T? Get(Guid id);
}