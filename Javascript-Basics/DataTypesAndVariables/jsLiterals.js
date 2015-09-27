//Problem 1. JavaScript literals
//
//Assign all the possible JavaScript literals to different variables.
//
//Problem 3. Typeof variables
//
//Try typeof on all variables you created.
//Problem 4. Typeof null
//
//Create null, undefined variables and try typeof on them.

var stringVariable = 'string';
var integerVariable = 25;
var floatingPointVariable = 13.37;
var arrayVariable = [1, 2, 3, 4];
var functionVariable = function () {
	return;
}
var objectVariable = {
	firstValue: 5,
	secondValue: 'text'
};

var variableList = [stringVariable, integerVariable, floatingPointVariable, functionVariable, arrayVariable, objectVariable];

console.log('TYPEOF OF ALL VARIABLES: ');

for (var i = 0; i < variableList.length; i++) {
	console.log(typeof(variableList[i]));
}

console.log('TYPE OF NULL AND UNDEFINED:');

var nullVariable = null;
var undefinedVariable = undefined;

console.log('null: ' + typeof(nullVariable));
console.log('undefined: ' + typeof(undefinedVariable));