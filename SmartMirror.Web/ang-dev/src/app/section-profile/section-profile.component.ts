import { Component, OnInit } from '@angular/core';
import { Widget } from '../models/widget';

@Component({
  selector: 'app-section-profile',
  templateUrl: './section-profile.component.html',
  styleUrls: ['./section-profile.component.css']
})
export class SectionProfileComponent implements OnInit {

    constructor() { }

    widgets: Widget[];

  ngOnInit(): void {
  }

}
