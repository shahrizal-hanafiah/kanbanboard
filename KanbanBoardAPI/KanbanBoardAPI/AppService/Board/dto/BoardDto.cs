
using KanbanBoardAPI.AppService.Card.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KanbanBoardAPI.AppService.Board.dto
{
    public class BoardDto
    {
        public int Id { get; set; }
        public string BoardName { get; set; }
        public string BoardType { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public List<CardDto> ListCard { get; set; }
    }
}
