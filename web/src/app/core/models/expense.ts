import { Transaction } from './transaction';
import { Category } from './category';

export class Expense implements Transaction {
    id: number;
    amount: number;
    category: Category;
    date: Date;
    description: string;

    constructor(data: any) {
        Object.assign(this, data);

        this.date = new Date(data.date);
    }
}
