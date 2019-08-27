import * as ko from "knockout";

export class Book {
    constructor() {
        this.name = ko.observable<string>("");
        this.publishDate = ko.observable<string>("");
        this.pageCount = ko.observable<number>();
        this.rating = ko.observable<number>();
    }

    public name: KnockoutObservable<string>;

    public publishDate: KnockoutObservable<string>;

    public pageCount: KnockoutObservable<number>;

    public rating: KnockoutObservable<number>;
}