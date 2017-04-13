using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE
{
    public enum ContentType
    {
        [Description("image/jpeg")]
        Jpeg,
        [Description("image/tiff")]
        Tiff,
        [Description("image/gif")]
        Gif,
        [Description("image/png")]
        Png,
        [Description("application/msword")]
        MSWord,
        [Description("application/pdf")]
        PDF,
        [Description("text/plain")]
        Text
    }
    
}
