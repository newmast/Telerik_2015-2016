function solve() {
	var domElement = (function (){

		function isValidType(type){
            if(typeof type !== 'string'){
                throw new Error('Invalid string argument.');
            }
            
            return /^[A-Z0-9]+$/i.test(type);
        }

        function isValidAttributeName(name){
            if(typeof name !== 'string'){
                throw new Error('Invalid string argument.');
            }
            
            return /^[A-Z0-9\-]+$/i.test(name);
        }

        function getSortedAttributesString(attributes){
            var attributesString = '';
            var keys = [];

            for(var key in attributes){
                keys.push(key);
            }

            keys.sort();
            var currentKey;

            for(var ind = 0, len = keys.length; ind < len; ind += 1){
                currentKey = keys[ind];
                attributesString += ' ' + currentKey + '="' + attributes[currentKey] + '"';
            }

            return attributesString;
        }

		var domElement = {

			init: function(value) {
				this.type = value;
				this.children = [];
				this.attributes = [];
				return this;
			},
			get type() {
				return this._type;
			},
			set type(value) {
				if (!isValidType(value)) {
					throw new Error();
				}

				this._type = value;
			},
			appendChild: function(value) {
				this.children.push(value);

				return this;
			},
			get innerHTML(){
                var innerHtml = '<' + this.type;
                var attributesString = getSortedAttributesString(this.attributes);
                innerHtml += attributesString + '>';

                var child;
                for(var ind = 0, len = this.children.length; ind < len; ind += 1){
                    child = this.children[ind];

                    if(typeof child === 'string') {
                        innerHtml += child;
                    } else {
                        innerHtml += child.innerHTML;
                    }
                }

                if (this.content !== undefined) {
                	innerHtml += this.content;
                }

                innerHtml += '</' + this.type + '>';

                return innerHtml;
            },
			addAttribute: function(name, value) {
				if(!isValidAttributeName(name)){
                    throw new Error('Invalid attribute name.');
                }

				this.attributes[name] = value;

				return this;
			},
			removeAttribute: function(attribute) {
                if(!this.attributes[attribute]){
                    throw new Error('This attribute does not exist.');
                }

                delete this.attributes[attribute];

                return this;
            }
		};

		return domElement;
	}());

	var style = Object.create(domElement)
					.init('style')
					.appendChild('#big {\nfont-size: 144pt;\n}'),
				link = Object.create(domElement)
					.init('link')
					.addAttribute('src', 'css/fancy.css'),
				meta = Object.create(domElement)
					.init('meta')
					.addAttribute('charset', 'utf-8'),
				title = Object.create(domElement)
					.init('title')
					.appendChild('Super-Mega awesome S173'),
				script = Object.create(domElement)
					.init('script')
					.addAttribute('lang', 'javascript')
					.appendChild('function init(){}'),
				head = Object.create(domElement)
					.init('head')
					.appendChild(meta)
					.appendChild(title)
					.appendChild(link)
					.appendChild(style)
					.appendChild(script),
				heading = Object.create(domElement)
					.init('h1'),
				luser = Object.create(domElement)
					.init('label')
					.addAttribute('for', 'username')
					.addAttribute('class', 'big'),
				lpass = Object.create(domElement)
					.init('label')
					.addAttribute('for', 'password'),
				user = Object.create(domElement)
					.init('input')
					.addAttribute('name', 'username')
					.addAttribute('id', 'username')
					.addAttribute('type', 'input')
					.addAttribute('tab-index', 1),
				pass = Object.create(domElement)
					.init('input')
					.addAttribute('name', 'password')
					.addAttribute('id', 'password')
					.addAttribute('type', 'password')
					.addAttribute('tab-index', 2),
				submit = Object.create(domElement)
					.init('input')
					.addAttribute('type', 'submit')
					.addAttribute('value', 'natis'),
				form = Object.create(domElement)
					.init('form')
					.appendChild(luser)
					.appendChild(user)
					.addAttribute('action', 'vlez/mi/u/profila')
					.appendChild(lpass)
					.addAttribute('method', 'post')
					.appendChild(pass)
					.appendChild(submit),
				footer = Object.create(domElement)
					.init('footer'),
				body = Object.create(domElement)
					.init('body')
					.appendChild(heading)
					.appendChild(form)
					.appendChild('reklamata')
					.appendChild(footer),
				html = Object.create(domElement)
					.init('html')
					.appendChild(head)
					.appendChild(body);

			heading.content = 'tova izliza v golemi bukvi';
			head.content = 'tova ne trqbva da izliza';
			luser.content = 'Username: ';
			lpass.content = 'Password: ';
			footer.content = 'stiga tolkoz';
			meta.removeAttribute('charset');
			meta.addAttribute('content', 'HTML,CSS,XML,JavaScript');

			console.log(html.innerHTML);
}

solve();