<h1><a id="user-content-problem-1--sweet-dessert" class="anchor" href="#problem-1--sweet-dessert" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Problem 1 – Sweet Dessert</h1>
<p>Ivancho and his girlfriend are <strong>throwing a party</strong>. She plans <strong>to cook her favorite dessert</strong>. She asks Ivancho to <strong>buy</strong> the <strong>needed products</strong>. The <strong>number of desserts</strong> depends on <strong>how many people will be coming</strong>. She can prepare the dessert <strong>in portions of 6</strong>. If there are <strong>5 guests</strong> coming, she will still <strong>cook 6 portions,</strong> <strong>10 guests – cook 12</strong>. The products for the dessert are <strong>bananas, eggs and berries</strong>. For <strong>a set of 6</strong> she needs <strong>2 bananas, 4 eggs and 0.2 kilos berries</strong>.</p>
<p>You will be given <strong>the amount of money Ivancho has</strong>, the <strong>number of guests </strong>and the <strong>prices of the products</strong>. You have to help Ivancho <strong>calculate</strong> if the <strong>cash</strong> he has is <strong>enough to buy all of the products</strong>, or how much more money he needs.</p>
<h3><a id="user-content-input" class="anchor" href="#input" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Input</h3>
<p>The input data should be read from the console. It will consist of <strong>exactly 5 lines</strong>:</p>
<ul>
<li>The <strong>amount of cash</strong> Ivancho has – <strong>floating-point number</strong> in <strong>range [0.0</strong><strong>0…1,000,000,000.00]</strong></li>
<li>The <strong>number of guests – integer in range [0…1,000,000,000]</strong></li>
<li>The <strong>price of bananas</strong> for a <strong>single unit – floating-point number</strong> in <strong>range [0.</strong><strong>00…1,000.00]</strong></li>
<li>The <strong>price of eggs</strong> for a <strong>single unit – floating-point number</strong> in <strong>range [0.</strong><strong>00…1,000.00]</strong></li>
<li>The <strong>price of berries</strong> for a <strong>kilo – floating-point number</strong> in <strong>range [0.0</strong><strong>0…1,000.00]</strong></li>
</ul>
<p>The <strong>input data will always be valid</strong> and in the format described. <strong>There is no need to check it explicitly</strong>.</p>
<h3><a id="user-content-output" class="anchor" href="#output" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Output</h3>
<p>The output should be printed on the console.</p>
<ul>
<li><strong>If the calculated price of the products is less or equal to the money Ivancho has:</strong>
<ul>
<li>“Ivancho has enough money - it would cost {the cost of the products}lv.”</li>
</ul>
</li>
<li><strong>If the calculated price of the products is more than the money Ivancho has:</strong>
<ul>
<li>“Ivancho will have to withdraw money - he will need {neededMoney}lv more.”</li>
</ul>
</li>
<li><strong>All prices</strong> must be <strong>rounded to two digits after the decimal point.</strong></li>
</ul>
<h3><a id="user-content-examples" class="anchor" href="#examples" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Examples</h3>
<table width="702">
<tbody>
<tr>
<td width="50">
<p><strong>Input</strong></p>
</td>
<td width="304">
<p><strong>Output</strong></p>
</td>
<td width="348">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="50">
<p>10</p>
<p>12</p>
<p>0.35</p>
<p>0.20</p>
<p>4.50</p>
</td>
<td width="304">
<p>Ivancho has enough money - it would cost 4.80lv.</p>
</td>
<td width="348">
<p>For 12 guests – 2 sets of 6 portions</p>
<p>Needed product:</p>
<p>2*(2 bananas), 2*(4 eggs), 2*(0.2 kilos berries)</p>
<p>2*(2*0.35) + 2*(4*0.20) + 2*(0.2*4.50) = 4.80</p>
<p>4.80 &lt;= 10 – the money will be enough.</p>
</td>
</tr>
<tr>
<td width="50">
<p><strong>Input</strong></p>
</td>
<td width="304">
<p><strong>Output</strong></p>
</td>
<td width="348">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="50">
<p>20</p>
<p>33</p>
<p>0.60</p>
<p>0.50</p>
<p>10</p>
</td>
<td width="304">
<p>Ivancho will have to withdraw money - he will need 11.20lv more.</p>
</td>
<td width="348">
<p>For 33 guests – 6 sets of 6 portions</p>
<p>Needed product:</p>
<p>6*(2 bananas), 6*(4 eggs), 6*(0.2 kilos berries)</p>
<p>6*(2*0.60) + 6*(4*0.50) + 6*(0.2*10.00) = 31.20</p>
<p>31.20 &gt; 20 – need 11.20 lv. more.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
</article>