using System;

namespace Academ.io.Models
{
    public class Favourite
    {
        public int FavouriteId { get; set; }
        public FavouriteType FavouriteType { get; set; }
        public Guid FavouriteGuid { get; set; }
    }

    public enum FavouriteType
    {
        Faculty,
        Department, 
        Group,
        Student
    }
}