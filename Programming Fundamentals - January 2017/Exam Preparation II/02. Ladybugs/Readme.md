
<h1><a id="user-content-problem-2-ladybugs" class="anchor" href="#problem-2-ladybugs" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Problem 2. Ladybugs</h1>
<p>You are <strong>given a field size</strong> and the <strong>indexes of ladybugs</strong> inside the field. After that on every new line <strong>until the "end" command</strong> is given, a <strong>ladybug changes its position</strong> either to its <strong>left or to its right</strong> <strong>by a given fly length</strong>.</p>
<p>A <strong>command</strong> <strong>to a ladybug</strong> looks like this: "<strong>0 right 1</strong>". This means that the little insect placed on index 0 should fly one index to its right. If the ladybug <strong>lands on a fellow ladybug</strong>, it <strong>continues to fly</strong> in the same direction <strong>by the same fly length</strong>. If the ladybug <strong>flies out of the field, it is gone</strong>.</p>
<p>For example, imagine you are given a field with size 3 and ladybugs on indexes 0 and 1. If the ladybug on index 0 needs to fly to its right by the length of 1 (0 right 1) it will attempt to land on index 1 but as there is another ladybug there it will continue further to the right by additional length of 1, landing on index 2. After that, if the same ladybug needs to fly to its right by the length of 1 (2 right 1), it will land somewhere outside of the field, so it flies away:</p>
<p>If you are given ladybug index that does not have ladybug there, nothing happens. If you are given ladybug index that is outside the field, nothing happens.</p>
<p>Your job is to create the program, simulating the ladybugs flying around doing nothing. At the end, <strong>print all cells in the field separated by blank spaces</strong>. For each cell that has a ladybug on it print '<strong>1</strong>' and for each empty cells print '<strong>0</strong>'. For the example above, the output should be <strong>'0 1 0'</strong>.</p>
<h3><a id="user-content-input" class="anchor" href="#input" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Input</h3>
<ul>
<li>On the first line you will receive an integer - the size of the field</li>
<li>On the second line you will receive the initial <strong>indexes</strong> of all ladybugs separated by a blank space. <strong>The given indexes</strong> may or may not be inside the field range</li>
<li>On the next lines, until you get the "end" command you will receive commands in the format: "<strong>{ladybug index} {direction} {fly length}</strong>"</li>
</ul>
<h2><a id="user-content-output" class="anchor" href="#output" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Output</h2>
<ul>
<li>Print the <strong>all cells within the field in format: "{cell} {cell} … {cell}"</strong>
<ul>
<li>If a cell has ladybug in it, print <strong>'1'</strong></li>
<li>If a cell is empty, print <strong>'0'</strong></li>
</ul>
</li>
</ul>
<h2><a id="user-content-constrains" class="anchor" href="#constrains" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Constrains</h2>
<ul>
<li>The size of the field will be in the range [0 … 1000]</li>
<li>The ladybug indexes will be in the range [-2,147,483,647 … 2,147,483,647]</li>
<li>The number of commands will be in the range [0 … 100]</li>
<li>The fly length will be in the range [-2,147,483,647 … 2,147,483,647]</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2><a id="user-content-examples" class="anchor" href="#examples" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Examples</h2>
<table width="692">
<tbody>
<tr>
<td width="112">
<p><strong>Input</strong></p>
</td>
<td width="66">
<p><strong>Output</strong></p>
</td>
<td width="514">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="112">
<p>3</p>
<p>0 1</p>
<p>0 right 1</p>
<p>2 right 1</p>
<p>end</p>
</td>
<td width="66">
<p>0 1 0</p>
</td>
<td width="514">
<p>1 1 0 - Initial field</p>
<p>0 1 1 - field after "0 right 1"</p>
<p>0 1 0 - field after "2 right 1"</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="442">
<tbody>
<tr>
<td width="111">
<p><strong>Input</strong></p>
</td>
<td width="66">
<p><strong>Output</strong></p>
</td>
<td width="66">
<p><strong>&nbsp;</strong></p>
</td>
<td width="113">
<p><strong>Input</strong></p>
</td>
<td width="85">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="111">
<p>3</p>
<p>0 1 2</p>
<p>0 right 1</p>
<p>1 right 1</p>
<p>2 right 1</p>
<p>end</p>
</td>
<td width="66">
<p>0 0 0</p>
</td>
<td width="66">
<p>&nbsp;</p>
</td>
<td width="113">
<p>5</p>
<p>3</p>
<p>3 left 2</p>
<p>1 left -2</p>
<p>end</p>
</td>
<td width="85">
<p>0 0 0 1 0</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
</article>