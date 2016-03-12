﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiki.BLL.DTO
{
    public class RecordDTO
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public DateTime Date { get; set; }

        public string Result { get; set; }

        public bool IsSuccess { get; set; }

        public bool IsDeleted { get; set; }
    }
}