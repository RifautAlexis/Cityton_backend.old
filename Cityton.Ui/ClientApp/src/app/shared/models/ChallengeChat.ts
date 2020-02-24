import { Status } from './Enum';

export interface IChallengeChat {
    id: number;
    name: string;
    statement: string;
    author: string;
    status: Status;
  }
  