using RoundRobin.Core.Domain.Abstract;

namespace RoundRobin.Core.Domain
{
    public class Player : Auditable
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}