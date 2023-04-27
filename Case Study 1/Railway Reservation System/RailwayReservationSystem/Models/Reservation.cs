using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RailwayReservationSystem.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int trainno { get; set; }
        public int CustomerId { get; set; }
      
        public int NoOfPeople { get; set; }
   
        public string SourceStation { get; set; } = null!;

        public string DestinationStation { get; set; } = null!;

        public DateTime DatetimeOfCreation { get; set; }
     
        public bool Status { get; set; }
        
    }
}