///<reference path="book-catalog-business.ts" />
///<reference path="../../typings/jquery/jquery.d.ts" />

class BookCatalogController {

    readonly business: BookCatalogBusiness;

    constructor(business: BookCatalogBusiness) {
        this.business = business;
        
        document.onload = () => {
            ko.applyBindings(this.business.getModel());
        }
    }

    public addBook = (): void => {
        // To-Do add validation.
        this.business.addBook();
    }


}
