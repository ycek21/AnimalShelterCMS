import { Img } from './image';

export interface Animal {
  id: string;
  name: string;
  dateOfBirth: Date;
  description: string;
  character: string;
  sex: boolean;
  weight: number;
  walkLimit: number;
  views: number;
  isDead: boolean;
  modifiedAt: Date;
  size: string;
  color: string;
  animalType: string;
  images: Img[];
}
