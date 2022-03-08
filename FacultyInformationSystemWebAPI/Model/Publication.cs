using System;
using System.Collections.Generic;

#nullable disable

namespace FacultyInformationSystemWebAPI.Model
{
    public partial class Publication
    {
        public string PublicationId { get; set; }
        public int FacultyId { get; set; }
        public string PublicationTitle { get; set; }
        public string ArticleName { get; set; }
        public string PublisherName { get; set; }
        public string PublicationLocation { get; set; }
        public DateTime CitationDate { get; set; }

        public virtual Faculty Faculty { get; set; }
    }
}
