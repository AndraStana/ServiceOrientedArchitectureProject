import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { StudentListModel } from "../models/student-models";
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
}