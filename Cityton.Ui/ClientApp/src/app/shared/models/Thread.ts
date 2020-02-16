import { IUserMinimal as UserMinimal } from '@shared/models/UserMinimal';

export interface IThread {
  discussionId: number;
  participants: UserMinimal[];
}
