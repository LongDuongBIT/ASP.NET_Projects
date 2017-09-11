namespace SampleArch.Model
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}