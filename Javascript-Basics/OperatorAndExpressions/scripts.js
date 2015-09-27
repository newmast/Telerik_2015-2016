function OddOrEven() {
	var input = document.getElementById('task-one-input').value;
	document.getElementById('task-one-answer').value = 'Number is ' + ( ( input % 2 == 0) ? 'even' : 'uneven' ) + '.';
}

function DivisibleBy7and5() {
	var input = document.getElementById('task-two-input').value;
	document.getElementById('task-two-answer').value = (input % 35 == 0);
}

function RectangleArea() {
	var width = document.getElementById('task-three-width').value;
	var height = document.getElementById('task-three-height').value;
	document.getElementById('task-three-answer').value = width * height;
}

function ThirdDigit() {
	var input = document.getElementById('task-four-input').value;
	document.getElementById('task-four-answer').value = ((input/100) | 0) % 10 == 7;
}

function ThirdBit() {
	var input = document.getElementById('task-five-input').value;
	document.getElementById('task-five-answer').value = ( (input >> 3) & 1 );
}

function PointInCircle() {
	var x = document.getElementById('task-six-x').value;
	var y = document.getElementById('task-six-y').value;
	document.getElementById('task-six-answer').value = ( Math.sqrt(x*x + y*y) <= 5 );
}

function IsPrime() {
	var input = document.getElementById('task-seven-input').value;
	
	if (input == 1) {
		document.getElementById('task-seven-answer').value = 'Number is not prime';
		return;
	}
	
	for (var index = 2; index < input-1; index++) {
		if (input % index == 0) {
			document.getElementById('task-seven-answer').value = 'Number is not prime';
			return;
		}
	}
	document.getElementById('task-seven-answer').value = 'Number is prime';
}

function TrapezoidArea() {
	var a = (document.getElementById('task-eight-a').value) | 0;
	var b = (document.getElementById('task-eight-b').value) | 0;
	var h = (document.getElementById('task-eight-h').value) | 0;
	
	document.getElementById('task-eight-answer').value = ((a+b)/2) * h;
}

function InCircleOutRectangle() {
	var x = (document.getElementById('task-nine-x').value) | 0;
	var y = (document.getElementById('task-nine-y').value) | 0;

    var isInCircle = Math.sqrt((x * x) + (y * y)) <= 3;
    var isOutofRectangle = ((x > -1 || x > 5) && (y > -1 || y > 1));

    var isInCircleOutRectangle = isInCircle && isOutofRectangle;
	document.getElementById('task-nine-answer').value = isInCircleOutRectangle;
}