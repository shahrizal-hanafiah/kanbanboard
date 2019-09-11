using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KanbanBoardAPI.AppService.Board.dto;
using KanbanBoardAPI.AppService.Card.dto;
using KanbanBoardAPI.Models;

namespace KanbanBoardAPI.AppService.Board
{
    public class BoardAppService : IBoardAppService
    {
        private readonly KanbanBoardContext _context;
        public BoardAppService(KanbanBoardContext context)
        {
            _context = context;
        }
        public List<BoardDto> Get()
        {
            try
            {
                var boards = _context.Board
                            .Select(t=> new BoardDto
                            {
                                Id = t.Id,
                                BoardName = t.BoardName,
                                BoardType = t.BoardType,
                                CreatedAt = t.CreatedAt,
                                CreatedBy = t.CreatedBy
                            }).ToList();
                foreach (var item in boards)
                {
                    var cards = _context.Card.Where(t => t.BoardParentId == item.Id)
                                .Select(t=> new CardDto
                                {
                                    Id = t.Id,
                                    Sort = t.Sort,
                                    Summary = t.Summary,
                                    Header = t.Header,
                                    Priority = t.Priority,
                                    BoardParentId = t.BoardParentId
                                })
                                .ToList();
                    item.ListCard = cards;
                }
                return boards;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
