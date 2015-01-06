﻿// Copyright (c) Microsoft Open Technologies, Inc.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Runtime.InteropServices;

namespace Microsoft.VisualStudio.SymReaderInterop
{
    [
        ComImport,
        Guid("969708D2-05E5-4861-A3B0-96E473CDF63F"),
        InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
        ComVisible(false)
    ]
    internal interface ISymUnmanagedDispose
    {
        void Destroy();
    }
}
