module.exports="<p>o;?### Markdown Help</p>\n<h4>Paragraphs</h4>\n<p>To start a new paragraph, just leave an empty line.</p>\n<pre><code class=\"text\">This is paragraph 1.\n\nThis is paragraph 2.\n</code></pre>\n<p>To start a new line just leave two spaces at the end of the previous line.</p>\n<h4>Headers</h4>\n<p>Headers are specified with differing numbers of <code>#</code>.</p>\n<p><code># Big Heading</code> generates:</p>\n<h1>Big Heading</h1>\n<p><code>### Small Heading</code> generates:</p>\n<h3>Small Heading</h3>\n<h4>Bold and italics</h4>\n<p><code>**Bold text**</code> makes <strong>Bold text</strong><br /><code>*Italic text*</code> makes <em>Italic text</em></p>\n<h4>Links and images</h4>\n<p><code>[Google](http://google.com)</code> makes <a href=\"http://google.com\" target=\"_blank\">Google</a>, a link to Google. Putting an exclamation mark in front of the link makes an image like <code>![Description](url)</code>.</p>\n<h4>Code</h4>\n<p>Code can either be indented by 4 spaces.</p>\n<pre><code class=\"text\">    cout &lt;&lt; &quot;Hello, world!&quot; &lt;&lt; endl;\n</code></pre>\n<p>or fenced by 3 backticks. You can specify the language:</p>\n<pre><code>```javascript\nfunction() {\n    var foo = 'Hello, world!';\n    console.log(foo);\n}\n```\n</code></pre><p>to help with the highlighting.</p>\n<h4>Blockquotes</h4>\n<p>Block quotes are denoted by <code>&gt;</code>:</p>\n<pre><code class=\"text\">&gt; This is a block quote\n&gt; that goes onto two lines.\n</code></pre>\n<h4>Lists</h4>\n<p>Ordered lists are made like</p>\n<pre><code class=\"text\">1. List Item 1\n2. List Item 2\n3. List Item 3\n</code></pre>\n<p>Unordered lists are made with dashes</p>\n<pre><code class=\"text\">- List item\n- List item\n- List item\n</code></pre>\n<h4>Tables</h4>\n<table>\n<thead>\n<tr>\n<th style=\"text-align:right\">A</th>\n<th style=\"text-align:center\">B</th>\n<th style=\"text-align:left\">C</th>\n</tr>\n</thead>\n<tbody>\n<tr>\n<td style=\"text-align:right\">1</td>\n<td style=\"text-align:center\">2</td>\n<td style=\"text-align:left\">3</td>\n</tr>\n<tr>\n<td style=\"text-align:right\">4</td>\n<td style=\"text-align:center\">5</td>\n<td style=\"text-align:left\">6</td>\n</tr>\n<tr>\n<td style=\"text-align:right\">7</td>\n<td style=\"text-align:center\">8</td>\n<td style=\"text-align:left\">9</td>\n</tr>\n</tbody>\n</table>\n<p>are made like, where the colons specify column alignment:</p>\n<pre><code class=\"text\">| A | B | C |\n|--:|:-:|:--|\n| 1 | 2 | 3 |\n| 4 | 5 | 6 |\n| 7 | 8 | 9 |\n</code></pre>\n<h4>HTML</h4>\n<p>HTML can be directly inserted, too.</p>\n<hr />\n<p>For further information see:</p>\n<ul>\n<li><a href=\"https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet\" target=\"_blank\">Markdown</a></li>\n<li><a href=\"http://www.artofproblemsolving.com/wiki/index.php/LaTeX:Math\" target=\"_blank\">LaTeX</a></li>\n</ul>";