﻿using System;

namespace Narumikazuchi.Serialization
{
    /// <summary>
    /// Contains the information on a specific member of an object.
    /// </summary>
    public sealed partial class MemberState
    {
        /// <summary>
        /// Returns the value of this member as the specified type <typeparamref name="TReturn"/>.
        /// </summary>
        /// <returns>The value of this member as the specified type <typeparamref name="TReturn"/></returns>
        public TReturn? As<TReturn>() =>
            (TReturn?)this.Value;

        /// <summary>
        /// Gets the name of this member in the object.
        /// </summary>
        public String Name { get; }
        /// <summary>
        /// Gets the value of this member in the object.
        /// </summary>
        public Object? Value { get; }
        /// <summary>
        /// Gets the member type.
        /// </summary>
        public Type MemberType { get; }
    }

    // Non-Public
    partial class MemberState
    {
        internal MemberState(String name,
                            Object? value,
                            Type type)
        {
            ExceptionHelpers.ThrowIfNullOrEmpty(name);
            ExceptionHelpers.ThrowIfNull(type);

            this.Name = name;
            this.Value = value;
            this.MemberType = type;
        }
    }
}
