///<reference path="../../../typings/knockout/knockout.d.ts">

class Book {
    constructor() {
        this.name = ko.observable<string>('');
        this.publishDate = ko.observable<string>('');
        this.pageCount = ko.observable<number>();
        this.rating = ko.observable<number>();
    }

    name: KnockoutObservable<string>;

    publishDate: KnockoutObservable<string>;

    pageCount: KnockoutObservable<number>;

    rating: KnockoutObservable<number>;
}