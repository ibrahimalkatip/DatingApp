using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class MemberDTOs
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string PhotoUrl { get; set; }
        public string KnownAs { get; set; }
        public DateTime Create { get; set; } = DateTime.UtcNow;
        public DateTime LastActive { get; set; } = DateTime.UtcNow;
        public string Gender { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public string Introduction { get; set; }
        public List<PhotoDTOs> Photos { get; set; } = new();

    }
}