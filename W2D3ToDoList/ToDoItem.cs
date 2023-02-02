﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D3ToDoList
{

    internal class ToDoItem
    {
        public DateTime Created { get; set; } //Time created
        public DateTime Deadline { get; set; } //Deadline for doing
        public bool IsDone { get; set; } //Is it done?
        public bool IsFavorite { get; set; } //When list of Todo items is shown, favorites should be on top
        public string Todo { get; set; } // What to do
        public long Repeat { get; set; } //If repeat > 0 then repeat is on. long is datetime ticks
    }
}
