import {Component, NgModule, OnInit} from '@angular/core';
import {List, ListInterface} from '../../../model/list/list.model';
import { MovementIntf } from 'src/app/model/card/movement';
import {BoardService} from '../../../service/board/board-service';
import {BoardModel} from '../../../model/board/board.model';
import {LocalService} from '../../../service/board/local/local.service';
import { ApiService } from 'src/app/service/api/api.service';



@Component({
  selector: 'app-board',
  templateUrl: './board.component.html',
  styleUrls: ['./board.component.css'],
})
export class BoardComponent implements OnInit {


  lists: ListInterface[];

  constructor(private localService: LocalService,
              private apiService: ApiService) { }

  ngOnInit() {
    this.getBoards();
    const board = this.localService.getBoard();
    this.lists = board.list || [];

    // ideally retrive and initialize from some storage.

  }

  addList() {
    const newList: ListInterface = new List();
    newList.position = this.lists.length + 1;
    newList.name = `List #${newList.position}`;
    if (this.lists === undefined) {
      this.lists = [];
    }
    this.lists.push(newList);
    this.saveNewBoard(newList);
  }

  moveCardAcrossList(movementInformation: MovementIntf) {
    const cardMoved = this.lists[movementInformation.fromListIdx].cards.splice(movementInformation.fromCardIdx, 1);
    this.lists[movementInformation.toListIdx].cards.splice(movementInformation.toCardIdx , 0 , ...cardMoved);
  }

  saveNewBoard(newList){
    console.log(newList);
  }

  saveBoard() {
    const boardModel = new BoardModel();
    boardModel.list = this.lists;
    this.localService.saveBoard(boardModel);
    console.log(boardModel);
  }

  deleteList(listIndex: number){
      this.lists.splice(listIndex,1);
  }

  getBoards(){
    this.apiService.getBoards().subscribe((res)=>{
      console.log(res);      
    });
  }
}
