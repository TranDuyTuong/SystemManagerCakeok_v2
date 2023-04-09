//confim create account staff 
$("#btn_ConfirmCreate").click(function(){
    $("#ErrorName").empty();
    $("#ErrorBirthday").empty();
    $("#ErrorPhone").empty();
    $("#ErrorAddress").empty();
    $("#ErrorStaffCustomer").empty();
    $("#ErrorGender").empty();
    $("#ErrorStaffChef").empty();
    $("#ErrorCity").empty();
    $("#ErrorDistrict").empty();
    $("#ErrorDMarriage").empty();
    $("#ErrorEmail").empty();
    $("#ErrorPassword").empty();
    $("#ErrorAgainPassword").empty();

    //full name
    var FullName = $("#Txt_Name").val();
    if(FullName == ""){
        $("#ErrorName").append("Không Bỏ Trống !");
        toastr.error("Thông Báo Lỗi", "Họ tên không bỏ trống!");
        return;
    }

    //Birthday
    var Birthday = $("#Txt_Birthday").val();
    if(Birthday == ""){
        $("#ErrorBirthday").append("Không Bỏ Trống !");
        toastr.error("Thông Báo Lỗi", "Ngày sinh không bỏ trống!");
        return;
    }

    //phone
    var Phone = $("#Txt_Phone").val();
    if(Phone == ""){
        $("#ErrorPhone").append("Không Bỏ Trống !");
        toastr.error("Thông Báo Lỗi", "Số điện thoại không bỏ trống!");
        return;
    }

    //Address 
    var Address = $("#Txt_address").val();
    if(Address == ""){
        $("#ErrorAddress").append("Không Bỏ Trống !");
        toastr.error("Thông Báo Lỗi", "Địa chỉ không bỏ trống!");
        return;
    }

    //select staff and customer
    var SelectStaffCustomer = $("#SelectStaffCustomer").val();
    if(SelectStaffCustomer == 0){
        $("#ErrorStaffCustomer").append("Không Bỏ Trống !");
        toastr.error("Thông Báo Lỗi", "Lựa chọn nhân viên hay khách hàng!");
        return;
    }

    //select gender
    var SelectGender = $("#SelectGender").val();
    if(SelectGender == 0){
        $("#ErrorGender").append("Không Bỏ Trống !");
        toastr.error("Thông Báo Lỗi", "Lựa chọn giới tính!");
        return;
    }

    //select staff and chef
    var SelectStaffChef = $("#SelectStaffChef").val();
    if(SelectStaffChef == 0){
        $("#ErrorStaffChef").append("Không Bỏ Trống !");
        toastr.error("Thông Báo Lỗi", "Lựa chọn nhân viên hay đầu bếp!");
        return;
    }

    //select city
    var SelectCity = $("#SelectCity").val();
    if(SelectCity == 0){
        $("#ErrorCity").append("Không Bỏ Trống !");
        toastr.error("Thông Báo Lỗi", "Lựa chọn tỉnh / thành phố!");
        return;
    }

    //select district
    var SelectDistrict = $("#SelectDistrict").val();
    if(SelectDistrict == 0){
        $("#ErrorDistrict").append("Không Bỏ Trống !");
        toastr.error("Thông Báo Lỗi", "Lựa chọn quận / huyện!");
        return;
    }

    //select Marriage
    var SelectMarriage = $("#SelectMarrige").val();
    if(SelectMarriage == 0){
        $("#ErrorDMarriage").append("Không Bỏ Trống !");
        toastr.error("Thông Báo Lỗi", "Lựa chọn tình trạng hôn nhân!");
        return;
    }

    //Email
    var Email = $("#TxtEmail").val();
    if(Email == ""){
        $("#ErrorEmail").append("Không Bỏ Trống !");
        toastr.error("Thông Báo Lỗi", "Email không bỏ trống!");
        return;
    }

    //Password
    var Password = $("#TxtPassWord").val();
    if(Password == ""){
        $("#ErrorPassword").append("Không Bỏ Trống !");
        toastr.error("Thông Báo Lỗi", "Mật khẩu không bỏ trống!");
        return;
    }

    // Again Password
    var AgainPassword = $("#TxtAgainPassword").val();
    if(AgainPassword == ""){
        $("#ErrorAgainPassword").append("Không Bỏ Trống !");
        toastr.error("Thông Báo Lỗi", "nhắc lại mật khẩu không bỏ trống!");
        return;
    }

    //show modal upload image
    $("#M_UploadFileConfim").show();
});

//view avata satff
var Save_Url;
//create url for image
document.getElementById('formFile').onchange = e => {
    $("#ViewAvata").empty();

	if (Save_Url != null) {
		URL.revokeObjectURL(Save_Url);
	}
	const file = e.target.files[0]; // this Object holds a reference to the file on disk
	const url = URL.createObjectURL(file); // this points to the File object we just created
	Save_Url = url;
    var DivImg = '<img src="'+ url + '" id="img_NewAvata" style="width: -webkit-fill-available;"/>';
	$("#ViewAvata").append(DivImg);
	return;
};

$("#Btn_Close").click(function(){
    $("#M_UploadFileConfim").hide();
})
