namespace Bb
{


    public static class StaticContainer
    {

        /// <summary>
        /// Sets the instance of the specified type in the static container.
        /// </summary>
        /// <typeparam name="T">The type of the object to store in the container. Must be a reference type.</typeparam>
        /// <param name="self">The instance to store in the container. Must not be null.</param>
        /// <returns>
        /// The same instance that was passed as a parameter.
        /// </returns>
        /// <remarks>
        /// This method allows you to store a single instance of a specified type in a static container.
        /// The stored instance can later be retrieved using the <see cref="Get{T}"/> method.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Store an instance in the static container
        /// var myObject = new MyClass();
        /// StaticContainer.Set(myObject);
        /// 
        /// // Retrieve the stored instance
        /// var retrievedObject = StaticContainer.Get&lt;MyClass&gt;();
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

            private static T _instance;
            private static volatile object _lock = new object();

        }

    }

}
