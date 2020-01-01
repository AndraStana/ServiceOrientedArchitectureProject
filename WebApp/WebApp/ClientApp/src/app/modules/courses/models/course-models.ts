import { TeacherModel } from "src/app/shared/models/teacher-models";

export class CourseDetailsModel{
    course: CourseModel;
    teachers: TeacherModel[];


}



export class CourseModel{
    id: string;
    name: string;
}