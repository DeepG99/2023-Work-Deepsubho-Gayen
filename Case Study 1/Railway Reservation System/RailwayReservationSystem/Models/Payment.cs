using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RailwayReservationSystem.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int Amount { get; set; }
       
        public int CustomerId { get; set; }
       
        public int ReservationId { get; set; }
        
    }
}