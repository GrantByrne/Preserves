Preserves
=========

Saving Your Tasty Data for Later

Introduction
------------

Preserves offer a no nonsense way of persisting data to disk. Perserves doesn't do complex data access. Just send it data, it will save it for you.

**Advantages**
- It's quick to get started
  - Preserves allows you to get started in about 10 minutes. After all, you have better things to worry about.
- It's mockable
	- Preserves is built with best practices in mind. The framework has a mockable interface wrapping the usable functionality to make it integrate seemlessly with unit tests.
- It encourages abstraction
	- Preserves doesn't encourage abstract data manipulation. As a result, feel free to abstract it as far back as you want. All it does is saves and reads data.

**Disadvantages**
- Not great for large amounts of data
  - Perserves doesn't have a quering mechanism to efficiently work with large sets of data. It's best to have an in memory version of the persisted data and just perform writes on updates.
- No querying mechanism
  - Preserves is just designed for quick and easy data persistance. No fancy stuff folks.

**Supported Frameworks**
- Currently, Preserves only works with .NET v4.5. Sorry, :/


Getting Started Guide
---------------------

**Getting a Hold of It**

You can get the API off of NuGet [**Here**](https://www.nuget.org/packages/Preserves/)

**Basic Storage**

    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello World\n";
            
            // Persist some data
            var storageService = new StorageService<string>();
            storageService.Set(hello);

            // Retrieve Peristed data
            var retrievedData =  storageService.Get();

            Console.WriteLine(retrievedData);
            Console.ReadLine();
        }
    }

Issues/Feature Requests
-----------------------

Please add an entry to the issues section of the Repository. I would like to continue developing this API in way that is useful to other people.
