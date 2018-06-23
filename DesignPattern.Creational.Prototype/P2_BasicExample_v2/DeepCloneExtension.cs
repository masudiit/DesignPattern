using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DesignPattern.Creational.Prototype.P2_BasicExample_v2
{
    public static class DeepCloneExtension
    {
        /// <summary>
        /// method to perform a deep clone of an arbitrary (unknown at the time of cloning) object
        /// </summary>
        /// <typeparam name="T">type of object being cloned</typeparam>
        /// <param name="obj">object instance being cloned</param>
        /// <returns></returns>
        public static T DoDeepClone<T>(this T obj)
        {
            //make sure the object being passed is serializable, otherwise throw an
            //exception
            if (!obj.GetType().IsSerializable)
                throw new ArgumentException("The object provided is not serializable. Please add the [Serializable()]attribute to your object", "obj");

            // check for a null object, if found the return the defaults
            // for the object
            if (obj == null)
                return default(T);
            else
            {
                BinaryFormatter bf = new BinaryFormatter();

                using (MemoryStream ms = new MemoryStream())
                {
                    bf.Serialize(ms, obj);
                    ms.Seek(0, SeekOrigin.Begin);
                    return (T)bf.Deserialize(ms);
                }
            }
        }
    }
}
