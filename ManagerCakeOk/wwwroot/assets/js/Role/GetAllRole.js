$(document).ready(function () {
    LoadRole();
});

//load role
function LoadRole() {
    $("#BodyData").empty();
    var count = 0;
    $.ajax({
        url: "/Roles/GetAllRoles/",
        type: "get",
        success: function (result) {
            $.each(result, function (key, item) {
                count++;
                var Html = '';
                Html += '<tr id="' + item.idRole + '">';
                Html += '<th scope="row">' + count + '</th>';
                Html += '<td>' + item.nameRole + '</td>';
                Html += '<td>' + item.symbol + '</td>';
                Html += '<td>' + item.createDate + '</td>';
                Html += '<td><a href="/Roles/PageDetailRole/?Id=' + item.idRole + '" data-bs-toggle="tooltip" data-bs-placement="top" title="Xem nhân viên thuộc quyền này">'
                    + '<i class="fas fa-folder-open"></i></a> | '
                    + ' <button style="border: none; background: none; color: blue;" name="BtnEditCity" data-bs-toggle="tooltip" data-bs-placement="top" title="Cập Nhật" />'
                    + '<i class="fas fa-edit"></i></a>'
                    + '</td>';
                Html += '</tr>';
                $("#BodyData").append(Html);
            })
        }
    })
};

//reload
function ReloadPage() {
    window.location.reload();
}