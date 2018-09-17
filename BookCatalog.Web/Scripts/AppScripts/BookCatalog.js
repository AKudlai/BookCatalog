$(document).ready(function () {
    var bookTable = $("#bookGrid").DataTable({

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
                "searchable": false,
                "sortable": false,
                "data": null,
                "defaultContent": ''
            },
            { "title": "BookId", "data": "BookId", "visible": false },
            { "title": "Book Title", "data": "Name", "autoWidth": true},
            { "title": "Published", "data": "PublishDate", "autoWidth": true },
            { "title": "Page Count", "data": "PageCount", "autoWidth": true },
            { "title": "Rating", "data": "Rating", "autoWidth": true},

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
                "data": "BookId",
                "width": "50px",
                "render": function (data) {
                    return '<a class="popup btn btn-primary" href="/Book/EditBook/' + data + '">Edit</a>';
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

        "drawCallback": function () {

            console.log("$('.tablecontainer a.popup')", $('.tablecontainer a.popup'));

            // Edit book
            $('.tablecontainer a.popup').on('click', function (e) {
                e.preventDefault();
                OpenPopup($(this).attr('href'));
            });
        }
    });

    function OpenPopup(pageUrl) {
        var $pageContent = $('<div/>');
        var $dialog;

        $pageContent.load(pageUrl, function (response) {

            var $popupForm = $('#popupForm', $pageContent);

            $popupForm.on('submit', function (event) {
                event.preventDefault();

                $dialog.dialog('close');
                bookTable.ajax.reload();

            });
        });

        $dialog = $('<div class="popupWindow" style="overflow:auto"></div>').html($pageContent);
        $dialog.dialog({
                draggable: false,
                autoOpen: false,
                resizable: false,
                model: true,
                title: 'Edit book',
                height: 550,
                width: 600,
                close: function () {
                    $dialog.dialog('destroy').remove();
                }
            });

        $dialog.dialog('open');
    }

    $('#bookGrid tbody').on('click', 'td.details-control', function () {
        var tr = $(this).closest('tr');
        var row = bookTable.row(tr);

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
            bookTable = $('#bookGrid').DataTable();
            bookTable.draw();
        }
        else {
            alert("Something Went Wrong!");
        }
    });
}