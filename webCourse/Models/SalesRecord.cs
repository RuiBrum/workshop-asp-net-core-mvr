﻿using System;
using webCourse.Models.Enums;

namespace webCourse.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesStatus Status { get; set; }
        public Seller Seller { get; set; }
        public SalesRecord() {}

        public SalesRecord(int id, DateTime date, double amount, SalesStatus status)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
        }
    }
}
