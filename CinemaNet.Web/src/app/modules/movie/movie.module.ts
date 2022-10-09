import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatDividerModule } from '@angular/material/divider';
import { HttpClientModule } from '@angular/common/http';
import { LightgalleryModule } from 'lightgallery/angular';

import { MovieRoutingModule } from './movie-routing.module';
import { MoviesComponent } from './components/movies/movies.component';
import { MovieComponent } from './components/movie/movie.component';
import { MovieDetailsComponent } from './components/movie-details/movie-details.component';
import { MovieMediaComponent } from './components/movie-media/movie-media.component';
import { SliceTextPipe } from '../shared/pipes/slice-text.pipe';


@NgModule({
  declarations: [
    MoviesComponent,
    MovieComponent,
    MovieDetailsComponent,
    MovieMediaComponent,
    SliceTextPipe
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    MatButtonModule,
    MovieRoutingModule,
    MatCardModule,
    MatDividerModule,
    LightgalleryModule
  ]
})
export class MovieModule { }
