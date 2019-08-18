import * as ko from "knockout";

class Book {
    constructor() {

    };

    public Name: KnockoutObservable<string>;

    public PublishDate: KnockoutObservable<string>;

    public PageCount: KnockoutObservable<number>;

    public Rating: KnockoutObservable<number>;
}