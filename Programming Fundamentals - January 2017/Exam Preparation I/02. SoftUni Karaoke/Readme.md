
<h1><a id="user-content-problem-2-softuni-karaoke" class="anchor" href="#problem-2-softuni-karaoke" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Problem 2. SoftUni Karaoke</h1>
<p>SoftUni cultivates talent whether it's coding talent or something else and in this case, something else is singing. Since you love music you want to take part in the event but as a programmer you simply lack the "something else" so your job is to make the software to track participants' awards.</p>
<p><strong>On the first line</strong>, you will receive a <strong>list with all participants that applied for performance</strong>.</p>
<p><strong>On the second line</strong>, you will receive <strong>the list with all available songs</strong>.</p>
<p><strong>On the next lines</strong>, until the "<strong>dawn</strong>" <strong>command</strong>, you will get the <strong>names of people</strong>, <strong>the song that they are performing</strong> on stage and <strong>the award they get</strong> from the audience.</p>
<p>However, not every time the plan goes according to schedule. In other words, <strong>everyone</strong> (listed or not) <strong>can go on stage and perform a song that is not even available</strong> and he <strong>still gets awards from the audience</strong>. However, you should <strong>record only the awards for listed participants</strong> that <strong>perform songs </strong><strong>available in the list</strong>. In case someone is <strong>not listed</strong> or sings a <strong>song that is not available</strong> you <strong>should not record neither the participant, nor his award</strong>.&nbsp;</p>
<p>When the "dawn" comes, you need to <strong>print all participants</strong>, the <strong>count of the unique awards they received</strong> and all unique awards. Participants should be <strong>sorted by number of awards</strong> in <strong>descending order</strong> and <strong>then by participant name alphabetically</strong>. Awards should be <strong>sorted in alphabetical order</strong>.</p>
<h3><a id="user-content-input" class="anchor" href="#input" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Input</h3>
<ul>
<li>On the first line, you will receive list with all participants that applied for performance in the format: <strong>"{participant}, {participant} … {participant}"</strong></li>
<li>On the second line, you will get all available songs in the in the format: <strong>"{song}, {song} … {song}"</strong></li>
<li>On the next lines, until the <strong>"dawn"</strong> command you will receive every stage performance in the format: <strong>"{participant}, {song}, {award}" </strong></li>
<li>Performances and songs will be <strong>separated by a comma and a single or multiple white spaces</strong></li>
</ul>
<h2><a id="user-content-output" class="anchor" href="#output" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Output</h2>
<ul>
<li>Print all participants along with the number of unique awards they won in the format:
<ul>
<li><strong>"{participant}: {award count} awards"</strong></li>
<li><strong>"--{award}"</strong></li>
</ul>
</li>
<li>Print participants <strong>sorted by unique awards count in descending order</strong>. If two participants have the same unique award count<strong>, sort them alphabetically by name</strong></li>
<li>Print unique <strong>awards</strong> for every participant <strong>sorted alphabetically</strong></li>
<li>If there are<strong> no awards, </strong>print<strong> "No awards"</strong></li>
</ul>
<h2><a id="user-content-constrains" class="anchor" href="#constrains" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Constrains</h2>
<ul>
<li>The number of total participants will be in range [1 … 100]</li>
<li>The number of total songs will be in range [1 … 100]</li>
<li>The input will always end with the "dawn" command</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2><a id="user-content-examples" class="anchor" href="#examples" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Examples</h2>
<table width="679">
<tbody>
<tr>
<td width="490">
<p><strong>Input</strong></p>
</td>
<td width="189">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="490">
<p>Trifon, Vankata, Gesha</p>
<p>Dragana - Kukavice, Bon Jovi - It's my life, Lorde - Royals</p>
<p>Gesha, Bon Jovi - It's my life, Best Rock</p>
<p>Vankata, Dragana - Kukavice, Best Srabsko</p>
<p>Vankata, Dragana - Kukavice, Best Srabsko</p>
<p>Vankata, Dragana - Kukavice, Stiga Tolko Srabsko</p>
<p>Vankata, PHP Web, Educational 101</p>
<p>dawn</p>
</td>
<td width="189">
<p>Vankata: 2 awards</p>
<p>--Best Srabsko</p>
<p>--Stiga Tolko Srabsko</p>
<p>Gesha: 1 awards</p>
<p>--Best Rock</p>
</td>
</tr>
<tr>
<td width="490">
<p>Gesha</p>
<p>Bon Jovi - It's my life</p>
<p>Gesha, Bon Jovi - It's my life, Best Rock</p>
<p>Vankata, Dragana - Kukavice, Best Srabsko</p>
<p>Vankata, Dragana - Kukavice, Stiga Tolko Srabsko</p>
<p>Vankata, PHP Web, Educational 101</p>
<p>dawn</p>
</td>
<td width="189">
<p>Gesha: 1 awards</p>
<p>--Best Rock</p>
</td>
</tr>
<tr>
<td width="490">
<p>Sino</p>
<p>Vasko Naidenov - Nova Godina</p>
<p>dawn</p>
</td>
<td width="189">
<p>No awards</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
</article>