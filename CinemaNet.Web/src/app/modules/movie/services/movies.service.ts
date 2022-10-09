import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

import { Movie } from '../models/movie';
import { MovieDetails } from '../models/movie-details';

@Injectable({
  providedIn: 'root'
})
export class MoviesService {
  
  private weeklyMoviesUrl = 'api/movies/weekly';
  private movieDetailsUrl = 'api/movies';

  constructor(private http: HttpClient) { }

  getWeeklyMovies(): Observable<Movie[]> {
    return this.http.get<Movie[]>(`${environment.serverBaseUrl}/${this.weeklyMoviesUrl}`);
  }

  getMovieDetails(id: string): Observable<MovieDetails> {
    return this.http.get<MovieDetails>(`${environment.serverBaseUrl}/${this.movieDetailsUrl}/${id}`);
  }
}
