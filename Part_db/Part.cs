using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Part_db
{
    class Part
    {
        [Key]
        public int ID { get; set; }
        public string PartNumber { get; set; }      // Transcrete Part Number
        public string Description { get; set; }     // Text description of part
        public Type PartType { get; set; }          // Type can be purchased, raw, manufactured

    }

    class Type
    {
        [Key]
        public int ID { get; set; }
        public string TypeCode { get; set; }          // char code that represents the description
        public string Description { get; set; }     // Type can be purchased, raw, manufactured
    }

}
