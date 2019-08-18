import * as ko from "knockout";

class Author {
    constructor() {

    };

    public FirstName: KnockoutObservable<string>;

    public LastName: KnockoutObservable<string>;

    public BookCount: KnockoutObservable<number>;
}