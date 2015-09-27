//Problem 6. Most frequent number
//Write a script that finds the most frequent number in an array.

var array = [1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5];

var mostFreqNumber = 0;
var currentTimesMatched = 0;
var maxTimesMatched = 0;

for (var i = 0; i < array.length; i++) {
	currentTimesMatched = 0;
	for (var j = 0; j < array.length; j++) {
		if(array[i] == array[j])
		{
			currentTimesMatched+=1;
		}
	}
	if (currentTimesMatched > maxTimesMatched) {
		maxTimesMatched = currentTimesMatched;
		mostFreqNumber = array[i];
	}
}
console.log("Most frequent number:");
console.log(mostFreqNumber + '(' + (maxTimesMatched) + ' times)');