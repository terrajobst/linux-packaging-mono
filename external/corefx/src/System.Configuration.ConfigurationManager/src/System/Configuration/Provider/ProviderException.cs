// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.Serialization;

namespace System.Configuration.Provider
{
    [Serializable]
#if !MONO
    [System.Runtime.CompilerServices.TypeForwardedFrom("System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
#endif
    public class ProviderException : Exception
    {
        public ProviderException() { }

        public ProviderException(string message)
            : base(message)
        { }

        public ProviderException(string message, Exception innerException)
            : base(message, innerException)
        { }

        protected ProviderException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}