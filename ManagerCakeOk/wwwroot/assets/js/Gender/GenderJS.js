$("#Btn_Create").click(function () {
    $("#ErrorGender").empty();
    //validate data
    var CheckData = ValidateGender();
    if (CheckData == false) {
        $("#ErrorGender").append("Không Được Bỏ Trống !")
    } else {
        $("#Modal_Loading").show();
        $.ajax({
            url: "/Gender/CreateGenderPost/",
            type: "post",
            data: {
                Name: $("#TxtGenders").val()
            },
            success: function (result) {
                $("#Modal_Loading").hide();
                switch (result.id) {
                    case 1:
                        toastr.success("Thông Báo Thành Công!", "Thêm mới giới tính thành công");
                        $("#TxtGenders").val('');
                        break;
                    default:
                        toastr.error("Thông Báo Thất Bại!", "Thêm Mới giới tính thất bại");
                        break;
                }
            }
        })
    }
    return;
});

function ValidateGender() {
    var Data = $("#TxtGenders").val();
    if (Data.length == 0 || Data == '') {
        return false;
    } else {
        return true;
    }
}