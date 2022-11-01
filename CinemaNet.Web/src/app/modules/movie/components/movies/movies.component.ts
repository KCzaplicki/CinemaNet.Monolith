import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import * as moment from 'moment';

import { Movie } from '../../models/movie';
import { MoviesService } from '../../services/movies.service';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrls: ['./movies.component.scss']
})
export class MoviesComponent implements OnInit {

  movies: Movie[] = []
  selectedDay: Date = moment().toDate();

  constructor(private moviesService: MoviesService,
    private route: ActivatedRoute) { }

  ngOnInit(): void { 
    this.moviesService.getWeeklyMovies()
      .subscribe(movies => this.movies = movies);

    this.route.queryParams.subscribe(queryParams => {
      var day = queryParams['day'] != null ? 
        moment(queryParams['day'], 'd-mm-yyy').add(1, 'days').toDate() : 
        new Date();
      this.selectedDay = day;
    });
  }

}
