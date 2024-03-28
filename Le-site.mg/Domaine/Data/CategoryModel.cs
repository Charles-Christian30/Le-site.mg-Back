using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine.Data
{
    public class CategoryModel
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [StringLength(100)]
        public string CategoryName { get; set; } = string.Empty;

        [StringLength(100)]
        public string Titre { get; set; } = string.Empty;

        [StringLength(300)]
        public string Slogan { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Adresse { get; set; } = string.Empty;
        public string Contact1 { get; set; } = string.Empty;
        public string Contact2 { get; set; } = string.Empty;
        public string Contact3 { get; set; } = string.Empty;
        public bool? isGold { get; set; }
        public bool? isPremium { get; set; }
        public int? Note { get; set; }

    }
}
