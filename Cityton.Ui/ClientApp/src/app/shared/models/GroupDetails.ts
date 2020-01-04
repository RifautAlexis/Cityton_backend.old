import { Status } from '@shared/models/Enum';

export interface IGroupDetails {
  id: number;
  name: string;
  picture: string;
  createdAt: Date;
  members: User[];
  membershipRequests: Request[];
}

interface User {
  id: number;
  username: string;
  isCreator: boolean;

}

interface Request {
  id: number;
  username: string;
  status: Status;
  createdAt: Date;
}
