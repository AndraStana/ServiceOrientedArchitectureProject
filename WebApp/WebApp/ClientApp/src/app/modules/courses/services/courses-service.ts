import { Injectable } from "@angular/core";
import { environment } from "src/environments/environment";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { CourseDetailsModel } from "../models/course-models";

@Injectable()
export class CoursesService{
    private baseUrl = `${environment.baseUrl}/Courses`;

    constructor(private httpClient: HttpClient) {
    }

    public getCourseDetails(id: string) : Observable<CourseDetailsModel>{
        var url = `${this.baseUrl}/GetCourseDetails` ;

        var params = {
            id
        }
        return this.httpClient.get<CourseDetailsModel>(url, {params});
    }
}