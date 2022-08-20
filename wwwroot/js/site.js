// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Search

    var searchBox = document.getElementById("myInput");
    searchBox.addEventListener("keyup", function () {
            var keyword = this.value;
    keyword = keyword.toUpperCase();
    var table_3 = document.getElementById("myTable");
    var all_tr = table_3.getElementsByTagName("tr");
    for (var i = 0; i < all_tr.length; i++) {
                var all_columns = all_tr[i].getElementsByTagName("td");
    for (j = 0; j < all_columns.length; j++) {
                    if (all_columns[j]) {
                        var column_value = all_columns[j].textContent || all_columns[j].innerText;
    column_value = column_value.toUpperCase();
                        if (column_value.indexOf(keyword) > -1) {
        all_tr[i].style.display = ""; // show
    break;
                        } else {
        all_tr[i].style.display = "none"; // hide
                        }
                    }
                }
            }
        })
