﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RailwayReservationSystem.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public int Age { get; set; }

        public string Gender { get; set; } = null!;
    
        public string Password { get; set; } = null!;
  
        public string Email { get; set; } = null!;
      
    }
}
