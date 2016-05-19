﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Completion;
using Microsoft.VisualStudio.Text;

namespace Microsoft.CodeAnalysis.Editor
{
    internal abstract class PresentationItem
    {
        public abstract CompletionItem Item { get; }
        public abstract bool IsSuggestionModeItem { get; }
        public abstract CompletionService CompletionService { get; }

        public abstract Task<CompletionDescription> GetDescriptionAsync(Document document, CancellationToken cancellationToken);
    }
}