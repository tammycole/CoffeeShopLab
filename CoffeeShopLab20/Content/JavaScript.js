function checkPass() {
    //Store the password field objects into variables ...
    var password = document.getElementById(`password`);
    var passwordconfirmation = document.getElementById(`passwordconfirmation`);
    //Store the Confimation Message Object ...
    var message = document.getElementById('confirmMessage');
    //Compare the values in the password field 
    //and the confirmation field
    if (password.value === passwordconfirmation.value) {
        //The passwords match. 
        message.innerHTML = "Passwords Match!"
    } else {
        //The passwords do not match.
        message.innerHTML = "Passwords Do Not Match!"
    }
}  