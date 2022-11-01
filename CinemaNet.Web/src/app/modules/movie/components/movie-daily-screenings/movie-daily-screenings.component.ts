import { Component, Input, OnInit } from '@angular/core';

import { MovieScreenings } from '../../models/movie-screenings';

@Component({
  selector: 'app-movie-daily-screenings',
  templateUrl: './movie-daily-screenings.component.html',
  styleUrls: ['./movie-daily-screenings.component.scss']
})
export class MovieDailyScreeningsComponent implements OnInit {

  @Input() screenings!: MovieScreenings;

  constructor() { }

  ngOnInit(): void {
  }

}
