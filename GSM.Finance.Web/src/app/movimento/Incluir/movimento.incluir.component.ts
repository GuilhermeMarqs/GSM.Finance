import { Component, computed, signal } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { MovimentoService } from '../movimento.service';

@Component({
  selector: 'app-movimento-incluir',
  styleUrl: '../../app.component.css',
  templateUrl: './movimento.incluir.component.html',
  standalone: true,
  imports: [ReactiveFormsModule],

})
export class MovimentoIncluirComponent {
incluirMovimento() {
  console.log("Entrei")
  this.movimentoService.postMovimento(this.incluirForm.value);
  console.log("Saida")
}
  incluirForm!: FormGroup;

  constructor(private fb: FormBuilder, private movimentoService: MovimentoService){}
  ngOnInit(){
    this.incluirForm = new FormGroup('');
    this.incluirForm = this.fb.group({
      descricao: ['', Validators.required],
      categoria: ['', Validators.required],
      data: ['', Validators.required],
      valor: ['', Validators.required],
      formaPagamento: ['', Validators.required],
    })
  }
}