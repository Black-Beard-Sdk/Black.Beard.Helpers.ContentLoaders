﻿using System;

namespace Fare
{


    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum RegExpSyntaxOptions
    {
        /// <summary>
        /// Enables intersection.
        /// </summary>
        Intersection = 0x0001,

        /// <summary>
        /// Enables complement.
        /// </summary>
        Complement = 0x0002,

        /// <summary>
        /// Enables empty language.
        /// </summary>
        Empty = 0x0004,

        /// <summary>
        /// Enables any string.
        /// </summary>
        Anystring = 0x0008,

        /// <summary>
        /// Enables named automaton.
        /// </summary>
        Automaton = 0x0010,

        /// <summary>
        /// Enables numerical intervals.
        /// </summary>
        Interval = 0x0020,

        /// <summary>
        /// Enables all optional regexp syntax.
        /// </summary>
        All = 0xffff
    }
}