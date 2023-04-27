import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormControl, FormGroup, Validators } from '@angular/forms'; 
import { TrainService } from '../services/Train.service';

@Component({
  selector: 'app-addtrain',
  templateUrl: './addtrain.component.html',
  styleUrls: ['./addtrain.component.css']
})
export class AddtrainComponent implements OnInit {


  constructor(private trainService: TrainService, private router: Router) { }

  ngOnInit(): void {}
    
    
  }


