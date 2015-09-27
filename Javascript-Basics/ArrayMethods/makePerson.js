function Person(firstName, lastName, age, gender) {
	this.firstName = firstName;
	this.lastName = lastName;
	this.age = age;
	this.gender = gender;
}

var people = Array.apply(null, new Array(10))
        .map(function(_, index){
            return {
                firstName: index,
                lastName: index,
                age: 17 + index,
                male: Boolean(index % 2)};
            }
        );

function greaterThan18 (peopleList) {
	return peopleList.every(function(person) { return person.age >= 18; });
}

function printUnderAge (peopleList) {
	var underAged = peopleList.filter(function(person) { return person.age < 18; });
	underAged.forEach(function(person) { console.log(person); });
}

function averageFemaleAge (peopleList) {
	var females = peopleList.filter(function(person) { return person.male === false; });
	var totalFemaleAge = females.reduce(function(sum, person) { return sum + person.age;}, 0);
	return totalFemaleAge / females.length;
}

function getNamesOfYoungestMale (people) {
    var youngestMale =  people.sort(function (a, b) {return a.age - b.age;})
        .find(function(person) {return !person.isFemale;});

    return youngestMale.firstName + ' ' + youngestMale.lastName +
        '(' + youngestMale.age + ', ' + (youngestMale.isFemale ? 'F' : 'M') + ')';
}

var groups = people.reduce(function (gr, person) {
    var letter = person.firstName[0];

    if (gr[letter]) {
        gr[letter].push(person);
    } else {
        gr[letter] = [person];
    }

    return gr;
}, {});