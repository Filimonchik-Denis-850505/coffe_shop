namespace NLayerApp.DAL.Model.Base
{
    public class BaseEntity<T> : IEntity<T>
    {
        public T Id { get; }
    }
}