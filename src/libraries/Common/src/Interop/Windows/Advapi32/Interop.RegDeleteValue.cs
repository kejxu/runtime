// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if REGISTRY_ASSEMBLY
using Microsoft.Win32.SafeHandles;
#else
using Internal.Win32.SafeHandles;
#endif
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Advapi32
    {
        [GeneratedDllImport(Libraries.Advapi32, EntryPoint = "RegDeleteValueW", StringMarshalling = StringMarshalling.Utf16)]
        internal static partial int RegDeleteValue(
            SafeRegistryHandle hKey,
            string? lpValueName);
    }
}
