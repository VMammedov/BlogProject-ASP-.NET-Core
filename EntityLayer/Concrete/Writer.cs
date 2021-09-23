﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        public string WriterNickName { get; set; }
        public string WriterName { get; set; }
        public string WriterSurName { get; set; }
        public string WriterMail { get; set; }
        public byte[] WriterPasswordHash { get; set; }
        public byte[] WriterPasswordSalt { get; set; }
        public bool WriterStatus { get; set; }
    }
}
