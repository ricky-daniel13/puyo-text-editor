using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuyoTextEditor.Formats
{
    public class CnvrsSpeakerEntry
    {
        /// <summary>
        /// Gets or sets the unknown 64 bit value.
        /// </summary>
        public ulong Unknown { get; set; }

        /// <summary>
        /// Gets or sets the name of the font, or null.
        /// </summary>
        public string Name { get; set; } = "";
        public string Type { get; set; } = "";
    }
}
