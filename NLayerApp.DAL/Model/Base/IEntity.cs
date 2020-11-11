namespace NLayerApp.DAL.Model.Base
{
    public interface IEntity<out TKey>
    {
        TKey Id { get; }
    }
}
