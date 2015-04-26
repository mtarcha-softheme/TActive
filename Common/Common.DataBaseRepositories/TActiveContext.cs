﻿// // <copyright company="Tarcha & Ivchenko Company">
// //      Copyright (c) 2015, All Right Reserved
// // </copyright>
// // <author>Ivan Ivchenko</author>
// // <author>Myroslava Tarcha</author>

using System.Data.Entity;
using Common.DataContracts;

namespace DataBaseRepositories
{
    /// <summary>
    /// Represents here an entities that can be queried from the database, of a given type.
    /// Register here classes that you want to map to/from your real data base.
    /// </summary>
    public class TActiveContext : DbContext
    {
        /// <summary>
        /// Gets or sets all user in the system.
        /// </summary>
        public DbSet<User> Users { get; set; }
    }
}