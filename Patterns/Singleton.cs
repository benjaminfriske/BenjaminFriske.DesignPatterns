// <copyright file="Singleton.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;

namespace Learning.DesignPatterns.Console.Patterns
{
#nullable enable

    /// <summary>
    /// Singleton lock approach.
    /// </summary>
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        static Singleton()
        {
        }

        /// <summary>
        /// Gets the instance of singleton class.
        /// </summary>
        public static Singleton Instance
        {
            get
            {
                return Nested.Instance;
            }
        }

        private class Nested
        {
            internal static readonly Singleton Instance = new Singleton();

            static Nested()
            {
            }
        }
    }

    /// <summary>
    /// Singleton lazy approach.
    /// </summary>
    public sealed class SingletonLazy
    {
        /// <summary>
        /// This is document.
        /// </summary>
        public static readonly Lazy<SingletonLazy> instance = new Lazy<SingletonLazy>(() => new SingletonLazy());

        private SingletonLazy()
        {
        }

        /// <summary>
        /// Gets the instance of singleton class.
        /// </summary>
        public static SingletonLazy Instance
        {
            get
            {
                return instance.Value;
            }
        }
    }

    /// <summary>
    /// Singleton lock approach.
    /// </summary>
    public sealed class SingletonLock
    {
        private static readonly object PadLock = new object();
        private static SingletonLock? instance;

        private SingletonLock()
        {
        }

        /// <summary>
        /// Gets the instance of singleton class.
        /// </summary>
        public static SingletonLock Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (PadLock)
                    {
                        return instance ??= new SingletonLock();
                    }
                }
                else
                {
                    return instance;
                }
            }
        }
    }
}
