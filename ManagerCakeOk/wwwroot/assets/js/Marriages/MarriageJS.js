
//create marriage
$("#Btn_Create").click(function () {
    $("#ErrorMarriage").empty();
    var CheckData = Validate();
    if (CheckData == false) {
        $("#ErrorMarriage").append("Vui lòng không bỏ trống !");
    } else {
        $("#Modal_Loading").show();
        $.ajax({
            url: "/Marriages/CreateMarriage/",
            type: "post",
            data: {
                Name: $("#TxtMarriage").val()
            },
            success: function (result) {
                $("#Modal_Loading").hide();
                switch (result.id) {
                    case 1:
                        toastr.success("Thông Báo Thành Công", "Tạo mới tình trạng hôn nhân thành công");
                        $("#TxtMarriage").val('');
                        break;
                    default:
                        toastr.error("Thông Báo Thất Bại", "Đã xảy ra lỗi vui lòng kiểm tra lại")
                        break
                }
            }
        })
    }
    return;
})

//valiadate name
function Validate() {
    var check = $("#TxtMarriage").val();
    if (check.length == 0 || check == '') {
        return false;
    } else {
        return true;
    }
}