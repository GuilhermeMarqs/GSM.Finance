import { Component, Input, computed, signal } from '@angular/core';

export type MenuItem = {
  icon:string;
  label:string,
  route:string
}

@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrl: './sidenav.component.css',
})
export class SidenavComponent {

  sideNavoCollapsed = signal(false);
  @Input() set collapsed(val: boolean){
    this.sideNavoCollapsed.set(val);
  }

  menuItems = signal<MenuItem[]>([
    { label: 'Dashboard', route: '/dashboard', icon: 'dashboard' },
    { label: 'Banco', route: '/banco', icon: 'account_balance' },
    { label: 'Cartões', route: '/cartao', icon: 'credit_card' },
    { label: 'Movimentos', route: '/movimento', icon: 'swap_horiz' },
    { label: 'Faturas', route: '/fatura', icon: 'receipt' },
    { label: 'Usuario', route: '/usuario', icon: 'account_circle' }
  ])

  profilePicSized = computed(() => this.sideNavoCollapsed() ? '32' : '100')
  
}
