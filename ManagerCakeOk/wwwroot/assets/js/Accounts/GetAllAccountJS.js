$(document).ready(function () {
    LoadDataAccount()
});
var PageIndex = 1;
var PageSize = 10;

//load data account
function LoadDataAccount() {
    $("#BodyData").empty();
    $("#TotalAccount").empty();
    $("#PageItem").empty();
    $("#ItemInPage").empty();
    var count = 0;
    $.ajax({
        url: "/Account/GetAllAccountStaff",
        type: "get",
        data: {
            Index: PageIndex,
            Size: PageSize
        },
        success: function (result) {
            $.each(result.l_Account, function (key, item) {
                count++;
                var Html = '';
                Html += '<tr id="' + item.idAccount + '">';
                Html += '<th scope="row">' + count + '</th>';
                Html += '<td>' + item.fullname + '</td>';
                Html += '<td>' + item.email + '</td>';
                Html += '<td>' + item.createDate + '</td>';
                Html += '<td>' + item.createTime + '</td>';
                Html += '<td><a href="/ManagerAccount/DetailAccountGet/?IdAccount=' + item.idAccount + '" data-bs-toggle="tooltip" data-bs-placement="top" title="Xem Chi Tiết">'
                    + '<i class="fas fa-folder-open"></i></a>'
                    + '</td>';
                Html += '</tr>';
                $("#BodyData").append(Html);
            })
            $("#PageItem").append(PageIndex);
            $("#ItemInPage").append(count);
            $("#TotalAccount").append(result.total);
            //paing
            paging(result.total, function () {
                LoadDataAccount();
            })
        }
    })
}

//----------------------------------------------
//paing
function paging(totalRoll, callback) {
    var totalPage = Math.ceil(totalRoll / PageSize);
    $('#pagination').twbsPagination({
        totalPages: (totalPage == 0) ? 1 : totalPage,
        first: "Đầu",
        next: "Tiếp",
        last: "Cuối",
        prev: "Trước",
        visiblePages: 10,
        onPageClick: function (event, page) {
            PageIndex = page;
            setTimeout(callback, 200);
        }
    });
}