<h1><a id="user-content-problem-1-softuni-coffee-orders" class="anchor" href="#problem-1-softuni-coffee-orders" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Problem 1. SoftUni Coffee Orders</h1>
<p>We are placing <strong>N</strong> orders at a time. You need to calculate the price after the discount based on the following formula:</p>
<p>((daysInMonth * capsulesCount) * pricePerCapsule)</p>
<p>*<strong>Hint</strong> – The DateTime class may come in handy to calculate the days in month.</p>
<h3><a id="user-content-input--constraints" class="anchor" href="#input--constraints" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Input / Constraints</h3>
<ul>
<li>On the first line you will receive integer <strong>N</strong> – the count of orders the shop will receive.</li>
<li>For each order you will receive the following information:
<ul>
<li>Price per capsule - <strong>floating-point number in range [0…79,228,162,514,264,337,593,543,950,335]</strong>.</li>
<li>Order date - in the following format {d/M/yyyy}, e.g. 25/11/2016, 7/03/2016, 1/1/2020.</li>
<li>Capsules count - <strong>integer in range [0…2,147,483,647]</strong>.</li>
</ul>
</li>
</ul>
<p>The input will be in the described format, there is no need to check it explicitly.</p>
<h3><a id="user-content-output" class="anchor" href="#output" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Output</h3>
<p>The output should consist of <strong>N + 1</strong> lines. For each order you must print a single line in the following format:</p>
<ul>
<li>“The price for the coffee is: ${<strong>price</strong>}”</li>
</ul>
<p>On the last line you need to print the total price in the following format:</p>
<ul>
<li>“Total: ${totalP<strong>rice</strong>}”</li>
</ul>
<p>The <strong>price must be rounded</strong> to 2 decimal places.</p>
<h3><a id="user-content-examples" class="anchor" href="#examples" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Examples</h3>
<table width="678">
<tbody>
<tr>
<td width="146">
<p><strong>Input</strong></p>
</td>
<td width="206">
<p><strong>Output</strong></p>
</td>
<td width="326">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="146">
<p>1</p>
<p>1.53</p>
<p>06/06/2016</p>
<p>8</p>
</td>
<td width="206">
<p>The price for the coffee is: $367.20</p>
<p>Total: $367.20</p>
</td>
<td width="326">
<p>We are given only 1 order. Then we&nbsp; use the formulas:</p>
<p><strong>orderPrice</strong> = 30 (days in June 2016) * 8 * 1.53 = 367.20</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="473">
<tbody>
<tr>
<td width="146">
<p><strong>Input</strong></p>
</td>
<td width="295">
<p><strong>Output</strong></p>
</td>
<td width="32">
<p><strong>&nbsp;</strong></p>
</td>
</tr>
<tr>
<td width="146">
<p>2</p>
<p>4.99</p>
<p>6/07/2016</p>
<p>3</p>
<p>0.35</p>
<p>03/01/2013</p>
<p>5</p>
</td>
<td width="295">
<p>The price for the coffee is: $464.07</p>
<p>The price for the coffee is: $54.25</p>
<p>Total: $518.32</p>
</td>
<td width="32">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
</article>