using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RWMVC.Models
{
    public class SecureUpload
    {
        /// <summary>
        /// The ResWare File Number
        /// </summary>
        [Required]
        public string FileNumber;
        /// <summary>
        /// Represents the document chosen by the user
        /// </summary>
        [Required]
        public Document chosenDocument;
        /// <summary>
        /// int representing the type of document uploaded by the user
        /// </summary>
        public int docType;
    }
}
