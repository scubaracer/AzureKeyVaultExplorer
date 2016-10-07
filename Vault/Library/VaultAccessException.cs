﻿// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT License. See License.txt in the project root for license information. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaultLibrary
{
    using System;

    public class VaultAccessException : AggregateException
    {
        public VaultAccessException(string message, params Exception[] innerExceptions) : base(message, innerExceptions)
        {
        }
    }
}
