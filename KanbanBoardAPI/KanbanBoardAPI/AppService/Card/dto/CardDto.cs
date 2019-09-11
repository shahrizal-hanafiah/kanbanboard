using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KanbanBoardAPI.AppService.Card.dto
{
    public class CardDto
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Summary { get; set; }
        public int BoardParentId { get; set; }
        public int Sort { get; set; }
        public int? Priority { get; set; }
    }
}
