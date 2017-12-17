using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace testsite.Views.Accept
{
    public class Accept1ViewModel
    {
        [DisplayName("氏名")]
        [Required(ErrorMessage = "{0}は必須です")]
        [StringLength(200,ErrorMessage = "最大200文字までです")]
        public string Name { get; set; }

        [DisplayName("氏名カナ")]
        [Required(ErrorMessage = "{0}は必須です")]
        [RegularExpression(@"[ァ-ンｧ-ﾝﾞﾟ　 ]+", ErrorMessage = "カタカナ・スペースのみ入力できます。")]
        [StringLength(200, ErrorMessage = "最大200文字までです")]
        public string NameKana { get; set; }

        [DisplayName("メールアドレス")]
        [EmailAddress(ErrorMessage = "正しいメールアドレスではありません。")]
        [Required(ErrorMessage = "{0}は必須です")]
        public string MailAddress { get; set; }

        [DisplayName("郵便番号")]
        [RegularExpression(@"\d{3}-\d{4}", ErrorMessage = "正しい郵便番号ではありません。")]
        [Required(ErrorMessage = "{0}は必須です")]
        public string PostNo { get; set; }

        [DisplayName("住所1")]
        [Required(ErrorMessage = "{0}は必須です")]
        [StringLength(255, ErrorMessage = "最大255文字までです")]
        public string Address1 { get; set; }

        [DisplayName("住所2")]
        [StringLength(255,ErrorMessage = "最大255文字までです")]
        public string Address2 { get; set; }

        [DisplayName("誕生日")]
        [DisplayFormat(DataFormatString="{0:yyyy年MM月dd日}")]
        [Required(ErrorMessage = "{0}は必須です")]
        [DataType(DataType.Date,ErrorMessage = "不正な形式です")]
        public DateTime? BirthDay { get; set; }
    }
}
