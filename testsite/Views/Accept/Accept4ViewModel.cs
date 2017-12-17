using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace testsite.Views.Accept
{
    public class Accept4ViewModel
    {
        [DisplayName("BLACKWACATEへの連絡事項（アレルギー等）")]
        [StringLength(500, ErrorMessage = "最大500文字までです")]
        public string Issue { get; set; }

        [DisplayName("最後に一言")]
        [StringLength(500, ErrorMessage = "最大500文字までです")]
        public string UserNotes { get; set; }
    }
}
