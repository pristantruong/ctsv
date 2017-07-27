var input = document.getElementById("name");

input.oninvalid = function (event) {
    event.target.setCustomValidity("Tên Sinh Viên không được để trống");
}