import { Injectable } from "@angular/core";
import { Repository } from "../models/repository";
import { Observable, of } from "rxjs";
import { Router } from "@angular/router";
import { map, catchError } from 'rxjs/operators';
import { AuthenticationService } from '../auth/authentication.service';

export class RegistrationService {

    constructor(private repo: Repository, 
                private router: Router, private authService: AuthenticationService) { }

    registered: boolean = false;
    email: string;
    password: string;
    callbackUrl: string;

    register() : Observable<boolean> {
        this.registered = false;
        return this.repo.register(this.email, this.password).pipe(
            map(response => {
                if (response) {
                    this.authService.authenticated = true;
                    this.authService.name = this.email;
                    console.log("this here ", response);
                    this.registered = true;
                    this.password = null;
                    this.router.navigateByUrl(this.callbackUrl || "store");
                }
                return this.registered;
            }),
            catchError(e => {
                this.registered = false;
                console.log("error")
                return of(false);  
            }));
    }

    logout() {
        this.registered = false;
        this.repo.logout();
        this.router.navigateByUrl("/store");
    }
}
