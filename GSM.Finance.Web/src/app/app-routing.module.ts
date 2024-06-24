import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { UsuarioComponent } from './usuario/usuario.component';
import { CartaoComponent } from './cartao/cartao.component';
import { CadastroComponent } from './cadastro/cadastro.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { FaturaComponent } from './fatura/fatura.component';
import { MovimentoComponent } from './movimento/Lista/movimento.component';
import { PerfilComponent } from './perfil/perfil.component';
import { BancoComponent } from './banco/banco.component';
import { MovimentoIncluirComponent } from './movimento/Incluir/movimento.incluir.component';

const routes: Routes = [
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'login', component: LoginComponent },
  { path: 'usuario', component: UsuarioComponent },
  { path: 'cartao', component: CartaoComponent },
  { path: 'cadastro', component: CadastroComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'fatura', component: FaturaComponent },
  { path: 'movimento', component: MovimentoComponent },
  { path: 'movimento/incluir', component: MovimentoIncluirComponent },
  { path: 'perfil', component: PerfilComponent },
  {path: 'banco', component:BancoComponent}
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
