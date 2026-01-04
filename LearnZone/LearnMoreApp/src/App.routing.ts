// app-routing-module.ts
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Login } from './app/login/login';
import { Register } from './app/register/register';
import { Welcome } from './app/welcome/welcome';
import { ViewAllUser } from './app/view-all-user/view-all-user';
import { ViewChapterBycourseId } from './app/view-chapter-bycourse-id/view-chapter-bycourse-id';


const routes: Routes = [
  { path: '', component: Welcome },
  { path: 'login', component: Login },
  { path: 'register', component: Register },
  { path: 'welcome', component: Welcome },
  {path: 'courses/:courseId/chapters', component:ViewChapterBycourseId }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
