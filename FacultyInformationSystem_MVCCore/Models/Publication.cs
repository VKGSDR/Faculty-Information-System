using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace FacultyInformationSystem_MVCCore
{
    public partial class Publication
    {
        public string PublicationId { get; set; }
        public int FacultyId { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+[\s\.\-]*[a-zA-Z\s]+$", ErrorMessage = "Please Enter Characters Value Only")]
        [Required(ErrorMessage = "Please Enter Specialization"), MaxLength(50)]
        [Display(Name = "Publication Title")]
        public string PublicationTitle { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+[\s\.\-]*[a-zA-Z\s]+$", ErrorMessage = "Please Enter Characters Value Only")]
        [Required(ErrorMessage = "Please Enter Article Name"), MaxLength(30)]
        [Display(Name = "Article Name")]
        public string ArticleName { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+[\s\.\-]*[a-zA-Z\s]+$", ErrorMessage = "Please Enter Characters Value Only")]
        [Required(ErrorMessage = "Please Enter Publisher Name"), MaxLength(50)]
        [Display(Name = "Publisher Name")]
        public string PublisherName { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+[\s\.\-]*[a-zA-Z\s]+$", ErrorMessage = "Please Enter Characters Value Only")]
        [Required(ErrorMessage = "Please Enter Publication Location"), MaxLength(50)]
        [Display(Name = "Publication Location")]
        public string PublicationLocation { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please Enter Citation Date")]
        [Display(Name = "Citation Date")]
        public DateTime CitationDate { get; set; }

        //public virtual Faculty Faculty { get; set; }
    }
}
