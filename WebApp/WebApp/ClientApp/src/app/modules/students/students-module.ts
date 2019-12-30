import { NgModule } from "@angular/core";
import { StudentsPageComponent } from "./components/students-page/students-page.component";
import { BrowserModule } from "@angular/platform-browser";
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppComponent } from "src/app/app.component";
import { StudentsService } from "./services/students-service";
import { SharedModule } from "src/app/shared/shared-module";
import { StudentDetailsComponent } from "./components/student-details/student-details.component";
import { RouterModule } from "@angular/router";
import { AddMarkDialogComponent } from "./components/add-mark-dialog/add-mark-dialog.component";

@NgModule({
    declarations: [
      StudentsPageComponent,
      StudentDetailsComponent,
      AddMarkDialogComponent
    ],
    imports: [
      BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
      HttpClientModule,
      FormsModule,
      RouterModule,

      SharedModule
    ],
    providers: [StudentsService ],
    entryComponents:[AddMarkDialogComponent],
    bootstrap: [ ],
    exports: [
      StudentsPageComponent,
      StudentDetailsComponent,
      AddMarkDialogComponent
    ]
  })
  export class StudentsModule { }