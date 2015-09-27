//Problem 1. Exchange if greater
//
//Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
//As a result print the values a and b, separated by a space.

function ExchangeIfGreater(a, b) {
	if (a > b) {
		var c = b;
		b = a;
		a = c;
	}
	console.log('Exchange if Greater: ');
	console.log('a = ' + a + '; b = ' + b); // I can print them as the problem states, but it would be more confusing.
}

//Problem 2. Multiplication Sign
//
//Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

function MultiplicationSign(a, b, c) {
	console.log('Multiplication sign:');
	
	var sign;
	
	if (a == 0 | b == 0 | c == 0) {
		console.log('None (0)');
		return;
	}
	
	if (a > 0)
		if (b > 0)
			if (c > 0) sign = '+';
			else       sign = '-';
		else
			if (c > 0) sign = '-';
			else       sign = '+';
	
	if (b > 0)
		if (a > 0)
			if (c > 0) sign = '+';
			else       sign = '-';
		else
			if (c > 0) sign = '-';
			else       sign = '+';
	
	if (c > 0)
		if (b > 0)
			if (a > 0) sign = '+';
			else       sign = '-';
		else
			if (a > 0) sign = '-';
			else       sign = '+';
	
	console.log(sign);
}

//Problem 3. The biggest of Three
//
//Write a script that finds the biggest of three numbers.
//Use nested if statements.

function BiggestOfThree(a, b, c) {
	var biggestNumber = a;
	
	if (b >= c)
		if (b > a)
			biggestNumber = b;
	if (c >= b)
		if (c > a)
			biggestNumber = c;
	console.log("Biggest number of these three: ")
	console.log(biggestNumber);
}

//Problem 4. Sort 3 numbers
//
//Sort 3 real values in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

function SortNumbers(a, b, c) {
	var sorted;
	if (a > b)
		if (a > c)
			if (b > c) sorted = ""+a+" "+b+" "+c;
			else       sorted = ""+a+" "+c+" "+b;
		else 		   sorted = ""+c+" "+a+" "+b;
	else 
		if (c > a)
			if (b > c) sorted = ""+b+" "+c+" "+a;
			else       sorted = ""+c+" "+b+" "+a;
		else           sorted = ""+b+" "+a+" "+c;
	console.log('The numbers sorted:');
	console.log(sorted);
}

//Problem 5. Digit as word
//
//Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid input.
//Use a switch statement.

function DigitAsWord(digit) {
	var word;
	switch (digit) {
		case 0:
			word = 'zero';
			break;
		case 1:
			word = 'one';
			break;
		case 2:
			word = 'two';
			break;
		case 3:
			word = 'three';
			break;
		case 4:
			word = 'four';
			break;
		case 5:
			word = 'five';
			break;
		case 6:
			word = 'six';
			break;
		case 7:
			word = 'seven';
			break;
		case 8:
			word = 'eight';
			break;
		case 9:
			word = 'nine';
			break;
		default:
			word = 'not a digit';
			break;
	}
	console.log('Digit as word:');
	console.log(word);
}
//
//Problem 6. Quadratic equation
//
//Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Calculates and prints its real roots.
//Note: Quadratic equations may have 0, 1 or 2 real roots.

function QuadraticEquation(a, b, c) {
	console.log('Quadratic Equation');
	
	var D = b*b - 4*a*c;
	
	if ((D) < 0) {
		console.log('No real roots.');
	}
	else if (D == 0) {
		console.log('x1 = x2 = ' + ( (-b)/(2*a)) );
	}
	else {
		var x1 = (-b + Math.sqrt(D)) / (2 * a);
		var x2 = (-b - Math.sqrt(D)) / (2 * a);
		console.log('x1 = ' + x1);
		console.log('x2 = ' + x2);
	}
}

//Problem 7. The biggest of five numbers
//
//Write a script that finds the greatest of given 5 variables.

function GreatestOfFive(a, b, c, d, e) {
	var numbers = [a, b, c, d, e];
	
	var greatest = numbers[0];
	
	for(var i = 1; i < numbers.length; i++){
	    if(numbers[i] > greatest){
	        greatest = numbers[i];
	    }
	}
	console.log('Greatest of five numbers: ');
	console.log(greatest);
}

// 8. Write a script that converts a number in the range
// [0...999] to a text corresponding to its English
// pronunciation.

function NumberAsWord(a) {
	console.log('Number as word:');
	console.log(a + ' -> ' + getString(a));
}

function getString(number){
    var text = '';
    var hundreds = Math.floor(number / 100) % 10;
    var tens = Math.floor(number / 10) % 10;
    var ones = number % 10;

    if(!hundreds && !tens && !ones){
        return 'zero';
    }

    if(hundreds){
        text += getDigit(hundreds) + ' hundred';
    }

    if(tens || ones){
        if(text.length){
            text += ' and ';
        }

        if(tens){
            if(tens === 1){
                return text + getTeens(tens * 10 + ones);
            }
            text += getTens(tens);
        }

        if(ones){
            if(tens){
                text += '-';
            }

            text += getDigit(ones);
        }
    }

    return text;
}

function getDigit (digit) {
    switch(digit){
        case 0: return 'zero';
        case 1: return 'one';
        case 2: return 'two';
        case 3: return 'three';
        case 4: return 'four';
        case 5: return 'five';
        case 6: return 'six';
        case 7: return 'seven';
        case 8: return 'eight';
        case 9: return 'nine';
        default: return '';
    }
};

function getTens (digit) {
    switch(digit){
        case 2: return 'twenty';
        case 3: return 'thirty';
        case 4: return 'forty';
        case 5: return 'fifty';
        case 6: return 'sixty';
        case 7: return 'seventy';
        case 8: return 'eighty';
        case 9: return 'ninety';
        default: return '';
    }
};

function getTeens (digit) {
    switch(digit){
        case 10: return 'ten';
        case 11: return 'eleven';
        case 12: return 'twelve';
        case 13: return 'thirteen';
        case 14: return 'fourteen';
        case 15: return 'fifteen';
        case 16: return 'sixteen';
        case 17: return 'seventeen';
        case 18: return 'eighteen';
        case 19: return 'nineteen';
        default: return '';
    }
};