import { Guid } from 'guid-typescript';

export interface Walk {
  id: Guid;
  date: Date;
  animalName: string;
  animalProfileImageUrl: string;
}
