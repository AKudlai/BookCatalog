///<reference path="../../node_modules/@types/requirejs/index.d.ts"/>
require.config({
    paths: {
        "knockout": "../../node_modules/knockout/build/output/knockout-latest.js",
    },
    shim: {}
});
require(['../AppScripts/BookCatalog/Models/',
    '../AppScripts/BookCatalog/',
    '']);
//# sourceMappingURL=require-config.js.map