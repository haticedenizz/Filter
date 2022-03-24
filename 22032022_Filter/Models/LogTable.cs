using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _22032022_Filter.Models
{
    [Table("Logs")]
    public class LogTable
    {
        [Key]
        public int ID { get; set; }

        [Required,DisplayName("İşlem Tarihi")]
        public DateTime Tarih { get; set; }

        [Required,StringLength(25),DisplayName("Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }

        [StringLength(100)]
        public string ActionName { get; set; }

        [StringLength(100)]
        public string ControllerName { get; set; }

        [StringLength(200)]
        public string Bilgi { get; set; }
    }
}