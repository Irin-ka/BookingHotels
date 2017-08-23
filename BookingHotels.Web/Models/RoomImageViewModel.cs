﻿using System;
using BookingHotels.Domain.Enums;
using BookingHotels.Domain.Entities;

namespace BookingHotels.Web.Models
{
    public class RoomImageViewModel
    {
        public Guid Id { get; set; }
        public byte[] Image { get; set; }
        public Guid RoomId { get; set; }
        // Link to the room pictured on this image
        public virtual Room Room { get; set; }
    }
}