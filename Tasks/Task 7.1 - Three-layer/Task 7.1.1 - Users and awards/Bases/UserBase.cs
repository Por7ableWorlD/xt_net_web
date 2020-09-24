using System;

namespace Bases
{
    public class UserBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public override string ToString() => string.Format("Name: {0}; Birthday: {1:M}.", Name, DateOfBirth);
    }
}