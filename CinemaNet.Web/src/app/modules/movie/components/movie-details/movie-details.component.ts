import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { MovieDetails } from '../../models/movie-details';
import { MoviesService } from '../../services/movies.service';

@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.scss']
})
export class MovieDetailsComponent implements OnInit  {
  
  @Input()
  movieDetails: MovieDetails = MovieDetails.createEmpty();

  constructor(private moviesService: MoviesService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.moviesService.getMovieDetails(this.route.snapshot.params['id'])
      .subscribe(movieDetails => {
        this.movieDetails = movieDetails;
      });
  }
}
