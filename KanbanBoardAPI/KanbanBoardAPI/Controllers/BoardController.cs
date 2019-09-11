using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KanbanBoardAPI.AppService.Board;
using KanbanBoardAPI.AppService.Board.dto;
using KanbanBoardAPI.Models;
//using KanbanBoardAPI.AppService.Board;
//using KanbanBoardAPI.AppService.Board.dto;
//using KanbanBoardAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace KanbanBoardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : Controller
    {
        private readonly BoardAppService _boardApp;
        public BoardController(KanbanBoardContext context)
        {
            _boardApp = new BoardAppService(context);
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<BoardDto>> Get()
        {
            var boards = _boardApp.Get();
            return boards;
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
