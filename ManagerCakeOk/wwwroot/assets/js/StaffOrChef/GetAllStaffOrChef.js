$(document).ready(function () {
    LoadDataStaffOrChef();
});

//Load data staff or chef
function LoadDataStaffOrChef() {
    $("#BodyData").empty();
    var count = 0;
    $.ajax({
        url: "/Account/GetAllStaffOrChef",
        type: "get",
        success: function (result) {
            $.each(result, function (key, item) {
                var Html = '';
                count++;
                Html += '<tr id="' + item.id + '">';
                Html += '<th scope="row">' + count + '</th>';
                Html += '<td>' + item.name + '</td>';
                Html += '<td>' + item.createDate + '</td>';
                if (item.status == true) {
                    Html += '<td style="color:green;">Đang Hoạt Động</td>';
                } else {
                    Html += '<td style="color:red;">Ngưng Hoạt Động</td>';
                }
                Html += '</tr>';
                $("#BodyData").append(Html);
            })
        }
    })
}

//Create new Staff or chef
$("#Btn_CreateStaffOrChef").click(function () {
    var DataCheck = ValidateData();
    if (DataCheck == false) {
        toastr.error("Thông Báo Lỗi", "Vui lòng không bỏ trống!");
    } else {
        $("#Modal_Loading").show();
        $.ajax({
            url: "/Account/CreateStaffOrChef/",
            type: "post",
            data: {
                Name: $("#TxtNameStaffOrChef").val()
            },
            success: function (result) {
                $("#Modal_Loading").hide();
                switch (result.id) {
                    case 1:
                        toastr.success("Thông báo thành công", "Thêm Mới Thành Công!");
                        $("#TxtNameStaffOrChef").val('');
                        LoadDataStaffOrChef();
                        break;
                    default:
                        toastr.error("Thông báo thất bại", "Thêm Mới Thất Bại Vui Lòng Kiểm Tra Lại!");
                        break;
                }
            }
        })
    }
    return;
});
//validate data
function ValidateData() {
    var Check = $("#TxtNameStaffOrChef").val();
    if (Check.length == 0 || Check == '') {
        return false;
    } else {
        return true;
    }
}
