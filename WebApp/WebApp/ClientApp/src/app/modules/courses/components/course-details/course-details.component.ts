import { Component, OnInit } from '@angular/core';
import { CoursesService } from '../../services/courses-service';
import { CourseDetailsModel } from '../../models/course-models';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-course-details',
  templateUrl: './course-details.component.html',
  styleUrls: ['./course-details.component.css']
})
export class CourseDetailsComponent implements OnInit {


  public course: CourseDetailsModel;
  public currentYear= new Date().getFullYear();
  private courseId:  string;

  constructor(private route: ActivatedRoute, private coursesService: CoursesService) { }

  ngOnInit() {
    this.courseId = this.route.snapshot.paramMap.get('id');

    this.coursesService.getCourseDetails(this.courseId).subscribe(res =>{
      this.course = res;
    });
  }
}
