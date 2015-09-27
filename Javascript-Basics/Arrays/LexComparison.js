//Problem 2. Lexicographically comparison
//
//Write a script that compares two char arrays lexicographically (letter by letter).

console.log('Problem 2. Lexicographically comparison');

var wordOne = ['a', 'b', 'c', 'd'];
var wordTwo = ['b', 'c', 'd', 'e'];

var length = Math.min(wordOne.length, wordTwo.length);

for (var i = 0; i < length; i++) {
	if(wordOne[i] > wordTwo[i]) {
		console.log('Lexicographically bigger: ' + wordOne);
		break;
	}
	if(wordOne[i] < wordTwo[i]) {
		console.log('Lexicographically bigger: ' + wordTwo);
		break;
	}
}