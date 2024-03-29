﻿using System;

namespace Atom.Core.Attributes.Property
{
    [AttributeUsage(AttributeTargets.Property)]
    public class LengthTypeAttribute : Attribute
    {
        public Type TypeLen { get; }
        public bool IsCustomVar { get; }

        public LengthTypeAttribute(Type typeLen, bool isCustomVar = false)
        {
            TypeLen = typeLen;
            IsCustomVar = isCustomVar;
        }
    }
}
