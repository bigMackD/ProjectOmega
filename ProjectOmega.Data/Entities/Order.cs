﻿using System.ComponentModel.DataAnnotations;

namespace ProjectOmega.Data.Entities
{
    public class Order
    {
        [Key]
        public long OrderId { get; set; }

        public string Number { get; set; }

        public long ClientId { get; set; }
        public long StatusId { get; set; }

        public long UserAddedId { get; set; }
        public long UserResponsibleId { get; set; }
        public long UserInvoiceId { get; set; }
    }
}
