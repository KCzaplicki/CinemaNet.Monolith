export class MovieDetails {
    public id!: string;
    public name!: string;
    public duration!: number;
    public releaseDate!: Date;
    public category!: string;
    public description!: string;
    public mediaUrls!: string[];
    public director!: string;
    public staff!: string[];

    public static createEmpty(): MovieDetails {
        return {
            id: '',
            name: '',
            duration: 0,
            releaseDate: new Date(1, 1, 1),
            category: '',
            description: '',
            mediaUrls: [],
            director: '',
            staff: []
          }
    }
}
