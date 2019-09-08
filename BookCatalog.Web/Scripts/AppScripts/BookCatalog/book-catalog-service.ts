export class BookCatalogService {
        
    readonly addUrl: string = "/Book/AddBook";

    addBook(member: any): Promise<string> {

        return new Promise((resolve, reject) => {

            const xhr = new XMLHttpRequest();

            xhr.onreadystatechange = () => {
                if (xhr.readyState === 4) {
                    if (xhr.status === 200) {
                        resolve(JSON.parse(xhr.response));
                    } else {
                        reject(xhr.response);
                    }
                }
            }
            xhr.open("PUT", this.addUrl, true);
            xhr.send(member);
        });
    }
}