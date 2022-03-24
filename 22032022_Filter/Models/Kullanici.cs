using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _22032022_Filter.Models
{
    [Table("Users")]
    public class Kullanici
    {
        [Key]
        public int ID { get; set; }

        [Required,StringLength(20)]
        public string Ad { get; set; }

        [Required, StringLength(20)]
        public string Soyad { get; set; }

        [Required, StringLength(20),DisplayName("Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }

        [Required, StringLength(20),DataType(DataType.Password)]
        public string Sifre { get; set; }
    }
}