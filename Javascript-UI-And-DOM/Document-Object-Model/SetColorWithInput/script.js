/**
 * Created by newmast on 7/14/2015.
 */

function changeColor(inputId) {
    var inputField = document.getElementById(inputId);

    if (! inputField instanceof HTMLInputElement) {
        throw 'element is not an input field';
    }

    if (inputField.type != 'color') {
        throw 'input is not of type color';
    }

    document.body.style.backgroundColor = inputField.value;
}