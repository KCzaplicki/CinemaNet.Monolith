import { Component, Input, OnInit } from '@angular/core';
import lgVideo from 'lightgallery/plugins/video';

@Component({
  selector: 'app-movie-media',
  templateUrl: './movie-media.component.html',
  styleUrls: ['./movie-media.component.scss']
})
export class MovieMediaComponent implements OnInit {

  @Input() 
  mediaUrls: string[] = [];

  settings = {
    counter: false,
    download: false,
    plugins: [lgVideo]
  };

  constructor() { }

  ngOnInit(): void {
  }

}
