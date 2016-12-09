import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'fetchdata',
    template: require('./fetchdata.component.html')
})
export class FetchDataComponent {
    public movies: Movies[];

    constructor(http: Http) {
        http.get('/api/SampleData/GetMovies').subscribe(result => {
            this.movies = result.json();
        });
    }
}

interface Movies {
    movieName: string;
}
