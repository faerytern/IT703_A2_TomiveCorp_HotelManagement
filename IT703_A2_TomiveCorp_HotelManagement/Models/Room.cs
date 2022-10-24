﻿using System.ComponentModel.DataAnnotations;

namespace IT703_A2_TomiveCorp_HotelManagement.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

        public RoomType RoomSize { get; set; } = RoomType.Undefined;
        public RoomStatus Status { get; set; } = Room.RoomStatus.VACANT_CLEAN;
        [DataType(DataType.Currency)]
        public decimal RoomRate { get; set; }
        [DataType(DataType.Currency)]
        public decimal DefaultRoomRate { get; set; }
        public byte[] PreviewImage { get; set; }
        public List<byte[]> RoomImages { get; set; }
        public enum RoomType
        {
            Undefined, Single, Duo, Three, Family
        }
        public enum RoomStatus
        {
            VACANT_CLEAN, VACANT_DIRTY, OCCUPIED_CLEAN, OCCUPIED_SERVICE, ON_MAINTENANCE
        }

    }
}