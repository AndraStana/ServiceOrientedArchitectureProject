import { Injectable } from "@angular/core";
import { environment } from "src/environments/environment";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { AddGradeModel } from "../models/grades-models";

Injectable()
export class GradesService{
    private baseUrl = `${environment.baseUrl}/Grades`;

    constructor(private httpClient: HttpClient) {
    }

    
    public addGrade( model: AddGradeModel): Observable<void>{
        var url = `${this.baseUrl}/AddGrade` ;
        return this.httpClient.post<void>(url, model );
    }

}