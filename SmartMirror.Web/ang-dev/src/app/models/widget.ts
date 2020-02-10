import { User } from './user';

export interface Widget {
    id: number;
    name: string;
    data: User;
    service: string;
}
