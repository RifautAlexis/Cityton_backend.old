export interface IGroup {
  id: number;
  name: string;
  picture: string;
  members: User[];
  createdAt: Date;
}

interface User {
  id: number;
  username: string,
  isCreator: boolean
}
