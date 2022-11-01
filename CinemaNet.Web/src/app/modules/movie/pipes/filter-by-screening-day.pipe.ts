import { Pipe, PipeTransform } from '@angular/core';
import * as moment from 'moment';

import { MovieScreenings } from '../models/movie-screenings';

@Pipe({
  name: 'filterByScreeningDay'
})
export class FilterByScreeningDayPipe implements PipeTransform {

  transform(value: MovieScreenings[], day: Date): MovieScreenings[] {
    return value.filter(v => moment(v.day).format('L') == moment(day).format('L'));
  }

}
