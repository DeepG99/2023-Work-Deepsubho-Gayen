using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RailwayReservationSystem.Models
{
    public class Train
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
       
        public string SourceStation { get; set; } = null!;

        public string DestinationStation { get; set; } = null!;

        public DateTime ArrivalDatetime { get; set; }
     
        public DateTime DepartureDatetime { get; set; }
      
        public int TotalSeats { get; set; }
    
        public int AvailableSeats { get; set; }
     
        public string Class { get; set; } = null!;

        public int Fare { get; set; }
    
    }
}