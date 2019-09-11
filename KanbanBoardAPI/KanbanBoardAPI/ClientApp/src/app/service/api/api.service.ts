import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Board } from '../../model/board/board.model'; 

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  apiURL: string = 'http://localhost:29828/api';

  constructor(private httpClient: HttpClient) {}

  public getBoards(){
    return this.httpClient.get<Board[]>(`${this.apiURL}/Board`);
}
}

