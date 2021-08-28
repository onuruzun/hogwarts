using System;

namespace hogwarts_repository.Models.Base
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime CreatedAt { get; set; }
    }
}