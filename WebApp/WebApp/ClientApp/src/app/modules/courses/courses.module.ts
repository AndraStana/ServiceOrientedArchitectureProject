import { CourseDetailsComponent } from "./components/course-details/course-details.component";
import { BrowserModule } from "@angular/platform-browser";
import { HttpClientModule } from "@angular/common/http";
import { FormsModule } from "@angular/forms";
import { RouterModule } from "@angular/router";
import { SharedModule } from "src/app/shared/shared.module";
import { CoursesService } from "./services/courses-service";
import { NgModule } from "@angular/core";

@NgModule({
    declarations: [
        CourseDetailsComponent
    ],
    imports: [
      BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
      HttpClientModule,
      FormsModule,
      RouterModule,

      SharedModule
    ],
    providers: [CoursesService ],
    bootstrap: [ ],
    exports: [
     CourseDetailsComponent
    ]
  })
  export class CoursesModule { }