$(document).ready(function () {
    LoadInfomationAccount();
});

// LOAD INFOMATION ACCOUNT
function LoadInfomationAccount() {
    $.ajax({
        url: "/Account/DetailAccountPost",
        type: "post",
        data: {
            IdAccount: $("#IdAccount").val()
        },
        success: function (result) {
            $("#Txt_TimeCreate").val(result.createTime);
            $("#Txt_Email").val(result.email);
            $("#Txt_CustomerOrStaff").val(result.nameCustomerOfStaff);
            $("#Txt_DateCreate").val(result.createDate);
            $("#Txt_StaffOrChef").val(result.nameStaffOrChef);
            $("#Txt_IdStaff").val(result.idStaff);
        }
    })
}
