﻿using System.Collections.Generic;
using System.Xml.Linq;

namespace PuyoTextEditor.Formats
{
    public class CnvrsTextEntry
    {
        /// <summary>
        /// Gets or sets the unique 64-bit identifier.
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the font, or null.
        /// </summary>
        public string? FontName { get; set; }

        /// <summary>
        /// Gets or sets the name of the layout, or null.
        /// </summary>
        public string? LayoutName { get; set; }

        /// <summary>
        /// Gets or sets the text content.
        /// </summary>
        public XElement Text { get; set; } = default!;

        public List<CnvrsParametersEntry> Speakers { get; set; }

        public CnvrsTextEntry()
        {
            Speakers = new List<CnvrsParametersEntry>();
        }

        public CnvrsTextEntry(int entriesCapacity)
        {
            Speakers = new List<CnvrsParametersEntry>(entriesCapacity);
        }
    }
}
