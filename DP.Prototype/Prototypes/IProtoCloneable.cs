namespace DP.Prototype.Prototypes
{
    public interface IProtoCloneable<T>
    {
        T ShallowClone();
        T DeepClone();
    }
}
