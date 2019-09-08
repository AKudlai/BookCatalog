import * as ko from "knockout";
import { Book } from "./Models/book-model";
import { BookCatalogService } from "./book-catalog-service";

export class BookCatalogBusiness {
    
    readonly model: Book; 
    readonly service: BookCatalogService;
    
    
    constructor(service: BookCatalogService) {
        this.service = service;
        this.model = new Book();
    }

    addBook(): Promise<string> {

        const jsModel = ko.toJS(this.model);

        return this.service.addBook(jsModel);
    }
}