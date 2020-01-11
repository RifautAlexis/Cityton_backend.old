import { Status } from '@shared/models/Enum';

export interface IGroupDetails {
  id: number;
  name: string;
  picture: string;
  createdAt: Date;
  members: IUser[];
  membershipRequests: IRequest[];
}

interface IUser {
  requestId: number;
  userId: number;
  username: string;
  isCreator: boolean;

}

interface IRequest {
  userId: number;
  username: string;
  status: Status;
  createdAt: Date;
}
