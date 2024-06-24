import { Component } from '@angular/core';
import { Cartao } from '../../models/Cartao';

@Component({
  selector: 'app-cartao',
  templateUrl: './cartao.component.html',
  styleUrl: './cartao.component.css'
})
export class CartaoComponent {
  cartoes: Cartao[] = [
    { Nome: 'Santander SX', Limite: 10000, Banco: 'Santander' }, 
    { Nome: 'Inter Black', Limite: 10000, Banco: 'Inter' }, 
    { Nome: 'Inter Gold', Limite: 10000, Banco: 'Inter' }, 
    { Nome: 'Nubank Plat.', Limite: 10000, Banco: 'NuBank' }, 
];
}
