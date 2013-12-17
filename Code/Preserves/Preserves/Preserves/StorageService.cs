using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preserves
{
    /// <summary>
    ///     Exposes the ability to save and read data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class StorageService<T> : Preserves.IStorageService<T> 
    {
        /// <summary>
        ///     Gets the object serialized in a file on the machine
        /// </summary>
        /// <returns></returns>
        public T Get()
        {
            // Get the File Path
            var path = GetPath();

            // Check if the file exists
            if (!System.IO.File.Exists(path))
            {
                // If the file does not exists, create a blank file
                using (File.Create(path)) { }
                return default(T);
            }

            // Get all the text out of that file
            var fileText = System.IO.File.ReadAllText(path);

            // Serialize the text to the object of choice
            var data = JsonConvert.DeserializeObject<T>(fileText);

            return data;
        }

        /// <summary>
        ///     Writes the object text file on the hard drive
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public T Set(T data)
        {
            // Get the File Path
            var path = GetPath();

            // Serialize the object
            var dataString = JsonConvert.SerializeObject(data);

            // Just write the stupid file to the disk
            System.IO.File.WriteAllText(path, dataString);

            return data;
        }

        /// <summary>
        ///     Figures out the path for the file to store the data
        /// </summary>
        /// <returns></returns>
        private string GetPath()
        {
            // Get the Current Directory
            var currentDirectory = System.IO.Directory.GetCurrentDirectory();

            // Figure out the Filename
            var className = typeof(T).ToString();
            var filename = className + ".txt";
            var path = currentDirectory + "\\" + filename;

            return path;
        }
    }
}
