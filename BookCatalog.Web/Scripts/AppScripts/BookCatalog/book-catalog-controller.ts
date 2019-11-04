///<reference path="book-catalog-business.ts" /> 

class BookCatalogController {

    readonly business: BookCatalogBusiness;

    constructor(business: BookCatalogBusiness) {
        this.business = business;
        
        document.onload = () => {
            ko.applyBindings(this.business.getModel());
        }
    }
}
