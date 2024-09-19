using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransaction.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        [Column(TypeName ="nvarchar(12)")]
        [DisplayName("Broj Računa")]
        [Required(ErrorMessage="Ovo polje je obavezno !")]
        [MaxLength(12, ErrorMessage ="Maksimum 12 znakova")]
        public string AccountNumber { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Ime Klijenta")]
        [Required(ErrorMessage ="Ovo polje je obavezno !.")]
        public string BeneficiaryName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Ime Banke")]
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        public string BankName { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage ="Ovo polje je obavezno")]
        [MaxLength(11, ErrorMessage ="Maksimum 11 znakova")]
        public string SWIFTCode { get; set; }
		[DisplayName("Iznos")]
		public int Amount { get; set; }

		[DisplayName("Nadnevak")]
		[DisplayFormat(DataFormatString ="{0:MMM-dd-yy}")]
        public DateTime Date {  get; set; }
    }
}
