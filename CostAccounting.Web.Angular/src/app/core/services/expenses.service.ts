import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Expense } from "../models/expense";
import { map } from "rxjs/operators";
import { Observable } from "rxjs";

@Injectable({
    providedIn: "root",
})
export class ExpensesService {
    constructor(private http: HttpClient) {}

    public getExpenses(startDate?: Date, endDate?: Date): Observable<Expense[]> {
        return this.http
            .get("api/expenses?includes=Category")
            .pipe(map((data: any) => data.map((x: any) => new Expense(x))));
    }
}
