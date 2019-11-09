///<reference path="book-catalog-business.ts" />
///<reference path="../../typings/jquery/jquery.d.ts" />

class BookCatalogController {

    readonly business: BookCatalogBusiness;

    addBookModalId: string;

    constructor(business: BookCatalogBusiness) {
        this.business = business;

        this.addBookModalId = '#add_book_modal';
        
        this.initBindings();
    }

    initBindings(): void {
        let model = this.business.getModel();
        ko.applyBindings(model, $(this.addBookModalId)[0]);
    }

    addBook = (): void => {
        // To-Do add validation.
        this.business.addBook();
    }
    
    private cancel(): void {
        this.hidePopup();
    }

    private hidePopup(): void {
        $(this.addBookModalId).modal('hide');
    }

    private showPopup(): void {
        $(this.addBookModalId).modal('show');
        console.log('vsdfvds');
    }
}
