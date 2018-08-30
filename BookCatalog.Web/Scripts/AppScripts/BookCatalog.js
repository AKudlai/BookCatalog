$(document).ready(function () {
        var table = $("#bookGrid").DataTable({

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

        "columns": [
            {
                "className": 'details-control',
                "orderable": false,
                "data": null,
                "defaultContent": ''
            },
            { "title": "BookId", "data": "BookId", "searchable": false, "visible": false },
            { "title": "Book Title", "data": "Name", "searchable": true },
            { "title": "Published", "data": "PublishDate", "searchable": true },
            { "title": "Page Count", "data": "PageCount", "searchable": true },
            { "title": "Rating", "data": "Rating", "searchable": true },

            {
                "data": "Authors",
                "searchable": true,
                render: function (data, type, full) {
                    return data.join(', ');
                }
            },

            {   
                "searchable": false,
                "sortable": false,
                "render": function (data, type, full, meta) {
                    return '<a class="btn btn-info" href="/Book/Edit/' + full.BookId + '">Edit</a>';
                }
            },

            {
                "searchable": false,
                "sortable": false,
                data: null, render: function (data, type, row) {
                    return "<a href='#' class='btn btn-danger' onclick=DeleteData('" + row.BookId + "'); >Delete</a>";
                }
            }
        ],

        "lengthMenu": [[10, 25, 50, 100], [10, 25, 50, 100]]
    });

    $('#bookGrid tbody').on('click', 'td.details-control', function () {
        var tr = $(this).closest('tr');
        var row = table.row(tr);

        if (row.child.isShown()) {
            // This row is already open - close it
            row.child.hide();
            tr.removeClass('shown');
        }
        else {
            // Open this row
            row.child(format(row.data())).show();
            tr.addClass('shown');
        }
    });
});

// Child table format
function format(d) {
    // `d` is the original data object for the row
    return '<table cellpadding="5" cellspacing="0" border="0" style="padding-left:50px;">' +
        '<tr>' +
        '<td>Book Title:</td>' +
        '<td>' + d.Name + '</td>' +
        '</tr>' +
        '<tr>' +
        '<td>Published:</td>' +
        '<td>' + d.PublishDate + '</td>' +
        '</tr>' +
        '<td>Page Count:</td>' +
        '<td>' + d.PageCount + '</td>' +
        '</tr>' +
        '<tr>' +
        '<td>Rating:</td>' +
        '<td>' + d.Rating + '</td>' +
        '</tr>' +
        '<tr>' +
        '<td>Authors:</td>' +
        '<td>' + d.Authors + '</td>' +
        '</tr>' +
        '</table>';
}

function DeleteData(BookId) {
    if (confirm("Are you sure you want to delete ...?")) {
        Delete(BookId);
    }
    else {
        return false;
    }
}

// Delete book
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