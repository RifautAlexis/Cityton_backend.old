export interface IGroup {
  id: number;
  name: string;
  picture: string;
  members: User[];
  createdAt: Date;
  membershipRequest: Request[];
}

interface User {
  id: number;
  username: string;
  isCreator: boolean;
}

interface Request {
  id: number;
  username: string;
}
