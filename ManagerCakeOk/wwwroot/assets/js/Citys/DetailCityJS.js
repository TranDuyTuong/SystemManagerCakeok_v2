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
                document.getElementById("StatusCity").style.color = "green";
                $("#StatusCity").append("Đang Hoạt Động");
            } else {
                document.getElementById("StatusCity").style.color = "red";
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

//Delete city
$("#btn_Delete").click(function () {
    $("#M_DeleteCity").show();
});

//Cancel delete
$("#btn_ConfimCancel").click(function () {
    $("#M_DeleteCity").hide();
});

//Confirm Delete
$("#btn_ConfimDelete").click(function () {
    $("#Modal_Loading").show();
    $.ajax({
        url: "/Citys/DeleteCity",
        type: "post",
        data: {
            IdCity: $("#IdCity").val()
        },
        success: function (result) {
            $("#Modal_Loading").hide();
            switch (result.id) {
                case 1:
                    toastr.error("Thông Báo Lỗi!", "Không tìm thấy Tỉnh/Tp cần xóa");
                    break;
                case 2:
                    toastr.success("Thông Báo Thành Công!", "Xóa Tỉnh/Tp thành công (không có Quận/Huyện nào thuộc Tỉnh/Tp này)");
                    break;
                case 3:
                    toastr.success("Thông Báo Thành Công!", "Xóa Tỉnh/Tp thành công");
                    break;
                default:
                    break;
            }
            window.location.href = "Citys/PageCity";
            return;
        }
    })
})