import { Component, OnDestroy, OnInit } from '@angular/core';
import { IProduct } from './products';
import { ProductService } from './product.service';
import { Subscription } from 'rxjs';

@Component({
  templateUrl : './product-list.component.html',
  styleUrls : ['./product-list.component.css']
})


export class ProductListComponent implements OnInit, OnDestroy{

  pageTitle : string = 'Product List';
  imageWidth : number = 50 ;
  imageMargin : number = 2 ;
  showImage : boolean = false;
  errorMessage : string = '';
  sub!: Subscription ;
  filteredProducts : IProduct[];

  _listFilter: string;
  get listFilter(): string{
    return this._listFilter;
  }

  set listFilter(value:string){
    this._listFilter = value;
    this.filteredProducts = this.listFilter ? this.performFilter(this.listFilter) : this.products;
  }

  products: IProduct[] = [];

  constructor(private productService : ProductService){
  }


  onRatingClicked(message : string) : void{
    this.pageTitle = 'Product List: ' + message;
  }

  performFilter(filterBy : string): IProduct[]{
    filterBy = filterBy.toLocaleLowerCase();
    return this.products.filter((product : IProduct) =>
      product.productName.toLocaleLowerCase().indexOf(filterBy) !== -1);
  }

  toggleImage():void{
    this.showImage = !this.showImage;
  }

  ngOnInit(): void {
    this.sub = this.productService.getProducts().subscribe({
      next: products => {
        this.products = products;
        this.filteredProducts = this.products;
      },
      error : err => this.errorMessage = err
    });
  }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }

}
