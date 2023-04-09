$(document).ready(function () {
    LoadCity()
    LoadDataDitrict();
});

//load list City
function LoadCity() {
    $("#ErrorDistrict").empty();
    $("#TxtSelectCity").empty();
    $.ajax({
        url: "/Citys/JsonGetAllCity/",
        type: "get",
        success: function (result) {
            var htmlDefaul = '<option value="0" selected>-- Vui lòng chọn ---</option>';
            $("#TxtSelectCity").append(htmlDefaul);
            $.each(result, function (key, item) {
                var html = '';
                html += '<option value="' + item.id + '">' + item.nameCity + '</option>';
                $("#TxtSelectCity").append(html);
            })
        }
    })
}

//load ten district
function LoadDataDitrict() {
    $("#BodyData").empty();
    $.ajax({
        url: "/Districts/TenDistirctCreate",
        type: "get",
        success: function (result) {
            $.each(result, function (key, item) {
                var Html = "";
                Html += '<tr id="' + item.id + '">';
                Html += '<th scope="row">' + item.id + '</th>';
                Html += '<td>' + item.name + '</td>';
                Html += '<td>' + item.nameCity + '</td>';
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

//Create District
$("#Btn_Create").click(function () {
    $("#ErrorDistrict").empty();
    var Checked = CheckCity();
    if (Checked == 0) {
        toastr.error("Thông Báo Lỗi", "Vui Lòng Chọn Tỉnh/Tp")
    } else {
        var CheckName = CheckNameDistrict();
        if (CheckName == false) {
            $("#ErrorDistrict").append("Vui Lòng Nhập Vào Tên Quận/Huyện")
        } else {
            $("#Modal_Loading").show();
            $.ajax({
                url: "/Districts/CreateDistrict",
                type: "post",
                data: {
                    IdCity: $("#TxtSelectCity").val(),
                    NameDistrict: $("#TxtDistrict").val()
                },
                success: function (result) {
                    $("#Modal_Loading").hide();
                    switch (result.id) {
                        case 1:
                            toastr.error("Thông Báo Lỗi!", "Không tìm thấy Id của Tỉnh/Tp này");
                            break;
                        case 2:
                            toastr.success("Thông Báo Thành Công!", "Thêm mới Quận/Huyện thành công");
                            LoadCity();
                            $("#TxtDistrict").val('');
                            LoadDataDitrict();
                            break;
                    }
                }
            })
        }
    }
    return;
})

//check select city
function CheckCity() {
    var Datas = $("#TxtSelectCity").val();
    return Datas
}

//Check Name District
function CheckNameDistrict() {
    var Datas = $("#TxtDistrict").val();
    if (Datas.length == 0 || Datas == '') {
        return false;
    } else {
        return true;
    }
}