using System;

namespace PRT.Domain.Entitites
{
    public class Todo
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool Done { get; set; }

        public Todo()
        {
            this.CreatedAt = DateTime.Now;
        }
    }
}
