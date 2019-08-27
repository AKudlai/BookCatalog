import * as ko from "knockout";
import { Book } from "./Models/book-model";
import { BookCatalogService } from "./book-catalog-service";

export class BookCatalogBusiness {
    
    private model: Book; 
    private service: BookCatalogService;
    
    
    constructor(service: BookCatalogService) {
        this.service = service;
        this.model = new Book;
    }

    private MapFromJSModel(sourceModel: any) {


    }
}