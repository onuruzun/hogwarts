using System;

namespace hogwarts_bll.Models.Base
{
    public class Base : IBase
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}