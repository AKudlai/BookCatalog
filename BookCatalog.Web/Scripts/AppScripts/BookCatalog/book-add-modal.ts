﻿namespace BookAddModal {
    export var controller: BookCatalogController;
    let popupForm: string = '#popupForm';

    export function initialize(): void {
        let service = new BookCatalogService();
        //let model = new Book();
        let business = new BookCatalogBusiness(service);
        controller = new BookCatalogController(business);
    }
}