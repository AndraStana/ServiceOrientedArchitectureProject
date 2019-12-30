import { NgModule } from "@angular/core";
import { StudentsPageComponent } from "./components/students-page/students-page.component";
import { BrowserModule } from "@angular/platform-browser";
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { AppComponent } from "src/app/app.component";
import { StudentsService } from "./services/students-service";
import { SharedModule } from "src/app/shared/shared-module";

@NgModule({
    declarations: [
      StudentsPageComponent
    ],
    imports: [
      BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
      HttpClientModule,
      FormsModule,

      SharedModule
    ],
    providers: [StudentsService],
    bootstrap: [AppComponent],
    exports: [StudentsPageComponent]
  })
  export class StudentsModule { }