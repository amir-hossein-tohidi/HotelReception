﻿using System;
using HotelReception.DataStorage.BaseEntity;
using HotelReception.ViewModel.Enums;

namespace HotelReception.DataStorage.Entities
{
    public class ReservationModel : BaseModel<long>
    {
        public int RoomId { get; set; }

        public int StayDurationPerDay { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }


        public virtual RoomModel Room { get; set; }
    }
}