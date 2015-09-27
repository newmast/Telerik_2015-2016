/*
 ### Problem 12. Generate list
 *	Write a function that creates a HTML `<ul>` using a template for every HTML `<li>`.
 *	The source of the list should be an array of elements.
 *	Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.
 _Example:_
 _HTML:_
 <div data-type="template" id="list-item">
 <strong>-{name}-</strong> <span>-{age}-</span>
 /div>
 _JavaScript:_
 var people = [{name: 'Peter', age: 14},…];
 var tmpl = document.getElementById('list-item').innerHtml;
 var peopleList = generateList(people, template);
 //peopleList = '<ul><li><strong>Peter</strong> <span>14</span></li><li>…</li>…</ul>'
 */


var people = [{name: 'Kiro Dimov  ', age: 25, hair: '  black ', sex: ' M '},
    {name: 'Minka Praznikova  ', age: 20, hair: '  blonde ', sex: ' F '}];
var tmpl = document.getElementById('list-item');
var t = 0;
var result = '<ul id="' + tmpl.id + '">';
for (var i = 0; i < people.length; i++) {
    result += '<li>';
    for (var child in people[i]) {
        result += '<' + tmpl.children[t].tagName.toLowerCase() + '>';
        result += people[i][tmpl.children[t].innerHTML.replace(/[-][{]/gi, '').replace(/[}][-]/gi, '')];
        result += '</' + tmpl.children[t++].tagName.toLowerCase() + '>';
    }
    result += '</li>';
}
result += '</ul>';
//replace the div html
tmpl.innerHTML = result;