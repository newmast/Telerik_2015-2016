var library = (function() {

	var title,
	    author,
	    ISBN,
	    categories = [],
	    id = 2,
	    categoryId = 2;

	function addNewBook(book, category) {
		this.title = book.title;
		this.author = book.author;
		this.ISBN = book.ISBN;
		this.id = ++id;

		if (categories[category] === undefined) {
			categories[category] = [];
			categories[category].id = ++categoryId;
		}

		categories[category].push(book);
	}

	function listAllBooks() {
		return categories;
	}

	return {
		books: {
			add: addNewBook,
			list: listAllBooks
		}
	};

}());
