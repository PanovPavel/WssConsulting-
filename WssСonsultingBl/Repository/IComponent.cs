using WssСonsultingBl.Model;

namespace WssСonsultingBl.Repository;

public interface IComponent<T>
{
    IEnumerable<T> GetAllChildren();
    void RemoveChild(Guid childId);
    
}