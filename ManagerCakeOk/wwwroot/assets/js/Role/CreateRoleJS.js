//create role
$("#Btn_Create").click(function () {
    $("#ErrorNameRole").empty();
    $("#ErrorSymbol").empty();
    $("#ErrorNote").empty();
    //validate name
    var CheckName = ValidateName();
    if (CheckName == false) {
        $("#ErrorNameRole").append("Vui Lòng Không Bỏ Trống!");
    } else {
        //validate Symbol
        var CheckSymbol = ValidateSymbolRole();
        if (CheckSymbol == false) {
            $("#ErrorSymbol").append("Vui Lòng Không Bỏ Trống!");
        } else {
            var CheckNote = ValidateNote();
            if (CheckNote == false) {
                $("#ErrorNote").append("Vui Lòng Không Bỏ Trống!");
            } else {
                $("#Modal_Loading").show();
                $.ajax({
                    url: "/Roles/CreateRole/",
                    type: "post",
                    data: {
                        NameRole: $("#TxtNameRole").val(),
                        Symbol: $("#TxtSymbol").val(),
                        Discription: $("#TxtNote").val()
                    },
                    success: function (result) {
                        $("#Modal_Loading").hide();
                        switch (result.id) {
                            case 1:
                                toastr.success("Thông Báo Thành Công", "Thêm Mới Quyền Hệ Thống Thành Công!");
                                $("#TxtNameRole").val('');
                                $("#TxtSymbol").val('');
                                $("#TxtNote").val('');
                                break;
                            default:
                                toastr.error("Thông Báo Lỗi", "Thêm Mới Quyền Thất Bại!");
                                break;
                        }
                    }
                })
            }
        }
    }
    return;
});

//validate Name Role
function ValidateName() {
    var Name = $("#TxtNameRole").val();
    if (Name.length == 0 || Name == '') {
        return false;
    } else {
        return true;
    }
};
//Validate Symbol Role
function ValidateSymbolRole() {
    var Symbol = $("#TxtSymbol").val();
    if (Symbol.length == 0 || Symbol == '') {
        return false;
    } else {
        return true;
    }
};
//validate Note
function ValidateNote() {
    var Note = $("#TxtNote").val();
    if (Note.length == 0 || Note == '') {
        return false;
    } else {
        return true;
    }
};