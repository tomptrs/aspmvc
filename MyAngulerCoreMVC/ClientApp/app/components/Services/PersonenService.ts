import { Http } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import "rxjs/add/operator/map";
    //https://www.youtube.com/watch?v=8UOKgXr2I30
import {
    Injectable
} from '@angular/core';


@Injectable()
export class PersonenService {
       
    
    private personen: any[];
    constructor(private _http: Http) {
        this.personen = [];
       /* this.personen.push(
            {
                "LastName": "Peeters",
                "FirstName": "Tom"
            });
        this.personen.push({
            "LastName": "Vandeperre",
            "FirstName": "Mieke"
        });*/
    }

    getPersonen(): any {
       
        this._http.get("http://localhost:8872/api/person")
            .map( (response) => response.json())
            .subscribe(data => {
                
                console.log(data);
                return data;
            });
      
       
    }
}
