﻿using dentist;

namespace Dentist
{
    public class Patient
    {
       public string Id { get; set; }
       public string Name { get; set; }
       public DateTime DateBorn { get; set; }
       public int Age { get; set; }
        public bool Status { get; set; }

        public turn turn { get; set; }

        public int IdTurn { get; set; }
        
    }
}
