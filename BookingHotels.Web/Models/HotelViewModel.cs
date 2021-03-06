﻿using BookingHotels.Domain.Entities;
using BookingHotels.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookingHotels.Web.Models
{
    public class HotelViewModel
    {
        public Guid Id { get; set; }
        [Display(Name = "Hotel Name")]
        public string HotelName { get; set; }
        [Display(Name = "Hotel Stars")]
        public HotelStars HotelStars { get; set; }
        // Link to rooms collection
        public virtual List<Room> Rooms { get; set; }
    }
}