using KanbanBoardAPI.AppService.Board.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KanbanBoardAPI.AppService.Board
{
    public interface IBoardAppService
    {
        List<BoardDto> Get();
    }
}
