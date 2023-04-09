//Show password
function showPassword() {
    var x = document.getElementById("yourPassword");
    if (x.type === "password") {
        x.type = "text";
    } else {
        x.type = "password";
    }
}

//set change data
function changeEmail() {
    $("#ErrorEmail").empty();
    var resultEmail = CheckEmailVali();
    if (resultEmail == false) {
        $("#ErrorEmail").append("Vui lòng nhập vào Email");
    } else {

    }
    return;
}

function changePassword() {
    $("#ErrorPassword").empty();
    var resultPassword = CheckPasswordVali();
    if (resultPassword == false) {
        $("#ErrorPassword").append("Vui lòng nhập mật khẩu");
    } else {

    }
    return;
}

//validate Email
function CheckEmailVali(){
    var mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    var Acccount = $("#yourUsername").val();
    if(Acccount.match(mailformat)){
        return true;
    }else{
        return false;
    }
}

//Validate Password
function CheckPasswordVali(){
    var yourPassword = $("#yourPassword").val();
    if(yourPassword == ""){
        return false;
    }else{
        return true;
    }
}