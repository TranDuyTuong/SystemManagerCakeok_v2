$(document).ready(function () {
    LoadData();
});
var PageIndex = 1;
var PageSize = 10;
//load data city and district
function LoadData() {
    $("#NameCity").empty();
    $("#StatusCity").empty();
    $("#TotalDitrist").empty();
    $("#BodyData").empty();
    $("#PageItem").empty();
    $("#ItemInPage").empty();
    var count = 0;
    $.ajax({
        url: "/Citys/DetailCity",
        type: "get",
        data: {
            Id: $("#IdCity").val(),
            PageSize: PageSize,
            PageIndex: PageIndex
        },
        success: function (result) {
            $("#NameCity").append(result.name)
            if (result.status == true) {
                $("#StatusCity").append("Đang Hoạt Động");
            } else {
                $("#StatusCity").append("Ngưng Hoạt Động");
            }
            $("#TotalDitrist").append(result.totalDistrict);
            $.each(result.l_District, function (key, item) {
                var Html = "";
                count++;
                Html += '<tr id="' + item.id + '">';
                Html += '<th scope="row">' + item.id + '</th>';
                Html += '<td>' + item.name + '</td>';
                if (item.status == true) {
                    Html += '<td style="color:green;">Đang Hoạt Động</td>';
                } else {
                    Html += '<td style="color:red;">Ngưng Hoạt Động</td>';
                }
                Html += '</tr>';
                $("#BodyData").append(Html);
            })
            $("#PageItem").append(PageIndex);
            $("#ItemInPage").append(count);
            $("#TotalCity").append(result.totalDistrict);
            //paing
            paging(result.totalDistrict, function () {
                LoadData();
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