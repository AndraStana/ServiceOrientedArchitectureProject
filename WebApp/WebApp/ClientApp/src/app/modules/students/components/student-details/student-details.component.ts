import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { StudentsService } from '../../services/students-service';
import { StudentDetailsModel, GradeModel } from '../../models/student-models';
import { MatDialog } from '@angular/material';
import { AddMarkDialogComponent } from '../add-mark-dialog/add-mark-dialog.component';

@Component({
  selector: 'app-student-details',
  templateUrl: './student-details.component.html',
  styleUrls: ['./student-details.component.css']
})
export class StudentDetailsComponent implements OnInit {

  public student: StudentDetailsModel;

  private studentId: string;
  public currentYear= new Date().getFullYear();


  constructor(private route: ActivatedRoute, private studentsService: StudentsService, public dialog: MatDialog) {}

  ngOnInit() {
    this.studentId = this.route.snapshot.paramMap.get('id');

    this.studentsService.getStudentDetails(this.studentId).subscribe(res =>
      {this.student = res;});
  }

  public getAverage(marks: number[]): number{
    var sum = 0;
    for( var mark of marks){
      sum+=mark;
    }

    return sum/marks.length;
  }


  public openMarkModal(grade: GradeModel): void{

    const dialogRef = this.dialog.open(AddMarkDialogComponent, {
      width: '250px',
      data: {courseName: grade.courseName}
    });

    dialogRef.afterClosed().subscribe(result => {

      console.log('The dialog was closed', result);
      // this.animal = result;
    });
  }
    

}
