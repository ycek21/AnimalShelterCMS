using System;

namespace Entities.DataTransferObjects
{
    public class WalkForAnimalGet
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public bool Accepted { get; set; }
        public string UserId { get; set; }
    }
}