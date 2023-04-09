$(document).ready(function () {
    GetAllCountry();
});

var PageIndex = 1;
var PageSize = 20;
var Seach;
//Load Country
function GetAllCountry() {
    $("#BodyData").empty();
    $("#TotalCity").empty();
    $("#PageItem").empty();
    $("#ItemInPage").empty();
    var count = 0;
    $.ajax({
        url: "/Countrys/GetAllCountry",
        type: "get",
        data: {
            PageIndex: PageIndex,
            PageSize: PageSize,
            SeachName: Seach
        },
        success: function (Result) {
            $.each(Result.l_Country, function (key, item) {
                var Html = "";
                count++;
                Html += '<tr id="' + item.id + '">';
                Html += '<th scope="row">' + item.id + '</th>';
                Html += '<td>' + item.name + '</td>';
                Html += '<td>' + item.createDate + '</td>';
                if (item.status == true) {
                    Html += '<td style="color:green;">Đang Hoạt Động</td>';
                } else {
                    Html += '<td style="color:red;">Ngưng Hoạt Động</td>';
                }
                Html += '<td> <button style="border: none; background: none; color: blue;" name="BtnEditCity" data-bs-toggle="tooltip" data-bs-placement="top" title="Cập Nhật" />'
                    + '<i class="fas fa-edit"></i></a> | '
                    + ' <button style="border: none; background: none; color: blue;" name="BtnEditStatus" data-bs-toggle="tooltip" data-bs-placement="top" title="Đổi Trạng Thái" />'
                    + '<i class="fas fa-cog"></i></a>'
                    + '</td>';
                Html += '</tr>';
                $("#BodyData").append(Html);
            })
            $("#PageItem").append(PageIndex);
            $("#ItemInPage").append(count);
            $("#TotalCity").append(Result.total);
            //paing
            paging(Result.total, function () {
                GetAllCountry();
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

//---------------------------------------------------
//reload
function ReloadPage() {
    window.location.reload();
};

//---------------------------------------------
//seach country
function F_SeachCoutry() {
    var SeachData = $("#TxtSeach").val();
    if (SeachData.length == 0 || SeachData == '') {
        toastr.error("Thông Báo Lỗi!", "Vui Lòng Nhập Từ Khóa Cần Tìm");
    } else {
        Seach = SeachData;
        GetAllCountry();
    }
    return;
}