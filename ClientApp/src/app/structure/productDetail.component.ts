import { Component } from '@angular/core';
import { Repository } from "../models/repository";
import { Product } from "../models/product.model";
import { Router, ActivatedRoute } from "@angular/router";
import { Cart } from '../models/cart.model';

@Component({
    selector: "product-detail",
    templateUrl: "productDetail.component.html"
})
export class ProductDetailComponent {

    constructor(private repo: Repository,
                router: Router,
                activeRoute: ActivatedRoute,
                private cart: Cart) {

        let id = Number.parseInt(activeRoute.snapshot.params["id"]);
        if (id) {
            this.repo.getProduct(id);
        } else {
            router.navigateByUrl("/");
        }
    }

    get product(): Product {
        return this.repo.product;
    }
    
    addToCart(product: Product) {
        this.cart.addProduct(product);
    } 
}
