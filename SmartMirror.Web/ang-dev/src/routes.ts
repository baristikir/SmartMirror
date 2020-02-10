import { Routes } from '@angular/router';
import { SectionProfileComponent } from './app/section-profile/section-profile.component';
import { SystemWidgetsComponent } from './app/system-widgets/system-widgets.component';

export const appRoutes: Routes = [
    { path: 'profile', component: SectionProfileComponent },
    { path: 'widgets', component: SystemWidgetsComponent },

    { path: '', redirectTo:'/profile', pathMatch: 'full' },
];
