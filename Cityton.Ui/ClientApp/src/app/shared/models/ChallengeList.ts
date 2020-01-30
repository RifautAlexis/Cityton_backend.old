export interface IChallengeList {
  groups: IChallenge[];
}

interface IChallenge {
  id: number;
  title: string;
  statement: string;
  author: string;
  unlockedAt: Date;
}
