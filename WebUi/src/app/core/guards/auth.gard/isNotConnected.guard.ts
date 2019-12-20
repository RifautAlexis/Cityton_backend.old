import { Injectable } from '@angular/core';
import { Router, ActivatedRouteSnapshot, RouterStateSnapshot, CanActivate } from '@angular/router';

import { AuthService } from '@core/services/auth.service';

@Injectable({ providedIn: 'root' })
export class IsNotConnectedGuard implements CanActivate {
  constructor(private router: Router, private authService: AuthService) { }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
    const currentUser = this.authService.currentUserValue();

    if (!currentUser) { return true; }

    this.router.navigate(['']);

    return false;
  }

}
