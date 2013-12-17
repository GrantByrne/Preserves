using System;
namespace Preserves
{
    /// <summary>
    ///     Exposes the ability to save and read data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IStorageService<T>
    {
        /// <summary>
        ///     Gets the object serialized in a file on the machine
        /// </summary>
        /// <returns></returns>
        T Get();

        /// <summary>
        ///     Writes the object text file on the hard drive
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        T Set(T data);
    }
}
