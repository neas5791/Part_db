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

        public void addPart(Part p)
        {
            using (PartContext _db = new PartContext())
            {
                _db.Parts.Add(p);
                _db.Dispose();
            }
        }

        public void addPart(List<Part> p)
        {
            using (PartContext _db = new PartContext())
            {
                foreach (var part in p)
                {
                    _db.Parts.Add(part);
                }

                _db.Dispose();
            }
        }
    }

    class Type
    {
        [Key]
        public int ID { get; set; }
        public string TypeCode { get; set; }          // char code that represents the description
        public string Description { get; set; }     // Type can be purchased, raw, manufactured

        public void addType(Type t)
        {
            using (PartContext _db = new PartContext())
            {
                _db.Type.Add(t);
                _db.Dispose();
            }
        }

        public void addType(List<Type> t)
        {
            using (PartContext _db = new PartContext())
            {
                foreach (var type in t)
                {
                    _db.Type.Add(type);
                }

                _db.Dispose();
            }
        }
    }
}
