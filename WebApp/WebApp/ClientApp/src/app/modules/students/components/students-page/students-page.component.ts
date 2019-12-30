import { Component, OnInit } from '@angular/core';
import { StudentsService } from '../../services/students-service';
import { StudentListModel } from '../../models/student-models';
import { MatDialog } from '@angular/material';
import { ConfirmationModalComponent } from 'src/app/shared/components/confirmation-modal/confirmation-modal.component';

@Component({
  selector: 'app-students-page',
  templateUrl: './students-page.component.html',
  styleUrls: ['./students-page.component.css']
})
export class StudentsPageComponent implements OnInit {

  public students: StudentListModel[];
  public currentYear= new Date().getFullYear();

  constructor(private studentsService: StudentsService, private dialog: MatDialog ) { }

  ngOnInit() {
    this.studentsService.getStudents().subscribe( response =>{
      this.students = response;
    })
  }

  public deleteStudent(studentId: string, studentName: string){

    const dialogRef = this.dialog.open(ConfirmationModalComponent, {
      width: '250px',
      data: {name: studentName}
    });

    dialogRef.afterClosed().subscribe(result => {
        if(result == true){
          this.studentsService.deleteStudent(studentId).subscribe(_=>{
            this.studentsService.getStudents().subscribe( response =>{
              this.students = response;
            });
          });
        }
    });
  }
}
