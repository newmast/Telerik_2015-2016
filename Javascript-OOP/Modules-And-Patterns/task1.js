function solve() {
	var Course = {
		
		init: function(title, presentations) {
			this.title = title;
			this.presentations = presentations;
			return this;
		},
		addStudent: function(fullName) {
			var student = fullName;
			
			student.id = this.students.length + 1;
			this.students.push(student);
			
			return student.id;
		},
		gellAllStudents: function() {
			return this.students.slice;
		},
		submitHomework: function(studentID, homeworkID) {
		},
		pushExamResults: function(results) {
			
		},
		getTopStudents: function() {
		}
	};
	
	Object.defineProperty(Course, 'title', {
			get: function() {
				return Course._title;
			},
			set: function(value) {
				Course._title = value;
			}
	});
	
	Object.defineProperty(Course, 'presentations', {
			get: function() {
				return Course._presentations;
			},
			set: function(value) {
				Course._presentations = value;
			}
	});
	Object.defineProperty(Course, 'students', {
			get: function() {
				return Course._students;
			},
			set: function(value) {
				Course._students = value;
			}
	});
}
