﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class LoanDTO
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int FarmerId { get; set; }
        public string BorrowDate { get; set; }
        public string TodDate { get; set; }
        public string Status { get; set; }
    }
}
