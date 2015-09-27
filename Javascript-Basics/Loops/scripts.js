//Problem 1. Numbers
//
//Write a script that prints all the numbers from 1 to N.

function Numbers(n) {
	console.log('Numbers from 1..N: ');
	for (var i = 1; i <= n; i++) {
		console.log(i);
	}
}

//Problem 2. Numbers not divisible
//
//Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

function NumbersNotDivisible(n) {
	console.log('Numbers not divisible by 3 and seven:');
	for (var i = 1; i <= n; i++) {
		if (i % 21 != 0) {
			console.log(i + ' \t');
		}
	}
}

//Problem 3. Min/Max of sequence
//
//Write a script that finds the max and min number from a sequence of numbers.

function MinMaxOfSequence(sequence) {
	
	console.log('Min/Max of sequence:');
	
	var min = sequence[0];
	var max = sequence[0];
	
	for (var i = 0; i < sequence.length; i++) {
		if (sequence[i] > max) {
			max = sequence[i];
		}
		else if (sequence[i] < min) {
			min = sequence[i];
		}
	}
	console.log('Min of the sequence: ' + min);
	console.log('Max of the sequence: ' + max);
}

//Problem 4. Lexicographically smallest
//
//Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.

function LexicographicallySmallest(obj) {
	console.log('Lexicographically smallest/largest:');
	var min = 0;
    var max = 0;

    for(var property in obj){
        if(!min){
            min = property;
        }
        if(!max){
            max = property;
        }

        if(property < min){
            min = property;
        }

        if(property > max){
            max = property;
        }
    }

    console.log('min: ' + min);
    console.log('max: ' + max + '\n\r');

}