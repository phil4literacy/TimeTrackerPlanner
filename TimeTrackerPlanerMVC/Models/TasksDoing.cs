﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TimeTrackerPlanerMVC.Models
{
    public class TasksDoing
    {
        [Key]
        public int workid { get; set; }
        public int taskid { get; set; }
        public int planid { get; set;  }
        public DateTime starttime { get; set; }
        public int duration { get; set; }
    }
}
