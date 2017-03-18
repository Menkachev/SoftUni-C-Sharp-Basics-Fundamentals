<h1><a id="user-content-problem-4--cubics-messages" class="anchor" href="#problem-4--cubics-messages" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Problem 4 – Cubic’s Messages</h1>
<p>Cubic is a veteran soldier from The Great Cubic Army. He has even participated in the Spherical Invasion as a Sergeant First Class. As a veteran, Cubic has some personal security issues – he communicates only trough text messages and sends them in a specific encrypted way, which you must decrypt in order to understand what he is saying.</p>
<p>You will begin receiving lines of input, which will consist of random ASCII characters – Cubic’s encrypted lines. After each line you will receive a number – the length of the message he sent. Cubic might send false messages, in an act to confuse his “enemies”. You must capture only the messages that follow a certain format.</p>
<p>According to that format the <strong>valid</strong> messages:</p>
<ul>
<li>Consist of <strong>m </strong>characters, where <strong>m </strong>is the integer entered after each encrypted line.</li>
<li>Has only digits before itself in the encrypted line</li>
<li>Consists only of English alphabet letters</li>
<li>Has no English alphabet letters after itself in the encrypted line</li>
</ul>
<p><strong>Any</strong> message that <strong>does not follow</strong> the, specified above, rules, is <strong>invalid</strong>, and you must <strong>ignore it</strong>.</p>
<p>After you find <strong>all valid</strong> messages, you need to find their <strong>verification code</strong>. Every message has its own verification code, which Cubic gives in order to verify the message. <strong>Take all the digits before the message</strong> and all the digits <strong>after the message</strong> and consider them as <strong>indexes</strong>. If they are <strong>valid existing</strong> indexes <strong>in the message</strong>, <strong>form a string</strong> with those indexes <strong>taking characters from the message</strong>. If an index is <strong>nonexistent</strong>, put a <strong>space </strong>there. The string you form up is the verification code for the current message.</p>
<h3><a id="user-content-input" class="anchor" href="#input" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Input</h3>
<ul>
<li>The input will always come in the form of 2 lines, except when it is the line terminating the input sequence.</li>
<li>The first input line will contain random ASCII characters, and the second – a number.</li>
<li>When the line “<strong>Over!</strong>” is entered, the input sequence ends.</li>
</ul>
<h3><a id="user-content-output" class="anchor" href="#output" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Output</h3>
<ul>
<li>The output is simple. You must print all the valid messages you’ve found, each on a new line, and their verification codes, if they have such.</li>
<li>The format of output is “<strong>{message} == {verificationCode}</strong>”.</li>
</ul>
<h3><a id="user-content-constraints" class="anchor" href="#constraints" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Constraints</h3>
<ul>
<li>The input lines can consist of <strong>ANY ASCII</strong></li>
<li>There will be <strong>NO </strong>such cases as an encrypted message without a number before it.</li>
<li>The number will be a valid integer in the range [0, 100].</li>
<li>Allowed time/memory: 100ms/16MB</li>
</ul>
<p>&nbsp;</p>
<h3><a id="user-content-examples" class="anchor" href="#examples" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Examples</h3>
<table width="599">
<tbody>
<tr>
<td width="305">
<p><strong><strong>Input</strong></strong></p>
</td>
<td width="294">
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td width="305">
<p><strong>1234test4321</strong></p>
<p><strong>4</strong></p>
<p><strong>0000oooo0000</strong></p>
<p><strong>4</strong></p>
<p><strong>Over!</strong></p>
</td>
<td width="294">
<p><strong>test == est&nbsp; tse</strong></p>
<p><strong>oooo == oooooooo</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="599">
<tbody>
<tr>
<td width="305">
<p><strong><strong>Input</strong></strong></p>
</td>
<td width="294">
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td width="305">
<p><strong>1wat!</strong></p>
<p><strong>3</strong></p>
<p><strong>#23asd33</strong></p>
<p><strong>3</strong></p>
<p><strong>333asd3a</strong></p>
<p><strong>3</strong></p>
<p><strong>100dun2</strong></p>
<p><strong>3</strong></p>
<p><strong>Over!</strong></p>
</td>
<td width="294">
<p><strong>wat == a</strong></p>
<p><strong>dun == uddn</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
</article>