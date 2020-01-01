import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Router } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { StudentsPageComponent } from './modules/students/components/students-page/students-page.component';
import { StudentsModule } from './modules/students/students.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { StudentDetailsComponent } from './modules/students/components/student-details/student-details.component';
import { CourseDetailsComponent } from './modules/courses/components/course-details/course-details.component';
import { CoursesModule } from './modules/courses/courses.module';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule,

    StudentsModule,
    CoursesModule,

    // RouterModule.forRoot([])
    // RouterModule.forRoot([
    //   { path: '', component: HomeComponent, pathMatch: 'full' },
    //   { path: 'counter', component: CounterComponent },
    //   { path: 'fetch-data', component: FetchDataComponent },
    // ])

     RouterModule.forRoot([
      { path: '', component: StudentsPageComponent, pathMatch: 'full' },
      { path: 'student/:id', component: StudentDetailsComponent },
      { path: 'course/:id', component: CourseDetailsComponent }
    ]),
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
