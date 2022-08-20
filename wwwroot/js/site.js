// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Search in Table

var searchBox = document.getElementById("myInput");
if (searchBox) {
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
}
// Search in Cards
//var searchFilter = () => {
//    const input = document.querySelector(".form-control");
//    const cards = document.getElementsByClassName("test");
//    let filter = input.value
//    for (let i = 0; i < cards.length; i++) {
//        let title = cards[i].querySelector(".card-title");
//        if (title.innerText.toLowerCase().indexOf(filter.toLowerCase()) > -1) {
//            cards[i].classList.remove("d-none")
//        } else {
//            cards[i].classList.add("d-none")
//        }
//    }
//}

//var searchBoxMovie = document.getElementById("myInputCard");
//if (searchBoxMovie) {
//    searchBoxMovie.addEventListener("keyup", function () {
//        const input = document.querySelector("#myInputCard");
//        const cards = document.getElementsByClassName("card");
//        let filter = input.value.toUpperCase()

//        for (let i = 0; i < cards.length; i++) {
//            let title = cards[i].querySelector(".card-title");
//            if (title.innerText.toUpperCase().indexOf(filter) > -1) {
//                cards[i].style.display = "";
//            } else {
//                cards[i].style.display = "none";
//            }
//        }
//    });

//}


