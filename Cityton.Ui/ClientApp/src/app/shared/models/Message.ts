export interface IMessage {
  id: number
  content: string;
  author: IUser;
  createdAt: Date;
  discussionId: number;
}

interface IUser {
  id: number;
  username: string;
}
