﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.Flights
{
    public class FlightDto
    {
        public int FlightId { get; set; }

        public string? FlightNumber { get; set; }

        public DateTime? DepartureTime { get; set; }

        public DateTime? ArrivalTime { get; set; }

        public string? DepartureAirport { get; set; }

        public string? ArrivalAirport { get; set; }

        public int? AirplaneId { get; set; }

        public int? PilotId { get; set; }
    }
}
