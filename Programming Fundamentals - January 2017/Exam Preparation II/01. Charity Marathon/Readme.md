
<h1><a id="user-content-problem-1-charity-marathon" class="anchor" href="#problem-1-charity-marathon" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Problem 1. Charity Marathon</h1>
<p>Every year a charity marathon takes place in your town in which all major companies are obliged to <strong>make donations depending on the total kilometers ran by runners in a number of days</strong>. And this year you have been chosen to create the software for it.</p>
<p>The <strong>marathon can last for variable number days</strong> and a <strong>variable number of runners can participate</strong> in it on a <strong>track that can have a variable length</strong>. However, the <strong>track that can take only a limited number of runners per day</strong>. If the runners that want to take part are more than the capacity, then the number of runners that will run will be <strong>equal to the maximum capacity of the track</strong>.</p>
<p>The <strong>amount of money raised per kilometer is voted</strong> in advance by all companies and the final money per kilometer is <strong>calculated by an average of all votes</strong>.</p>
<p>The goal is simple, create a program that calculates the total money raised through the marathon.</p>
<h2><a id="user-content-input" class="anchor" href="#input" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Input</h2>
<ul>
<li>On the first line of input you will get the <strong>length of the marathon in days</strong></li>
<li>On the second line of input you will get <strong>the number of runners that will participate</strong></li>
<li>On the third line you will get the <strong>average number of laps every runner</strong> makes</li>
<li>On the fourth line you will get the <strong>length of the track</strong></li>
<li>On the fifth line you will get the <strong>capacity of the track</strong></li>
<li>On the sixth line you will get <strong>the amount of money donated per kilometer</strong></li>
</ul>
<h2><a id="user-content-output" class="anchor" href="#output" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Output</h2>
<ul>
<li>Print the money raised, <strong>rounded by the second digit after the decimal point</strong> from the charity marathon in the format: "<strong>Money raised: {money}</strong>"</li>
</ul>
<h2><a id="user-content-constraints" class="anchor" href="#constraints" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Constraints</h2>
<ul>
<li>Marathon day count will be an integer in the range [0 … 365]</li>
<li>Runner count will be an integer in the range [0 … 2,147,483,647]</li>
<li>Average number of laps will be an integer in the range [0 … 100]</li>
<li>Lap length will be an integer in the range [0 … 2,147,483,647]</li>
<li>Track capacity will be an integer in the range [0 … 1000]</li>
<li>Money per kilometer will all be a floating point number</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2><a id="user-content-examples" class="anchor" href="#examples" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Examples</h2>
<table width="701">
<tbody>
<tr>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="180">
<p><strong>Output</strong></p>
</td>
<td width="446">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>2</p>
<p>50</p>
<p>2</p>
<p>400</p>
<p>30</p>
<p>3</p>
</td>
<td width="180">
<p>Money raised: 120.00</p>
</td>
<td width="446">
<p>The marathon runs for 2 days, with 50 runners that will make an average of 2 laps on a track that is long 400 meters.</p>
<p>&nbsp;</p>
<p>The capacity of the track is 30 runners per day. So a total of 30 * 2 = 60 maximum runners. But only 50 runners are listed, so 50 will run.</p>
<p>&nbsp;</p>
<p>Total meters = 50 runners * 2 laps * 400 m = 40,000 m</p>
<p>Total kilometers = 40,000 m / 1,000 = 40 km</p>
<p>Money raised by kilometer = 3</p>
<p>Money raised for the marathon = 40 * 3 = 120</p>
</td>
</tr>
<tr>
<td width="76">
<p>1</p>
<p>50</p>
<p>10</p>
<p>400</p>
<p>1</p>
<p>2.5</p>
</td>
<td width="180">
<p>Money raised: 10.00</p>
</td>
<td width="446">
<p>The listed runners are 50, but the maximum capacity of the track is 1 runner per day and the marathon will last for 1 day. So 1 runner will run in total.</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
</article>