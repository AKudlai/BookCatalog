import { BookCatalogBusiness } from "./book-catalog-business";
import { Book } from "./Models/book-model"

class BoolCatalogController {

    readonly business: BookCatalogBusiness;
    readonly book: Book;

    constructor(book: Book, business: BookCatalogBusiness, doc: HTMLDocument) {
        this.book = new Book();
        this.business = business;
        doc.onload = () => {
            ko.applyBindings(this.book);
        }
    }
}
