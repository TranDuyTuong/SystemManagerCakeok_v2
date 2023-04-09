$(document).ready(function () {
    GetAllCitys();
});

var PageIndex = 1;
var PageSize = 10;
var Seach;
var Sort;
//Get All Citys
function GetAllCitys() {
    $("#BodyData").empty();
    $("#TotalCity").empty();
    $("#PageItem").empty();
    $("#ItemInPage").empty();
    var count = 0;
    $.ajax({
        url: "/Citys/GetAllCitys",
        type: "get",
        data: {
            Index: PageIndex,
            Size: PageSize,
            Seach: Seach,
            Sort: Sort
        },
        success: function (Result) {
            $.each(Result.l_PaingCitys, function (key, item) {
                var Html = "";
                count++;
                Html += '<tr id="' + item.id + '">';
                Html += '<th scope="row">' + item.id + '</th>';
                Html += '<td>' + item.nameCity + '</td>';
                if (item.status == true) {
                    Html += '<td style="color:green;">Đang Hoạt Động</td>';
                } else {
                    Html += '<td style="color:red;">Ngưng Hoạt Động</td>';
                }
                Html += '<td><a href="/Citys/PageDetailCity/?Id=' + item.id + '" data-bs-toggle="tooltip" data-bs-placement="top" title="Xem Quận/Huyện Thuộc">'
                         + '<i class="fas fa-folder-open"></i></a> | '
                    + ' <button style="border: none; background: none; color: blue;" name="BtnEditCity" data-bs-toggle="tooltip" data-bs-placement="top" title="Cập Nhật" />'
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
                GetAllCitys();
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

//-----------------------------------------------
//Seach City
function F_SeachCity() {
    Seach = $("#TxtSeach").val();
    GetAllCitys();
}

//------------------------------------------------
//Sort Id
function SortId() {
    switch (Sort) {
        case 1:
            Sort = -1;
            break;
        case -1:
            Sort = 1;
            break;
        default:
            Sort = 1;
            break;
    }
    GetAllCitys();
}

//Sort Name
function SortName() {
    switch (Sort) {
        case 2:
            Sort = -2;
            break;
        case -2:
            Sort = 2;
            break;
        default:
            Sort = 2;
            break;
    }
    GetAllCitys();
}

//Reload Page
function ReloadPage() {
    window.location.reload();
}

//---------------------------------------------------
//Select Item For view Table
$("#SelectItem").change(function () {
    var V_Data = $("#SelectItem").val();
    PageSize = V_Data;
    GetAllCitys();
    return;
})

//---------------------------------------------------
//Edit City
$(document).on('click', 'button[name="BtnEditCity"]', function () {
    $("#ErrorHelp").empty();
    var IdCity = $(this).closest("tr").attr("id");
    $.ajax({
        url: "/Citys/PageEditMusic",
        type: "get",
        data: {
            Id: IdCity
        },
        success: function (result) {
            $("#TxtEditIDCity").val(result.id);
            $("#TxtEditCity").val(result.name);
            $("#M_EditCity").show();
        }
    })
    return;
});

$("#BtnClose").click(function () {
    $("#TxtEditIDCity").val('');
    $("#TxtEditCity").val('');
    $("#M_EditCity").hide();
})

$("#Btn_Update").click(function () {
    $("#ErrorHelp").empty();
    var CheckData = CheckValiCity();
    if (CheckData == false) {
        $("#ErrorHelp").append("Mã không chính xác, hoặc tên Tỉnh/Tp bị bỏ trống !");
    } else {
        $("#Modal_Loading").show();
        var Id = $("#TxtEditIDCity").val();
        var Name = $("#TxtEditCity").val();
        $.ajax({
            url: "/Citys/EditMuisc",
            type: "post",
            data: {
                Id: Id,
                Name: Name
            },
            success: function (result) {
                $("#Modal_Loading").hide();
                switch (result.id) {
                    case 1:
                        toastr.success("Thông Báo Thành Công", "Chỉnh sửa Tỉnh/Tp thành công!");
                        $("#TxtEditIDCity").val('');
                        $("#TxtEditCity").val('');
                        $("#M_EditCity").hide();
                        GetAllCitys();
                        break;
                    case 2:
                        toastr.error("Thông Báo Lỗi", "Chỉnh sửa Tỉnh/Tp thất bại!");
                        break;
                }
                return;
            }
        })
    }
    return;
})

function CheckValiCity() {
    var Id = $("#TxtEditIDCity").val();
    var Name = $("#TxtEditCity").val();
    if (Id.length == 0 || Name.length == 0) {
        return false;
    } else {
        return true;
    }
}

//-------------------------------------------------------
//Change Status
$(document).on('click', 'button[name="BtnEditStatus"]', function () {
    $("#ErrorStatus").empty();
    var IdCity = $(this).closest("tr").attr("id");
    $.ajax({
        url: "/Citys/ChangeStatusCityGet",
        type: "get",
        data: {
            Id: IdCity
        },
        success: function (result) {
            $("#TxtIDCity").val(result.id);
            $("#TxtNameCity").val(result.name);
            if (result.status == true) {
                $("#TxtStatusCity").val('Đang Hoạt Động');
            } else {
                $("#TxtStatusCity").val('Ngưng Hoạt Động');
            }
            $("#M_EditStatus").show();
        }
    })
    return;
});

$("#BtnCloseStatus").click(function () {
    $("#ErrorStatus").empty();
    $("#TxtIDCity").val('');
    $("#TxtNameCity").val('');
    $("#TxtStatusCity").val('');
    $("#M_EditStatus").hide();
});

$("#Btn_UpdateSetting").click(function () {
    $("#ErrorStatus").empty();
    var Request = $("#TxtSelectStatus").val();
    if (Request == 0) {
        $("#ErrorStatus").append("Vui Lòng Chọn Một Trạng Thái!");
    } else {
        var IdCity = $("#TxtIDCity").val();
        $("#Modal_Loading").show();
        $.ajax({
            url: "/Citys/ChangeStatusCity",
            type: "post",
            data: {
                Id: IdCity,
                IdStatus: Request
            },
            success: function (result) {
                $("#Modal_Loading").hide();
                switch (result.id) {
                    case 1:
                        toastr.error("Thông Báo Lỗi", "Không Tìm Thấy Mã Tỉnh/Tp Này!");
                        break;
                    case 2:
                        toastr.success("Thông Báo Thành Công", "Cập Nhật Trạng Thái Thành Công!");
                        $("#M_EditStatus").hide();
                        $("#TxtIDCity").val('');
                        $("#TxtNameCity").val('');
                        $("#TxtStatusCity").val('');
                        GetAllCitys();
                        break;
                }
            }
        })
    }
    return;
});