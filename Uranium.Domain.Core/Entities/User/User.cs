using Microsoft.AspNetCore.Identity;

namespace Uranium.Domain.Core.Entities.User
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateBlocked { get; set; }

        public bool IsBlocked => DateBlocked != null;

        public DateTime DateCreated { get; private set; }
        public string Address { get; private set; }

        public string GetFullName() => $"{LastName} {FirstName}";

        public User(string email, string firstName, string lastName, DateTime? dateBlocked, DateTime dateCreated, string address) {
            UserName = email;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            DateBlocked = dateBlocked;
            DateCreated = dateCreated;
            Address = address;
        }
    }

    public enum Role
    {
        Superuser,
        Admin,
        Moderator,
        User
    }
}
