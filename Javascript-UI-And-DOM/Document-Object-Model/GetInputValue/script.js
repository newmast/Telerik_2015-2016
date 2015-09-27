/**
 * Created by newmast on 7/14/2015.
 */

function getInputValue(elementID) {
    var inputField = document.getElementById(elementID);

    if ( !(inputField instanceof HTMLInputElement)) {
        throw 'element isnt an input field';
    }

    console.log(inputField.value);
}