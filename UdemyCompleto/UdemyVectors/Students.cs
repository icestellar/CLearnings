using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyVectors
{
    class Students
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public short Room { get; set; }
        public bool IfOcupped { get; private set; } = false;

        public Students(string name, string email, short room)
        {
            Name = name;
            Email = email;
            Room = room;
        }

        public override string ToString()
        {
            return $"Nome: {Name}\nEmail: {Email}\nRoom: {Room}";
        }

    }
}
