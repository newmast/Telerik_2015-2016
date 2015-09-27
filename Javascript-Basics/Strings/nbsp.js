//### Problem 5. nbsp
//*	Write a function that replaces non breaking white-spaces in a text with `&nbsp`;
//


var text = 'Why are you manipulating the HTML directly?It\'s much safer (and usually easier)' +
    ' to work through the DOM. Find the right <table>,' + +' then the appropriate <a> tags in the table using jQuery or a cross-browser selector ';


function replaceNbsps(text) {

    for (var i = 0; i < text.length; i++) {
        text = text.replace(' ', '&nbsp');
    }
    return text;
}
console.log(replaceNbsps(text));