$(document).ready(function () {
    LoadData();
});

var ErrorHtml = "Vui lòng không bỏ trống!";
var HtmlChoose = "Vui lòng chọn";
var Html_NotifiError = "Thông Báo Lỗi";
var Html_NotifiSuccess = "Thông Báo Thành Công";
var Html_DetailError = "Đã có lỗi xảy ra!";

//load data
function LoadData() {
    //empty form error
    $("#ErrorMarriage").empty();
    $("#ErrorCity").empty();
    $("#ErrorDistrict").empty();
    $("#ErrorGender").empty();
    $("#ErrorStaffChef").empty();
    $("#ErrorRole").empty();

    //-------------------------
    $("#Select_Marriage").empty();
    $("#Select_City").empty();
    $("#Select_Gender").empty();
    $("#Select_StaffChef").empty();
    $("#Select_Role").empty();
    $.ajax({
        url: "/Account/CreateAccountGet",
        type: "get",
        success: function (result) {
            //marriage
            var HtmlMarraige = '';
            HtmlMarraige = '<option selected value="0">' + HtmlChoose + '</option>';
            $("#Select_Marriage").append(HtmlMarraige);
            $.each(result.l_Marriage, function (key, item) {
                var Html = '';
                Html = '<option value="' + item.id + '">' + item.name + '</option>';
                $("#Select_Marriage").append(Html);
            });

            //City
            var HtmlCity = '';
            HtmlCity = '<option selected value="0">' + HtmlChoose + '</option>';
            $("#Select_City").append(HtmlCity);
            $.each(result.l_City, function (key, item) {
                var Html = '';
                Html = '<option value="' + item.id + '">' + item.nameCity + '</option>';
                $("#Select_City").append(Html);
            });

            //Gender
            var HtmlGender = '';
            HtmlGender = '<option selected value="0">' + HtmlChoose + '</option>';
            $("#Select_Gender").append(HtmlGender);
            $.each(result.l_Gender, function (key, item) {
                var Html = '';
                Html = '<option value="' + item.id + '">' + item.name + '</option>';
                $("#Select_Gender").append(Html);
            });

            //Staff or Chef
            var HtmlStaffChef = '';
            HtmlStaffChef = '<option selected value="0">' + HtmlChoose + '</option>';
            $("#Select_StaffChef").append(HtmlStaffChef);
            $.each(result.l_StaffChef, function (key, item) {
                var Html = '';
                Html = '<option value="' + item.id + '">' + item.name + '</option>';
                $("#Select_StaffChef").append(Html);
            });

            //Role
            var HtmlRole = '';
            HtmlRole = '<option selected value="0">' + HtmlChoose + '</option>';
            $("#Select_Role").append(HtmlRole);
            $.each(result.l_Role, function (key, item) {
                var Html = '';
                Html = '<option value="' + item.idRole + '">' + item.nameRole + '</option>';
                $("#Select_Role").append(Html);
            });
        }
    })
}

//validate data input
function Vali_Marriage() {
    var Item = $("#Select_Marriage").val();
    if (Item == 0) {
        return false;
    } else {
        return true;
    }
}
function Vali_City() {
    var Item = $("#Select_City").val();
    if (Item == 0) {
        return false;
    } else {
        return true;
    }
}
function Vali_Gender() {
    var Item = $("#Select_Gender").val();
    if (Item == 0) {
        return false;
    } else {
        return true;
    }
}
function Vali_StaffChef() {
    var Item = $("#Select_StaffChef").val();
    if (Item == 0) {
        return false;
    } else {
        return true;
    }
}
function Vali_Role() {
    var Item = $("#Select_Role").val();
    if (Item == 0) {
        return false;
    } else {
        return true;
    }
}

//Validate Infomation Account
function Vali_Email() {
    var item = $("#TxtEmail").val();
    if (item.length == 0 || item == '') {
        return false;
    } else {
        var validRegex = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
        if (item.match(validRegex)) {
            return true;
        } else {
            return -1;
        }
    }
}
function Vali_PassWord() {
    var item = $("#TxtPassWord").val();
    if (item.length == 0 || item == '') {
        return false;
    } else {
        return true;
    }
}
function Vali_PassWordConFirm() {
    var item = $("#TxtPassWordConfirm").val();
    if (item.length == 0 || item == '') {
        return false;
    } else {
        return true;
    }
}
function Vali_Phone() {
    var item = $("#TxtPhone").val();
    if (item.length == 0 || item == '') {
        return false;
    } else {
        return true;
    }
}
function Vali_File() {
    var item = $("#TxtFile").val();
    if (item.length == 0 || item == '') {
        return false;
    } else {
        return true;
    }
}

//validate infomation staff
function Vali_NameStaff() {
    var item = $("#TxtNameSatff").val();
    if (item.length == 0 || item == '') {
        return false;
    } else {
        return true;
    }
}
function Vali_BirthdayStaff() {
    var item = $("#TxtBirthday").val();
    if (item.length == 0 || item == '') {
        return false;
    } else {
        return true;
    }
}
function Vali_AddressStaff() {
    var item = $("#TxtAddress").val();
    if (item.length == 0 || item == '') {
        return false;
    } else {
        return true;
    }
}

//validate selection 
$("#Select_Marriage").change(function () {
    $("#ErrorMarriage").empty();
    var item = $("#Select_Marriage").val();
    if (item == 0) {
        $("#ErrorMarriage").append("Vui Lòng Chọn Tình Trạng Hôn Nhân!");
    }
    return;
});

$("#Select_City").change(function () {
    $("#ErrorCity").empty();
    var item = $("#Select_City").val();
    if (item == 0) {
        $("#ErrorDistrict").empty();
        $("#ErrorCity").append("Vui Lòng Chọn Tỉnh/Tp!");
        $("#Select_District").empty();
        $("#Select_District").prop("disabled", true);
        var HtmlDefaul = '<option selected value="0">Vui lòng chọn</option>';
        $("#Select_District").append(HtmlDefaul);
    } else {
        //call all distric by this city
        $.ajax({
            url: "/Districts/GetAllDistricById",
            type: "get",
            data: {
                IdCity: item
            },
            success: function (result) {
                $("#Select_District").empty();
                $("#Select_District").prop("disabled", false);
                var HtmlDefaul = '<option selected value="0">Vui lòng chọn</option>';
                $("#Select_District").append(HtmlDefaul);
                $.each(result, function (key, item) {
                    var Html = "";
                    Html += '<option value="' + item.id + '">' + item.name + '</option>';
                    $("#Select_District").append(Html);
                })
            }
        })
    }
    return;
})

$("#Select_District").change(function () {
    $("#ErrorDistrict").empty();
    var item = $("#Select_District").val();
    if (item == 0) {
        $("#ErrorDistrict").append("Vui Lòng Chọn Quận/Huyện!");
    }
    return;
})

$("#Select_Gender").change(function () {
    $("#ErrorGender").empty();
    var item = $("#Select_Gender").val();
    if (item == 0) {
        $("#ErrorGender").append("Vui Lòng Chọn Giới Tính!");
    }
    return;
})

$("#Select_StaffChef").change(function () {
    $("#ErrorStaffChef").empty();
    var item = $("#Select_StaffChef").val();
    if (item == 0) {
        $("#ErrorStaffChef").append("Vui Lòng Chọn Nhân Viên Hoặc Đầu Bếp!");
    }
    return;
})

$("#Select_Role").change(function () {
    $("#ErrorRole").empty();
    var item = $("#Select_Role").val();
    if (item == 0) {
        $("#ErrorRole").append("Vui Lòng Chọn Quyền!");
    }
    return;
})

//Show Password
function ShowPassword() {
    var x = document.getElementById("TxtPassWord");
    if (x.type === "password") {
        x.type = "text";
    } else {
        x.type = "password";
    }
}

function ShowPasswordConfirm() {
    var x = document.getElementById("TxtPassWordConfirm");
    if (x.type === "password") {
        x.type = "text";
    } else {
        x.type = "password";
    }
}

//Check password special character
function CheckSpecialCharacter() {
    var Item = $("#TxtPassWord").val();
    var R_Expression = /^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{6,16}$/;
    if (!R_Expression.test(Item)) {
        EmptyNotification();
        $("#ErrorPassword").append("Mật khẩu phải có chứa số và ký tự đặt biệt");
        return false;
    } else {
        return true;
    }
}

//check password UpperCake
function CheckUpperCake() {
    var Item = $("#TxtPassWord").val();
    if (Item.search(/[A-Z]/) == -1) {
        EmptyNotification();
        $("#ErrorPassword").append("Mật khẩu phải có chứa chữ in hoa");
        return false;
    } else {
        return true;
    }
}

//check password and confirm password
function CheckPasswordAndConfirmPassword() {
    EmptyNotification();
    var Item = $("#TxtPassWord").val();
    var ItemComfirm = $("#TxtPassWordConfirm").val();
    if (Item == ItemComfirm) {
        return true;
    } else {
        $("#ErrorPasswordConfirm").append("2 mật khẩu phải khớp với nhau");
        return false;
    }
}

//check was select item 
function F_SelectCity() {
    var item = $("#Select_City").val();
    if (item == 0) {
        return false;
    } else {
        return true;
    }
};

function F_SelectMarriage() {
    var item = $("#Select_Marriage").val();
    if (item == 0) {
        return false;
    } else {
        return true;
    }
};

function F_SelectDistrict() {
    var item = $("#Select_District").val();
    if (item == 0) {
        return false;
    } else {
        return true;
    }
};

function F_SelectGender() {
    var item = $("#Select_Gender").val();
    if (item == 0) {
        return false;
    } else {
        return true;
    }
};

function F_SelectStaffChef() {
    var item = $("#Select_StaffChef").val();
    if (item == 0) {
        return false;
    } else {
        return true;
    }
};

function F_SelectRole() {
    var item = $("#Select_Role").val();
    if (item == 0) {
        return false;
    } else {
        return true;
    }
}

//Show Image Staff choose in Computer
var Save_Url;
//create url for image
document.getElementById('TxtFile').onchange = e => {
    $("#TxtShowAvata").empty();
    if (Save_Url != null) {
        URL.revokeObjectURL(Save_Url);
    }
    const file = e.target.files[0]; // this Object holds a reference to the file on disk
    console.log(file);
    const url = URL.createObjectURL(file); // this points to the File object we just created
    Save_Url = url;
    var HtmlImg = ' <img src="' + url + '" style="width: 30%;" />'
    $("#TxtShowAvata").append(HtmlImg);
    return;
};

//Empty Notification Error
function EmptyNotification() {
    $("#ErrorEmail").empty();
    $("#ErrorPassword").empty();
    $("#ErrorPasswordConfirm").empty();
    $("#ErrorPhone").empty();
    $("#ErrorFile").empty();
    $("#ErrorFullName").empty();
    $("#ErrorBirthday").empty();
    $("#ErrorMarriage").empty();
    $("#ErrorCity").empty();
    $("#ErrorDistrict").empty();
    $("#ErrorGender").empty();
    $("#ErrorStaffChef").empty();
    $("#ErrorRole").empty();
    $("#ErrorAddress").empty();
};

//Create Staff
$("#Btn_Create").click(function () {
    //Empty Notification Error
    EmptyNotification()

    //Check Validate Infomation Account
    var Email = Vali_Email();
    if (Email == false) {
        $("#ErrorEmail").append(ErrorHtml);
        toastr.error(Html_NotifiError, "Đã có lỗi xảy ra!");
        return;
    }
    if (Email == -1) {
        $("#ErrorEmail").append("Email không hợp lệ và đúng cú pháp!");
        toastr.error(Html_NotifiError, Html_DetailError);
        return;
    }

    var Password = Vali_PassWord();
    if (Password == false) {
        $("#ErrorPassword").append(ErrorHtml);
        toastr.error(Html_NotifiError, Html_DetailError);
        return;
    }

    var PassWordSpesical = CheckSpecialCharacter();
    if (PassWordSpesical == false) {
        toastr.error(Html_NotifiError, Html_DetailError);
        return;
    }

    var PassWordCharacter = CheckUpperCake();
    if (PassWordCharacter == false) {
        toastr.error(Html_NotifiError, Html_DetailError);
        return;
    }

    var Password_Confirm = Vali_PassWordConFirm();
    if (Password_Confirm == false) {
        $("#ErrorPasswordConfirm").append(ErrorHtml);
        toastr.error(Html_NotifiError, Html_DetailError);
        return;
    }

    var CheckTwoPassword = CheckPasswordAndConfirmPassword();
    if (CheckTwoPassword == false) {
        toastr.error(Html_NotifiError, Html_DetailError);
        return;
    }

    var Phone = Vali_Phone();
    if (Phone == false) {
        $("#ErrorPhone").append(ErrorHtml);
        toastr.error(Html_NotifiError, Html_DetailError);
        return;
    }

    var File = Vali_File();
    if (File == false) {
        $("#ErrorFile").append(ErrorHtml);
        toastr.error(Html_NotifiError, Html_DetailError);
        return;
    }

    //check Validate Informcation Staff
    var NameStaff = Vali_NameStaff();
    if (NameStaff == false) {
        $("#ErrorFullName").append(ErrorHtml);
        toastr.error(Html_NotifiError, Html_DetailError);
        return;
    }

    var BirthdayStaff = Vali_BirthdayStaff();
    if (BirthdayStaff == false) {
        $("#ErrorBirthday").append(ErrorHtml);
        toastr.error(Html_NotifiError, Html_DetailError);
        return;
    }

    var AddressStaff = Vali_AddressStaff();
    if (AddressStaff == false) {
        $("#ErrorAddress").append(ErrorHtml);
        toastr.error(Html_NotifiError, Html_DetailError);
        return;
    }

    //check select item
    var Marriage = F_SelectMarriage();
    if (Marriage == false) {
        toastr.error(Html_NotifiError, "Vui lòng chọn tình trạng hôn nhân!");
        return;
    }
    var City = F_SelectCity();
    if (City == false) {
        toastr.error(Html_NotifiError, "Vui lòng chọn tỉnh/Tp!");
        return;
    }
    var District = F_SelectDistrict();
    if (District == false) {
        toastr.error(Html_NotifiError, "Vui lòng chọn quận/huyện!");
        return;
    }
    var Gender = F_SelectGender();
    if (Gender == false) {
        toastr.error(Html_NotifiError, "Vui lòng chọn giới tính!");
        return;
    }
    var StaffOrChef = F_SelectStaffChef();
    if (StaffOrChef == false) {
        toastr.error(Html_NotifiError, "Vui lòng chọn nhân viên hoặc đầu bếp!");
        return;
    }
    var Role = F_SelectRole();
    if (Role == false) {
        toastr.error(Html_NotifiError, "Vui lòng chọn quyền!");
        return;
    }

    //set data create
    var files = $("#TxtFile").prop("files")
    var formData = new FormData();
    for (var i = 0; i < files.length; i++) {
        formData.append("ImageStaff", files[i]);
    }
    var Staff = {
        Password: $("#TxtPassWord").val(),
        IDCustomerOrStaff: 1,
        Email: $("#TxtEmail").val(),
        UserName: $("#TxtEmail").val(),
        EmailConfirmed: $("#TxtEmail").val(),
        PhoneNumber: $("#TxtPhone").val(),
        FullName: $("#TxtNameSatff").val(),
        Birthday: $("#TxtBirthday").val(),
        Address: $("#TxtAddress").val(),
        IdMarriage: $("#Select_Marriage").val(),
        IdCity: $("#Select_City").val(),
        IdDistrict: $("#Select_District").val(),
        IdGender: $("#Select_Gender").val(),
        IdStaffOrChef: $("#Select_StaffChef").val(),
        IdRole: $("#Select_Role").val()
    }
    formData.append("CreateStaff", JSON.stringify(Staff));
    $("#Modal_Loading").show();
    $.ajax({
        url: "/Account/CreateAccountGet",
        type: "post",
        data: formData,
        contentType: false,
        processData: false,
        success: function (result) {
            $("#Modal_Loading").hide();
            switch (result.id) {
                case 1:
                    toastr.error(Html_NotifiError, "Email Đã Được Dùng Đăng Ký, Vui Lòng Chọn Email Mới!");
                    break;
                case 2:
                    toastr.error(Html_NotifiError, "Số Điện Đã Được Dùng Đăng Ký, Vui Lòng Chọn Số Điện Thoại Mới!");
                    break;
                case 3:
                    toastr.success(Html_NotifiSuccess, "Tạo Mới Một Tài Khoản Nhân Viên Thành Công!");
                    $("#TxtEmail").val('');
                    $("#TxtPassWord").val('');
                    $("#TxtPassWordConfirm").val('');
                    $("#TxtPhone").val('');
                    $("#TxtFile").val('');
                    $("#TxtNameSatff").val('');
                    $("#TxtBirthday").val('');
                    $("#TxtAddress").val('');
                    $("#TxtShowAvata").empty();
                    $("#Select_District").empty();
                    $("#Select_District").prop("disabled", true);
                    var HtmlDefaul = '<option selected value="0">Vui lòng chọn</option>';
                    $("#Select_District").append(HtmlDefaul);
                    LoadData();
                    break;
                case 4:
                    toastr.error(Html_NotifiError, "Không Tìm Thấy Quyền Này, Vui Lòng Kiểm Tra Lại!");
                    break;
                default:
                    toastr.error(Html_NotifiError, "Đăng Ký Thất Bại, Vui Lòng Kiểm Tra Lại!");
                    break;
            }
            return;
        }
    })
});