using System;

namespace Bb
{

    public static class StaticThreadContainer
    {

        /// <summary>
        /// Sets the instance of the specified type in the thread-local static container.
        /// </summary>
        /// <typeparam name="T">The type of the object to store in the container. Must be a reference type.</typeparam>
        /// <param name="self">The instance to store in the container. Must not be null.</param>
        /// <returns>
        /// The same instance that was passed as a parameter.
        /// </returns>
        /// <remarks>
        /// This method allows you to store a single instance of a specified type in a thread-local static container.
        /// Each thread will have its own instance of the object.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Store an instance in the thread-local static container
        /// var myObject = new MyClass();
        /// StaticThreadContainer.Set(myObject);
        /// 
        /// // Retrieve the stored instance
        /// var retrievedObject = StaticThreadContainer.Get&lt;MyClass&gt;();
        /// Console.WriteLine(retrievedObject == myObject); // Outputs: True
        /// </code>
        /// </example>
        public static T Set<T>(T self)
            where T : class
        {
            Container<T>.Instance = self;
            return self;
        }

        public static T Get<T>() where T : class => Container<T>.Instance;

        private class Container<T> where T : class
        {

            public static T Instance
            {
                get => _instance;
                set
                {
                    lock (_lock)
                        _instance = value;
                }
            }

            [ThreadStatic]
            private static T _instance;
            private static volatile object _lock = new object();

        }

    }

}
