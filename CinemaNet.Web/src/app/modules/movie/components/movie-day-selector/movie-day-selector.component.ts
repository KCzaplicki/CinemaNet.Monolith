import { Component, Input, OnInit } from '@angular/core';
import * as moment from 'moment';

import { MoviesDay } from '../../models/movies-day';

@Component({
  selector: 'app-movie-day-selector',
  templateUrl: './movie-day-selector.component.html',
  styleUrls: ['./movie-day-selector.component.scss']
})
export class MovieDaySelectorComponent implements OnInit {

  private repertoireChangeDay = 4; 
  private daysCount = 7;

  days: MoviesDay[] = Array.from(Array(this.daysCount).keys())
              .map(i => { 
                var day = moment(this.selected).add(i - 1, 'days').toDate(); 
                return <MoviesDay> {
                    date: day,
                    available: this.isDayAvailable(day)
                  }
              });
  
  @Input() selected!: Date;

  constructor() {
  }

  ngOnInit(): void {
  }

  private isDayAvailable(date: Date): boolean {
    var today = moment().day();
    var day = moment(date).day();
    
    if(today < this.repertoireChangeDay) {
      return day <= this.repertoireChangeDay && day >= today;
    }
    else if(today == this.repertoireChangeDay) {
      return day == this.repertoireChangeDay;
    }
    else {
      return day <= this.repertoireChangeDay || day >= today;
    }
  }
}
