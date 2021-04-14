// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function checkPassword(form)
{
    if (form.Password.value != form.PasswordConfirm.value)
    {
        alert("Passwords do not match!");
        return false;
    }
    else
    {
        return true;
    }
}