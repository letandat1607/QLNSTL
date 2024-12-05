using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Doituong
{
    public class ThanhPhanLuong
    {

            [BsonId] public ObjectId Id { get; set; }
            [BsonElement("matp")] public string MaTp { get; set; }
            [BsonElement("tentp")] public string TenTp { get; set; }
            [BsonElement("donviapdung")] public string DonViApDung { get; set; }
            [BsonElement("loaitp")] public string LoaiTp { get; set; }
            [BsonElement("tinhchat")] public string TinhChat { get; set; }
            [BsonElement("kieugt")] public string KieuGt { get; set; }
            [BsonElement("giatri")] public string GiaTri { get; set; }
    }
}
