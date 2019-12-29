import { Component, OnInit } from '@angular/core';
import { StudentsService } from '../../services/students-service';
import { StudentListModel } from '../../models/student-models';

@Component({
  selector: 'app-students-page',
  templateUrl: './students-page.component.html',
  styleUrls: ['./students-page.component.css']
})
export class StudentsPageComponent implements OnInit {

  public students: StudentListModel[];

  constructor(private studentsService: StudentsService ) { }

  ngOnInit() {
    this.studentsService.getStudents().subscribe( response =>{
      this.students = response;
    })
  }

}
