﻿using Dentist;
using Dentist.Core.Entities;

namespace dentist
{
    public class turn
    {
        public int Id { get; set; }
        public string IdPatient { get; set; }
        public string IdDentist { get; set; }
        public DateTime Date { get; set; }
        public DateTime Hour { get; set; }

        public Patient patient { get; set; }

        public Doctors doctors { get; set; }
    }
}
