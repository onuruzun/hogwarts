using System;

namespace hogwarts_bll.Models.Base
{
    public interface IBase
    {
        int Id { get; set; }
        DateTime CreatedAt { get; set; }
    }
}