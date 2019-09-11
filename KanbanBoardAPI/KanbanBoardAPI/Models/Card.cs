using System;
using System.Collections.Generic;

namespace KanbanBoardAPI.Models
{
    public partial class Card
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Summary { get; set; }
        public int BoardParentId { get; set; }
        public int Sort { get; set; }
        public int? Priority { get; set; }

        public virtual Board IdNavigation { get; set; }
    }
}
