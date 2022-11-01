import { Pipe, PipeTransform } from '@angular/core';
import * as moment from 'moment';

import { Movie } from '../models/movie';

@Pipe({
  name: 'filterMovieByScreeningDay'
})
export class FilterMovieByScreeningDayPipe implements PipeTransform {

  transform(value: Movie[], day: Date): Movie[] {
    return value.filter(v => v.screenings.some(s => moment(s.day).format('L') == moment(day).format('L')) );
  }

}
