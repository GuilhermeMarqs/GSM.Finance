import { Component } from '@angular/core';
import { Movimento } from '../../../models/Movimento';
import { MovimentoService } from '../movimento.service';

@Component({
  selector: 'app-movimento',
  templateUrl: './movimento.component.html',
  styleUrl: './movimento.component.css'
})
export class MovimentoComponent {
  movimentos: Movimento[] = [];

  constructor(private movimentoService: MovimentoService) { }

  ngOnInit() {

    this.getMovimentos();
  }

  getMovimentos() {
    this.movimentoService.getMovimentos().subscribe((movimentos: Movimento[]) => {
      this.movimentos = movimentos;
    });
  }
}
