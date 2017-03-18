<h1><a id="user-content-problem-3--rage-quit" class="anchor" href="#problem-3--rage-quit" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Problem 3 – Rage Quit</h1>
<p>Every gamer knows what rage-quitting means. It’s basically when you’re just not good enough and you blame everybody else for losing a game. You press the CAPS LOCK key on the keyboard and flood the chat with gibberish to show your frustration.</p>
<p>Chochko is a gamer, and a bad one at that. He asks for your help; he wants to be the most annoying kid in his team, so when he rage-quits he wants something truly spectacular. He’ll give you <strong>a series of strings followed by non-negative numbers</strong>, e.g. "a3"; you need to print on the console <strong>each string repeated N times</strong>; <strong>convert the letters to uppercase beforehand</strong>. In the example, you need to write back "AAA".</p>
<p>On the output, print first a statistic of the <strong>number of unique symbols</strong> used (the casing of letters is irrelevant, meaning that 'a' and 'A' are the same); the format shoud be <strong>"Unique symbols used {0}"</strong>. Then, <strong>print the rage message</strong> itself.</p>
<p>The <strong>strings and numbers will not be separated by anything</strong>. The input will always start with a string and for each string there will be a corresponding number. The entire input will be given on a <strong>single line</strong>; Chochko is too lazy to make your job easier.</p>
<h3><a id="user-content-input" class="anchor" href="#input" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Input</h3>
<ul>
<li>The input data should be read from the console.</li>
<li>It consists of a single line holding a series of <strong>string-number sequences</strong>.</li>
<li>The input data will always be valid and in the format described. There is no need to check it explicitly.</li>
</ul>
<h3><a id="user-content-output" class="anchor" href="#output" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Output</h3>
<ul>
<li>The output should be printed on the console. It should consist of <strong>exactly two lines</strong>.</li>
<li>On the first line, print the <strong>number of unique symbols used</strong> in the message.</li>
<li>On the second line, print the <strong>resulting rage message</strong></li>
</ul>
<h3><a id="user-content-constraints" class="anchor" href="#constraints" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Constraints</h3>
<ul>
<li>The count of <strong>string-number pairs </strong>will be in the range [1 … 20 000].</li>
<li>Each string will contain any character <strong>except digits</strong>. The <strong>length</strong> of each string will be in the range [1 … 20].</li>
<li>The <strong>repeat count</strong> for each string will be an integer in the range [0 … 20].</li>
<li>Allowed working time for your program: 0.3 seconds. Allowed memory: 64 MB.</li>
</ul>
<h3><a id="user-content-examples" class="anchor" href="#examples" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Examples</h3>
<table width="689">
<tbody>
<tr>
<td width="83">
<p><strong>Input</strong></p>
</td>
<td width="186">
<p><strong>Output</strong></p>
</td>
<td width="420">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="83">
<p>a3</p>
</td>
<td width="186">
<p>Unique symbols used: 1</p>
<p>AAA</p>
</td>
<td width="420">
<p>We have just one string-number pair. The symbol is 'a', convert it to uppercase and repeat 3 times: AAA.</p>
<p>Only one symbol is used ('A').</p>
</td>
</tr>
<tr>
<td width="83">
<p>aSd2&amp;5s@1</p>
</td>
<td width="186">
<p>Unique symbols used: 5</p>
<p>ASDASD&amp;&amp;&amp;&amp;&amp;S@</p>
</td>
<td width="420">
<p>"aSd" is converted to "ASD" and repeated twice; "&amp;" is repeated 5 times; "s@" is converted to "S@" and repeated once.</p>
<p>5 symbols are used: 'A', 'S', 'D', '&amp;' and '@'.</p>
</td>
</tr>
</tbody>
</table>
<p>'</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
</article>