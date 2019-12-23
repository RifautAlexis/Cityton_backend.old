import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { IODataComponent } from './pages/IO-data/IO-data.component';
import { UserManagementComponent } from './pages/user-management/user-management.component';

const routes: Routes = [
    { path: '', component: UserManagementComponent },
    { path: 'data', component: IODataComponent },
    { path: 'user', component: UserManagementComponent }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})

export class AdminSpaceRoutingModule { }
