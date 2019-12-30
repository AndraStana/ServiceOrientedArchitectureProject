import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { StudentListModel, StudentDetailsModel } from "../models/student-models";
import { environment } from "src/environments/environment";

@Injectable()
export class StudentsService{
    private baseUrl = `${environment.baseUrl}/Students`;

    constructor(private httpClient: HttpClient) {
    }

    public getStudents(): Observable<StudentListModel[]> {
        var url = `${this.baseUrl}/GetStudents` ;
        return this.httpClient.get<StudentListModel[]>(url);
    }

    public getStudentDetails(id: string): Observable<StudentDetailsModel> {
        var url = `${this.baseUrl}/GetStudentDetails` ;

        var params = {
            id
        }
        return this.httpClient.get<StudentDetailsModel>(url, {params});
    }

    public deleteStudent(id: string):Observable<void>{
        var url = `${this.baseUrl}/DeleteStudent/` ;

        return this.httpClient.delete<void>(url + id );
    }

}