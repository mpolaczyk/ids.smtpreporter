using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ids.smtpreport
{
    public class SettingsManager
    {
        public void Save(IEntity entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity cannot be null.");
            }

            Stream stream = null;
            try
            {
                stream = File.Open(GetFileName(entity.GetType()), FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, entity);

            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }


        public T Load<T>() where T: IEntity
        {
            Stream stream = null;
            IEntity obj = null;
            try
            {
                stream = File.Open(GetFileName(typeof(T)), FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                obj = (T)formatter.Deserialize(stream);
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }

            return (T)obj;
        }

        private string GetFileName(Type type)
        {
            return type.Name;
        }
    }
}
