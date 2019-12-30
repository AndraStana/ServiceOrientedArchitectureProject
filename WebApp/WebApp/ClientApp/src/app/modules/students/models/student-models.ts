export class StudentListModel{
    id: string;
    name: string;
    yearOfBirth : number;
    address: string;
}

export class StudentDetailsModel extends StudentListModel{
   grades: GradeModel[];
}

export class GradeModel{
    courseName: string;
    marks: number[];
}