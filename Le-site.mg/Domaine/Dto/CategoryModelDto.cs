using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine.Dto
{
    public class CategoryModelDto
    {
        public string Id { get; set; } 
        public string CategoryName { get; set; } 
        public string Titre { get; set; }
        public string Slogan { get; set; } 
        public string Description { get; set; }
        public string Adresse { get; set; }
        public string Contact1 { get; set; }
        public string Contact2 { get; set; } 
        public string Contact3 { get; set; } 
        public bool? isGold { get; set; }
        public bool? isPremium { get; set; }
        public int? Note { get; set; }
    }
}
