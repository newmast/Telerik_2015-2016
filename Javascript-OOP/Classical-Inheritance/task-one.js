function solve() {

	var Person = (function() {

		function isValidName(name) {
			return /^[A-Z]{3,20}$/gi.test(name);
		}

		function isValidAge(age) {
			return (!isNaN(parseFloat(age)) && isFinite(age)) && (+age >= 0 && +age <= 150);
		}

		function Person(firstName, lastName, age) {
			this.firstname = firstName;
			this.lastname = lastName;
			this.age = age;
		}

		Object.defineProperty(Person.prototype, 'firstname', {
			get: function() {
				return this._firstName;
			},
			set: function(value) {
				if (!isValidName(value)) {
					throw new Error('Invalid name!');
				}
				this._firstName = value;
			}
		});

		Object.defineProperty(Person.prototype, 'lastname', {
			get: function() {
				return this._lastName;
			},
			set: function(value) {
				if (!isValidName(value)) {
					throw new Error('Invalid name!');
				}
				this._lastName = value;
			}
		});

		Object.defineProperty(Person.prototype, 'age', {
			get: function() {
				return this._age;
			},
			set: function(value) {
				if (!isValidAge(value)) {
					throw new Error('Invalid age!');
				}
				this._age = value;
			}
		});

		Object.defineProperty(Person.prototype, 'fullname', {
			get: function() {
				return this.firstname + ' ' + this.lastname;
			},
			set: function(value) {
				var names = value.split(' ');
				this.firstname = names[0];
				this.lastname = names[1];
			}
		});

		Person.prototype.introduce = function() {
			return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
		};

		return Person;
	}());

	return Person;
}