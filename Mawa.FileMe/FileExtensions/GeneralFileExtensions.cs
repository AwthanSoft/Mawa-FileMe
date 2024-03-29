﻿using Mawa.FileMe.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mawa.FileMe.FileExtensions
{
    public class GeneralFileExtensions
    {
        public readonly FileTypeEnum FileType;
        ExtensionGroup[] ExtensionGroups;
        internal GeneralFileExtensions(FileTypeEnum FileType, ExtensionGroup[] ExtensionGroups)
        {
            this.FileType = FileType;
            this.ExtensionGroups = ExtensionGroups;
        }

        public string GetFilter(bool IncludeAllFileFilterPart = true)
        {
            return ExtensionsHelper.GeneralFileTypeToFilter(
               FileType,
                ExtensionGroups,
                IncludeAllFileFilterPart);
        }
    }
}
