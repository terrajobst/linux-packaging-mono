﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

using Internal.TypeSystem;

namespace ILCompiler.DependencyAnalysis
{
    public class ArrayOfFrozenObjectsNode<TEmbedded> : ArrayOfEmbeddedDataNode<TEmbedded>
        where TEmbedded : EmbeddedObjectNode
    {
        public ArrayOfFrozenObjectsNode(string startSymbolMangledName, string endSymbolMangledName, IComparer<TEmbedded> nodeSorter) : base(startSymbolMangledName, endSymbolMangledName, nodeSorter)
        {
        }

        private void AlignNextObject(ref ObjectDataBuilder builder, NodeFactory factory)
        {
            builder.EmitZeros(AlignmentHelper.AlignUp(builder.CountBytes, factory.Target.PointerSize) - builder.CountBytes);
        }

        protected override void GetElementDataForNodes(ref ObjectDataBuilder builder, NodeFactory factory, bool relocsOnly)
        {
            foreach (EmbeddedObjectNode node in NodesList)
            {
                AlignNextObject(ref builder, factory);

                if (!relocsOnly)
                    node.Offset = builder.CountBytes;

                node.EncodeData(ref builder, factory, relocsOnly);
                if (node is ISymbolNode)
                {
                    builder.AddSymbol((ISymbolNode)node);
                }
            }

            // Terminate with a null pointer as expected by the GC
            AlignNextObject(ref builder, factory);
            builder.EmitZeroPointer();
        }
    }
}
