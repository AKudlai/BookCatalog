import * as ko from "knockout";

class Author {
    constructor() {
        this.firstName = ko.observable<string>("");
        this.lastName = ko.observable<string>("");
        this.bookCount = ko.observable<number>();
    }

    public firstName: KnockoutObservable<string> ;

    public lastName: KnockoutObservable<string>;

    public bookCount: KnockoutObservable<number>;

}