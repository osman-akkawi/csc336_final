﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.Revservations
{
    public class ReservationDto
    {
        public int ReservationId { get; set; }

        public int? FlightId { get; set; }

        public int? PassengerId { get; set; }

        public string? SeatNumber { get; set; }

        public DateTime? ReservationDate { get; set; }
    }
}
