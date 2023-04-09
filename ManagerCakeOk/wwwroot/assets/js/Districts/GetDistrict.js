$(document).ready(function () {
    LoadDataDitrict();
});

var PageIndex = 1;
var PageSize = 10;
//load data district
function LoadDataDitrict() {
    $("#BodyData").empty();
    $("#TotalDistrict").empty();
    $("#PageItem").empty();
    $("#ItemInPage").empty();
    var count = 0;
    $.ajax({
        url: "/Districts/GetAllDistrict",
        type: "get",
        data: {
            PageSize: PageSize,
            PageIndex: PageIndex
        },
        success: function (result) {
            $.each(result.l_District, function (key, item) {
                var Html = "";
                count++;
                Html += '<tr id="' + item.id + '">';
                Html += '<th scope="row">' + item.id + '</th>';
                Html += '<td>' + item.name + '</td>';
                Html += '<td>' + item.nameCity + '</td>';
                if (item.status == true) {
                    Html += '<td style="color:green;">Đang Hoạt Động</td>';
                } else {
                    Html += '<td style="color:red;">Ngưng Hoạt Động</td>';
                }
                Html += '<td> <button style="border: none; background: none; color: blue;" name="BtnEditDistrict" data-bs-toggle="tooltip" data-bs-placement="top" title="Cập Nhật" />'
                    + '<i class="fas fa-edit"></i></a> | '
                    + ' <button style="border: none; background: none; color: blue;" name="BtnEditStatus" data-bs-toggle="tooltip" data-bs-placement="top" title="Đổi Trạng Thái" />'
                    + '<i class="fas fa-cog"></i></a>'
                    + '</td>';
                Html += '</tr>';
                $("#BodyData").append(Html);
            })
            $("#PageItem").append(PageIndex);
            $("#ItemInPage").append(count);
            $("#TotalDistrict").append(result.total);
            //paing
            paging(result.total, function () {
                LoadDataDitrict();
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
//Select Item For view Table
$("#SelectItem").change(function () {
    var V_Data = $("#SelectItem").val();
    PageSize = V_Data;
    LoadDataDitrict();
    return;
})

//Reload Page
function ReloadPage() {
    window.location.reload();
}

//---------------------------------------------------
//Edit District
$(document).on('click', 'button[name="BtnEditDistrict"]', function () {
    $("#ErrorHelp").empty();
    $("#TxtSelectCity").empty();
    $("#TxtEditNameCity").empty();
    $("#TxtEditIDDistrict").empty();
    $("#TxtEditDistrict").empty();
    $("#TxtIDCitys").empty();
    var IdDistrict = $(this).closest("tr").attr("id");
    $.ajax({
        url: "/Districts/EditDitrictGet",
        type: "get",
        data: {
            Id: IdDistrict
        },
        success: function (result) {
            var htmlDefaul = '<option value="0" selected>-- Vui lòng chọn ---</option>';
            $("#TxtSelectCity").append(htmlDefaul);
            $.each(result.l_City, function (key, item) {
                var html = '';
                html += '<option value="' + item.id + '">' + item.nameCity + '</option>';
                $("#TxtSelectCity").append(html);
            })
            if (result.idCity == 0) {
                $("#TxtEditNameCity").val('Hiện tại Tỉnh/Tp này đang bị khóa');
            } else {
                $("#TxtEditNameCity").val(result.nameCity);
                $("#TxtIDCitys").val(result.idCity);
            }
            $("#TxtEditIDDistrict").val(result.idDitrict);
            $("#TxtEditDistrict").val(result.nameDistrict)
            $("#M_EditDistrict").show();
        }
    })
    return;
});

//Close modal edit district
$("#BtnClose").click(function () {
    $("#M_EditDistrict").hide();
    window.location.reload();
})

//Change Content Select City name
$("#TxtSelectCity").change(function () {
    var name = $("#TxtSelectCity option:selected").text();
    $("#TxtEditNameCity").empty();
    $("#TxtEditNameCity").val(name);
    $("#TxtIDCitys").val($("#TxtSelectCity").val());
})

//Validate Name District
function ValidateError() {
    var Data = $("#TxtEditDistrict").val();
    if (Data.length == 0 || Data == '') {
        return false;
    } else {
        return true;
    }
}

//Update District
$("#Btn_Update").click(function () {
    $("#ErrorHelp").empty();
    var CheckData = ValidateError();
    if (CheckData == false) {
        $("#ErrorHelp").append("Vui Lòng Nhập Tên Quận/Huyện!")
    } else {
        $("#Modal_Loading").show();
        $.ajax({
            url: "/Districts/EditDistrict",
            type: "post",
            data: {
                IdDistrict: $("#TxtEditIDDistrict").val(),
                IdCity: $("#TxtIDCitys").val(),
                NameDistrict: $("#TxtEditDistrict").val()
            },
            success: function (result) {
                $("#Modal_Loading").hide();
                switch (result.id) {
                    case 1:
                        toastr.error("Thông Báo Lỗi", "Không tìm thấy ID Quận/Huyện")
                        break;
                    case 2:
                        toastr.success("Thông Báo Thành Công", "Chỉnh Sửa Quận/Huyện Thành Công");
                        $("#M_EditDistrict").hide();
                        LoadDataDitrict();
                        break;
                }
            }
        })
    }
    return;
})

//---------------------------------------------------
//Edit District status
$(document).on('click', 'button[name="BtnEditStatus"]', function () {
    var IdDistrict = $(this).closest("tr").attr("id");
    $("#TxtIDDistrict").empty();
    $("#TxtNameDistrict").empty();
    $("#TxtStatusDistrict").empty();
    $.ajax({
        url: "/Districts/EditStatusDistrict",
        type: "get",
        data: {
            Id: IdDistrict
        },
        success: function (result) {
            $("#TxtIDDistrict").val(result.id);
            $("#TxtNameDistrict").val(result.name);
            if (result.status == true) {
                $("#TxtStatusDistrict").val('Đang Hoạt Động');
            } else {
                $("#TxtStatusDistrict").val('Ngưng Hoạt Động');
            }
            $("#M_EditStatus").show();
        }
    })
    return;
});

//close modal edit status
$("#BtnCloseStatus").click(function () {
    $("#M_EditStatus").hide();
});

$("#Btn_UpdateSetting").click(function () {
    var ValStatus = $("#TxtSelectStatus").val();
    if (ValStatus == 0) {
        toastr.error("Thông Báo Lỗi!", "Vui Lòng Chọn Một Trạng Thái");
    } else {
        $("#Modal_Loading").show();
        $.ajax({
            url: "/Districts/EditStatusDistrictPost",
            type: "post",
            data: {
                Id: $("#TxtIDDistrict").val(),
                StatusID: ValStatus
            },
            success: function (result) {
                $("#Modal_Loading").hide();
                switch (result.id) {
                    case 1:
                        toastr.error("Thông Báo Lỗi", "Không Tìm Thấy ID Nào Thuộc Quận/Huyện Này!");
                        break;
                    case 2:
                        toastr.success("Thông Báo Thành Công", "Thay Đổi Trạng Thái Quận/Huyện Thành Công!");
                        $("#M_EditStatus").hide();
                        LoadDataDitrict();
                        break;
                }
            }
        })
    }
    return;
});