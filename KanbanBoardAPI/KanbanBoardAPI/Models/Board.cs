using System;
using System.Collections.Generic;

namespace KanbanBoardAPI.Models
{
    public partial class Board
    {
        public int Id { get; set; }
        public string BoardName { get; set; }
        public string BoardType { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public virtual Card Card { get; set; }
    }
}
