/*Write a script that selects all the div nodes that are directly inside other div elements
Create a function using querySelectorAll()
Create a function using getElementsByTagName()*/

function getDivsWithQSA() {
    var divs = document.querySelectorAll('div>div');

    for(var i = 0; i < divs.length; i++) {
        console.log(divs[i]);
    }
}

function getDivsWithGEBTN() {
    var allDivs = document.getElementsByTagName('div');

    var innerDivs = [];
    for (var i = 0, length = allDivs.length; i < length; i++) {
        innerDivs.push(allDivs[i].getElementsByTagName('div'));
    }

    for (var j = 0, length = innerDivs.length; j < length; j++) {
        console.log(innerDivs[j]);
    }
}