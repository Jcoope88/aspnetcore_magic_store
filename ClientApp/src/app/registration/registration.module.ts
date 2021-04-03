import { NgModule } from "@angular/core";
import { FormsModule } from '@angular/forms';
import { RouterModule } from "@angular/router";
import { CommonModule } from '@angular/common';
import { RegistrationService } from "./registration.service";
import { RegistrationComponent } from "./registration.component";

@NgModule({
    imports: [RouterModule, FormsModule, CommonModule],
    declarations: [RegistrationComponent],
    providers: [RegistrationService],
    exports: [RegistrationComponent]
})
export class RegModule { }
