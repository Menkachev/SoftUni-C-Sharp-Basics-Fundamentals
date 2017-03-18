<h1><a id="user-content-problem-2--command-interpreter" class="anchor" href="#problem-2--command-interpreter" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Problem 2 – Command Interpreter</h1>
<p>Jagged arrays, regular expressions, asynchronous programming… Tough stuff. But simple structures like arrays are piece of cake, right? Let’s see how well you can manipulate data in a collection.</p>
<p>You will be given a series of strings on a single line, separated by one or more whitespaces. These represent the collection you’ll be working with.</p>
<p>On the next input lines, until you receive the command <strong>"end"</strong>, you’ll receive a series of commands in one of the following formats:</p>
<ul>
<li><strong>"reverse from [start] count [count]"</strong> – this instructs you to reverse a <strong>portion</strong> of the array – just [count] elements starting at index [start];</li>
<li><strong>"sort from [start] count [count]"</strong> – this instructs you to sort a <strong>portion</strong> of the array - [count] elements starting at index [start];</li>
<li><strong>"rollLeft [count] times"</strong> – this instructs you to move <strong>all</strong> elements in the array to the left [count] times. On each roll, the first element is placed at the end of the array;</li>
<li><strong>"rollRight [count] times"</strong> – this instructs you to move <strong>all</strong> elements in the array to the right [count] times. On each roll, the last element is placed at the beginning of the array;</li>
</ul>
<p>If any of the provided indices or counts is <strong>invalid</strong> (non-existent or negative), you should print a message on the console – <strong>"Invalid input parameters." </strong>and<strong> keep the collection unchanged.</strong></p>
<p>After you’re done, print the resulting array in the following format: <strong>"[arr0, arr1 … arrN]"</strong>. The examples should help you understand the task better.</p>
<h3><a id="user-content-input" class="anchor" href="#input" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Input</h3>
<ul>
<li>The input data should be read from the console.</li>
<li>The first input line will hold <strong>a series of strings</strong>, separated by <strong>one or more whitespaces</strong>.</li>
<li>The next lines will hold <strong>commands</strong> in the described formats (exactly).</li>
<li>The input ends with the keyword <strong>"end".</strong></li>
<li>The input data will always be valid and in the format described. There is no need to check it explicitly.</li>
</ul>
<h3><a id="user-content-output" class="anchor" href="#output" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Output</h3>
<ul>
<li>The output should be printed on the console.</li>
<li>Each time an invalid command is received (containing an invalid index or count parameter), print the following line: <strong>"Invalid input parameters."</strong></li>
<li>After receiving the "<strong>end</strong>" command, print the <strong>resulting array</strong> on the console in the format specified above.</li>
</ul>
<h3><a id="user-content-constraints" class="anchor" href="#constraints" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Constraints</h3>
<ul>
<li>The <strong>count of strings</strong> in the collection will be in the range [1 … 50].</li>
<li>The <strong>number of commands</strong> will be in the range [1 … 20].</li>
<li>All commands will be in the described format; an invalid command is a command containing invalid [start] or [count], <strong>there won’t be any missing or misspelled words</strong>.</li>
<li>[<strong>start</strong>] and [<strong>count</strong>] will be integers in the range [-2<sup>31</sup> … 2<sup>31 </sup>- 1].</li>
<li>Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.</li>
</ul>
<h3><a id="user-content-examples" class="anchor" href="#examples" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Examples</h3>
<table width="437">
<tbody>
<tr>
<td width="191">
<p><strong>Input</strong></p>
</td>
<td width="246">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="191">
<p>1 2 <strong>5 8 7 3</strong> 10 6 4 9</p>
<p>reverse from 2 count 4</p>
<p>end</p>
</td>
<td width="246">
<p>[1, 2, <strong>3, 7, 8, 5</strong>, 10, 6, 4, 9]</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
</article>