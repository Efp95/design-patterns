using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DP.Prototype.Prototypes
{
    [Serializable]
    public abstract class BaseProtoCloneable<T> : IProtoCloneable<T>
    {
        public virtual T DeepClone()
        {
            using (var mStream = new MemoryStream())
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(mStream, this);

                mStream.Position = default(int);

                return (T)binaryFormatter.Deserialize(mStream);
            }
        }

        public virtual T ShallowClone()
        {
            return (T)this.MemberwiseClone();
        }
    }
}
