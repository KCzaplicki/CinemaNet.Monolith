import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { MovieDetailsComponent } from './components/movie-details/movie-details.component';
import { MoviesComponent } from './components/movies/movies.component';

const routes: Routes = [
  {  path: 'movies', component: MoviesComponent },
  {  path: 'movies/:id', component: MovieDetailsComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MovieRoutingModule { }
