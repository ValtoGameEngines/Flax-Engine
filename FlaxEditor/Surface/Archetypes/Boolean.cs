// Copyright (c) 2012-2018 Wojciech Figat. All rights reserved.

using FlaxEngine;

namespace FlaxEditor.Surface.Archetypes
{
    /// <summary>
    /// Contains archetypes for nodes from the Boolean group.
    /// </summary>
    public static class Boolean
    {
        private static NodeArchetype Op1(ushort id, string title, string desc, string[] altTitles = null)
        {
            return new NodeArchetype
            {
                TypeID = id,
                Title = title,
                Description = desc,
                AlternativeTitles = altTitles,
                Flags = NodeFlags.AnimGraphOnly,
                Size = new Vector2(110, 20),
                Elements = new[]
                {
                    NodeElementArchetype.Factory.Input(0, "A", true, ConnectionType.Bool, 0),
                    NodeElementArchetype.Factory.Output(0, "Result", ConnectionType.Bool, 1)
                }
            };
        }

        private static NodeArchetype Op2(ushort id, string title, string desc, string[] altTitles = null)
        {
            return new NodeArchetype
            {
                TypeID = id,
                Title = title,
                Description = desc,
                AlternativeTitles = altTitles,
                Flags = NodeFlags.AnimGraphOnly,
                Size = new Vector2(110, 40),
                DefaultValues = new object[]
                {
                    false,
                    false,
                },
                Elements = new[]
                {
                    NodeElementArchetype.Factory.Input(0, "A", true, ConnectionType.Bool, 0, 0),
                    NodeElementArchetype.Factory.Input(1, "B", true, ConnectionType.Bool, 1, 1),
                    NodeElementArchetype.Factory.Output(0, "Result", ConnectionType.Bool, 2)
                }
            };
        }

        /// <summary>
        /// The nodes for that group.
        /// </summary>
        public static NodeArchetype[] Nodes =
        {
            Op1(1, "NOT", "Negates the boolean value", new[] { "!", "~" }),
            Op2(2, "AND", "Performs a logical conjunction on two values", new[] { "&&" }),
            Op2(3, "OR", "Returns true if either (or both) of its operands is true", new[] { "||" }),
            Op2(4, "XOR", ""),
            Op2(5, "NOR", ""),
            Op2(6, "NAND", ""),
        };
    }
}