﻿using System.ComponentModel.DataAnnotations;

namespace TaskTrek.Models.DTOs
{
    public class ProjectTaskDTO
    {
        public string TaskDescription { get; set; }
        public string TaskType { get; set; }
        public string TaskStatus { get; set; }
        public string AssignedUser { get; set; }
    }
}
