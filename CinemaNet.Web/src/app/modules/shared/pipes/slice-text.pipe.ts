import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'sliceText'
})
export class SliceTextPipe implements PipeTransform {

  transform(value: string, size: number): unknown {
    if(value.length <= size) {
      return value;
    } else {
      var slicedText = value.slice(0, size);
      slicedText = slicedText.slice(0, slicedText.lastIndexOf(' '));
      return `${slicedText}...`;
    }
  }

}
