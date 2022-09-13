import { Component, OnInit } from '@angular/core';
import { CustomRequestService } from '../Services/custom-request.service';

@Component({
  selector: 'app-request-test',
  templateUrl: './request-test.component.html',
  styleUrls: ['./request-test.component.css']
})
export class RequestTestComponent implements OnInit {

  currentTime: any;
  todos: any;

  constructor(private CRS: CustomRequestService) { }
  
  ngOnInit(): void {}

  displayTime() 
  {
    this.CRS.getTime().subscribe(data =>
      {
      this.currentTime = data;
      this.todos = null;
      })
  }


  displayTodos()
  {
    this.CRS.GetTodos().subscribe(data =>
      {
        this.todos = data;
        this.currentTime = null;
      })
  }

}
