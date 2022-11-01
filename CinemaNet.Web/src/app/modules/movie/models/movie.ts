import { MovieScreenings } from "./movie-screenings";

export class Movie {
    public id!: string;
    public name!: string;
    public duration!: number;
    public releaseDate!: Date;
    public category!: string;
    public description!: string;
    public pictureUrl!: string;
    public screenings!: MovieScreenings[];
}
