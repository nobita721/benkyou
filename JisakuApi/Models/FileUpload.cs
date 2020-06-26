using System;
using System.ComponentModel.DataAnnotations;

namespace JisakuApi.Models
{
    public class FileUpload
    {
        public int Id { get; set; }
        [Display(Name = "申請番号")]
        public string ApprovalNo { get; set; }
        [Display(Name = "ファイル名")]
        public string FileName { get; set; }
        [Display(Name = "ファイルデータ")]
        public byte[] FileData { get; set; }
        [Display(Name = "更新日時")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        public DateTime  ModifiedDate { get; set; }
    }
}