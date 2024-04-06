namespace WssСonsultingBl.Repository;

public interface IComponentChild<T> : IComponent<T>
{
    void MoveChild(Guid childId, Guid newParentId);
}