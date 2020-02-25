import { Status } from './Enum';

export interface IChallengeChat {
  challengeGivenId: number;
  name: string;
  statement: string;
  author: string;
  status: Status;
}
