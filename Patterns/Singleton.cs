// <copyright file="Singleton.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Learning.DesignPatterns.Console.Patterns
{
#nullable enable
    /// <summary>
    /// Singleton summary.
    /// </summary>
    public sealed class Singleton
    {
        private static Singleton? instance;

        private Singleton()
        {
        }

        /// <summary>
        /// Gets the instance of singleton class.
        /// </summary>
        public static Singleton Instance
        {
            get
            {
                return instance ??= new Singleton();
            }
        }
    }
}
