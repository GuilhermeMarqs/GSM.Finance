import { Component } from '@angular/core';
import  { Movimento } from '../../models/Movimento';
@Component({
  selector: 'app-movimento',
  templateUrl: './movimento.component.html',
  styleUrl: './movimento.component.css'
})
export class MovimentoComponent {
  movimentos: Movimento[] = [];
}
