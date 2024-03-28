using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine.Data
{
    public class AccueilModel
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Titre { get; set; }
        public string? PlaceHolder { get; set; }
        public string? Url { get; set; }
    }
}
