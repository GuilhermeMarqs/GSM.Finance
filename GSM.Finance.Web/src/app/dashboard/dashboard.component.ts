import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { NgxEchartsDirective, provideEcharts } from 'ngx-echarts';
import { EChartsOption } from 'echarts';
import {MatGridListModule} from '@angular/material/grid-list'; 
import {MatCardModule} from '@angular/material/card';
import {MatChipsModule} from '@angular/material/chips';
import * as echarts from 'echarts';


@Component({
  selector: 'app-dashbord',
  standalone:true,
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.css',
  imports: [CommonModule, NgxEchartsDirective,MatGridListModule, MatCardModule,MatChipsModule],
  providers: [provideEcharts()]
})
export class DashboardComponent {

  barOption: EChartsOption = {
    legend: {},
  tooltip: {},
  dataset: {
    source: [
      ['product', 'Entrada', 'Saídas', 'Fabrica'],
      ['Janeiro', 43.3, 85.8, 93.7],
      ['Fevereiro', 83.1, 73.4, 55.1],
      ['Março', 86.4, 65.2, 82.5],
      ['Abril', 72.4, 53.9, 39.1]
    ]
  },
  xAxis: { type: 'category' },
  yAxis: {},
  // Declare several bar series, each will be mapped
  // to a column of dataset.source by default.
  series: [{ type: 'bar' }, { type: 'bar' }, { type: 'bar' }]
  };
  pieOption: EChartsOption = {
    title: {
      text: 'Gastos Mensais',
      subtext: 'Junho 2024',
      left: 'center'
    },
    tooltip: {
      trigger: 'item'
    },
    series: [
      
      {
        data: [  
          { value: 1048, name: 'Santander',  },
          { value: 735, name: 'NuBank' },
          { value: 580, name: 'Inter' },
          { value: 484, name: 'Gastos Fixos' },
        ],
        type: 'pie',
      },
    ],
    emphasis: {
      itemStyle: {
        shadowBlur: 10,
        shadowOffsetX: 0,
        shadowColor: 'rgba(0, 0, 0, 0.5)'
      }
    }
  };

  ngOnInit() {
  }

}
