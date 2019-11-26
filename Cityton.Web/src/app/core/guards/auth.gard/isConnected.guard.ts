import { Injectable } from '@angular/core';
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';

import { AuthService } from '@core/services/auth.service';

@Injectable({ providedIn: 'root' })
export class IsConnectedGuard implements CanActivate {
  constructor(private router: Router, private authService: AuthService) { }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) : boolean {
    const currentUser = this.authService.currentUserValue();

    if (currentUser) { return true; }

    this.router.navigate(['']);

    return false;
  }
}
