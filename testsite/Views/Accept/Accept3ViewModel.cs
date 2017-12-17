using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace testsite.Views.Accept
{
    public class Accept3ViewModel
    {
        [DisplayName("TwitterID")]
        [StringLength(15, ErrorMessage = "最大15文字までです")]
        [RegularExpression(@"[0-9a-zA-Z_]+", ErrorMessage = "正しいTwitterIDではありません。")]
        public string Twitter { get; set; }

        [DisplayName("今までWACATEに来た回数")]
        [Range(0, 20,ErrorMessage = "回数は0～20までしか入れられません")]
        [Required(ErrorMessage = "{0}は必須です")]
        public int RepeatCount { get; set; }
    }
}
