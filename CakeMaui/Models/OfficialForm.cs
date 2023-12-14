using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeMaui.Models
{
    public class OfficialForm
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nama_calon_pengantin_pria { get; set; }
        public string Nohp_calon_pengantin_pria { get; set; }
        public string Nama_calon_pengantin_wanita { get; set; }
        public string Nohp_calon_pengantin_wanita { get; set; }
        public DateTime Tanggal_acara { get; set; }
        public TimeSpan Jam_acara { get; set;}
        public string Lokasi { get; set; }
        public string Model_cake { get; set; }
        public string Kue_suapan { get; set; }
        public string kue_family_10x10 { get; set; }
        public int Mingle { get; set; }
        public string Keterangan { get; set; }
        public bool Done { get; set; }
    }
}
