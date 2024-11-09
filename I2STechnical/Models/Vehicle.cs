using System.ComponentModel.DataAnnotations;

namespace I2STechnical.Models
{
    public class Vehicle
    {
        public Vehicle()
        {
            RegistrationNumber = string.Empty;
            OwnerName = string.Empty;
            Brand = string.Empty;
            Address = string.Empty;
            Color = string.Empty;
            FuelType = string.Empty;
        }

        [Required(ErrorMessage = "No. Registrasi Kendaraan harus diisi.")]
        [Display(Name = "No. Registrasi Kendaraan")]
        public string RegistrationNumber { get; set; }

        [Required(ErrorMessage = "Nama Pemilik harus diisi.")]
        [Display(Name = "Nama Pemilik")]
        public string OwnerName { get; set; }

        [Required(ErrorMessage = "Merk Kendaraan harus diisi.")]
        [Display(Name = "Merk Kendaraan")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Alamat harus diisi.")]
        [Display(Name = "Alamat Pemilik Kendaraan")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Tahun Pembuatan harus diisi.")]
        [Range(1900, 2024, ErrorMessage = "Tahun harus antara 1900 dan 2024")]
        [Display(Name = "Tahun Pembuatan")]
        public int ManufactureYear { get; set; }

        [Required(ErrorMessage = "Kapasitas Silinder harus diisi.")]
        [Range(1, 10000, ErrorMessage = "Masukkan kapasitas silinder yang valid")]
        [Display(Name = "Kapasitas Silinder")]
        public int CylinderCapacity { get; set; }

        [Required(ErrorMessage = "Warna Kendaraan harus dipilih.")]
        [Display(Name = "Warna Kendaraan")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Bahan Bakar harus diisi.")]
        [Display(Name = "Bahan Bakar")]
        public string FuelType { get; set; }
    }
}