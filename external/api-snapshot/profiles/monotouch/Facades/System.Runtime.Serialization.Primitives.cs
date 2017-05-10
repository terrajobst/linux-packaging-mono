// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.1.1.0")]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Xamarin, Inc.")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("Copyright (c) 2013 Xamarin Inc. (http://www.xamarin.com)")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Runtime.Serialization.Primitives.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Runtime.Serialization.Primitives.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Runtime.Serialization.Primitives.dll")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Runtime.Serialization.CollectionDataContractAttribute))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Runtime.Serialization.ContractNamespaceAttribute))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Runtime.Serialization.DataContractAttribute))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Runtime.Serialization.DataMemberAttribute))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Runtime.Serialization.EnumMemberAttribute))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Runtime.Serialization.IgnoreDataMemberAttribute))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Runtime.Serialization.InvalidDataContractException))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Runtime.Serialization.KnownTypeAttribute))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Runtime.Serialization.OnDeserializedAttribute))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Runtime.Serialization.OnDeserializingAttribute))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Runtime.Serialization.OnSerializedAttribute))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Runtime.Serialization.OnSerializingAttribute))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Runtime.Serialization.SerializationException))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Runtime.Serialization.StreamingContext))]
namespace System.Runtime.Serialization
{
    public partial interface ISerializationSurrogateProvider
    {
        object GetDeserializedObject(object obj, System.Type targetType);
        object GetObjectToSerialize(object obj, System.Type targetType);
        System.Type GetSurrogateType(System.Type type);
    }
}
