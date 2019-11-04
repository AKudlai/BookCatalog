///<reference path="Models/book-model.ts" />
///<reference path="book-catalog-service.ts"/>

class BookCatalogBusiness {
    
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

    public getModel() {
        return this.model;
    }
}