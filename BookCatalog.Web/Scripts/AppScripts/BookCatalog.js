$(document).ready(function () {
    $("#bookGrid").DataTable({

        "serverSide": true, // for process server side
        "processing": true, // for show progress bar
        "filter": true, // this is for disable filter (search box)
        "orderMulti": false, // for disable multiple column at once
        "pageLength": 5,

        "ajax": {
            "url": "/Book/LoadData",
            "type": "POST",
            "datatype": "json"
        },

        "columnDefs":
            [{
                "targets": [0],
                "visible": false,
                "searchable": false
            },
            {
                "targets": [1],
                "searchable": false,
                "orderable": false
            },
            {
                "targets": [2],
                "searchable": false,
                "orderable": false
            },
            {
                "targets": [3],
                "searchable": false,
                "orderable": false
            },
            {
                "targets": [4],
                "searchable": false,
                "orderable": false
            }],

        "columns": [
            { "data": "BookId", "name": "BookId", "autoWidth": true },
            { "data": "Name", "name": "Name", "autoWidth": true },
            { "data": "PageCount", "name": "PageCount", "autoWidth": true },
            { "data": "Rating", "name": "Rating", "autoWidth": true },
            { "data": "AuthorFullName", "name": "Author", "autoWidth": true },

            {
                "render": function (data, type, full, meta) {
                    return '<a class="btn btn-info" href="/Book/Edit/' + full.BookId + '">Edit</a>';
                }
            },

            {
                data: null, render: function (data, type, row) {
                    return "<a href='#' class='btn btn-danger' onclick=DeleteData('" + row.BookId + "'); >Delete</a>";
                }
            }
        ]
    });
});


function DeleteData(BookId) {
    if (confirm("Are you sure you want to delete ...?")) {
        Delete(BookId);
    }
    else {
        return false;
    }
}

function Delete(BookId) {
    var url = 'Book/DeleteBook';
    $.post(url, { id: BookId }, function (data) {
        if (data === "Deleted") {
            oTable = $('#bookGrid').DataTable();
            oTable.draw();
        }
        else {
            alert("Something Went Wrong!");
        }
    });
}