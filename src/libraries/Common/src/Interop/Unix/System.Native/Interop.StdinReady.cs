// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Sys
    {
        [GeneratedDllImport(Libraries.SystemNative, EntryPoint = "SystemNative_StdinReady")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static partial bool StdinReady();
    }
}
