import { Component } from "@angular/core";
import { AuthenticationService } from "../auth/authentication.service";
import { RegistrationService } from "../registration/registration.service";

@Component({
    selector: "store-products",
    templateUrl: "productSelection.component.html"
})
export class ProductSelectionComponent {
    constructor(private authService: AuthenticationService, private regService: RegistrationService) { }
}
