import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatDividerModule } from '@angular/material/divider';
import { MatIconModule } from '@angular/material/icon';
import { HttpClientModule } from '@angular/common/http';
import { LightgalleryModule } from 'lightgallery/angular';

import { MovieRoutingModule } from './movie-routing.module';
import { MoviesComponent } from './components/movies/movies.component';
import { MovieComponent } from './components/movie/movie.component';
import { MovieDetailsComponent } from './components/movie-details/movie-details.component';
import { MovieMediaComponent } from './components/movie-media/movie-media.component';
import { SliceTextPipe } from '../shared/pipes/slice-text.pipe';
import { MovieDaySelectorComponent } from './components/movie-day-selector/movie-day-selector.component';
import { MovieDailyScreeningsComponent } from './components/movie-daily-screenings/movie-daily-screenings.component';
import { FilterByScreeningDayPipe } from './pipes/filter-by-screening-day.pipe';
import { FilterMovieByScreeningDayPipe } from './pipes/filter-movie-by-screening-day.pipe';


@NgModule({
  declarations: [
    MoviesComponent,
    MovieComponent,
    MovieDetailsComponent,
    MovieMediaComponent,
    SliceTextPipe,
    MovieDaySelectorComponent,
    MovieDailyScreeningsComponent,
    FilterByScreeningDayPipe,
    FilterMovieByScreeningDayPipe
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    MatButtonModule,
    MovieRoutingModule,
    MatCardModule,
    MatDividerModule,
    MatIconModule,
    LightgalleryModule
  ]
})
export class MovieModule { }
