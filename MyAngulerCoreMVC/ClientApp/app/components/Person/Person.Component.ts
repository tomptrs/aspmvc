import { Component } from '@angular/core';
import { PersonenService } from '../Services/PersonenService';
import { Http } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import "rxjs/add/operator/map";
    //https://www.youtube.com/watch?v=8UOKgXr2I30


@Component({
    selector: 'person',
    templateUrl: './Person.component.html',
    providers: [PersonenService] 
})
export class PersonComponent {

    public list: any[];
    

    public constructor(private _service:PersonenService, private _http:Http) {
        console.log("person constructor");
        
    }

    init() {
        this._http.get("http://localhost:8872/api/person")
            .map((response) => response.json())
            .subscribe(data => {

                console.log(data);
                this.list = data;
                for (let item of this.list) {
                    console.log(item.firstName);
                }
            });
       
    }
}