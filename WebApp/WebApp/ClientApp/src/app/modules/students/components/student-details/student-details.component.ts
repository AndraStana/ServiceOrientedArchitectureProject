import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { StudentsService } from '../../services/students-service';
import { StudentDetailsModel } from '../../models/student-models';

@Component({
  selector: 'app-student-details',
  templateUrl: './student-details.component.html',
  styleUrls: ['./student-details.component.css']
})
export class StudentDetailsComponent implements OnInit {

  public student: StudentDetailsModel;

  private studentId: string;

  constructor(private route: ActivatedRoute, private studentsService: StudentsService) {}

  ngOnInit() {
    this.studentId = this.route.snapshot.paramMap.get('id');

    this.studentsService.getStudentDetails(this.studentId).subscribe(res =>
      {this.student = res;});
  }

}
