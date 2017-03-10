<!DOCTYPE html>
<head></head>
<body>

<article class="markdown-body entry-content" itemprop="text"><h1><a id="user-content-problem-4-files" class="anchor" href="#problem-4-files" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Problem 4. Files</h1>

<p>You are given number of files with their <strong>full file paths</strong> and <strong>file sizes</strong>. You need to <strong>print all file names</strong> with <strong>a given extension </strong>that are present in<strong> a given root directory sorted by their file size </strong>in<strong> descending order</strong>. If two files have <strong>same size</strong>, order them <strong>by alphabetical order</strong>.</p>

<p>If a <strong>file name (file name + extension) appears more than once in a given root</strong>, <strong>save only its latest value. </strong>If a file name appears in more than one root, they are treated as different files.</p>

<p>If there <strong>aren't any files</strong> that correspond to the query, print <strong>"No"</strong>.</p>

<h2><a id="user-content-input--constrains" class="anchor" href="#input--constrains" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Input / Constrains</h2>

<ul>
<li>On the <strong>first line</strong> of input you will get <strong>N</strong> the <strong>number of files to be read from the console</strong></li>
<li>On the next N lines, you receive <strong>the actual files in the format "root\folder\filename.extension;filesize"</strong></li>
<li>There may be more than one folder e.g. <strong>files can be deeply nested</strong></li>
<li>On the last line you receive a query string in format <strong>"{extension} in {root}"</strong>. You need to print all files with the given extension that are in present in the given root</li>
</ul>

<h2><a id="user-content-output" class="anchor" href="#output" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Output</h2>

<ul>
<li>You need to print all files sorted by their size in descending order.</li>
<li>If two files have the same size, order them by alphabetical order.</li>
<li>Files should be printed in the given format <strong>"filename.extension - filesize KB" </strong></li>
<li>If there <strong>aren't any movies</strong> that correspond to the query, print <strong>"No"</strong>.</li>
</ul>

<h2><a id="user-content-examples" class="anchor" href="#examples" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Examples</h2>

<table width="699">
<tbody>
<tr>
<td width="435">
<p><strong>Input</strong></p>
</td>
<td width="265">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="435">
<p>4</p>
<p>Windows\Temp\win.exe;5423</p>
<p>Games\Wow\wow.exe;1024</p>
<p>Games\Wow\patcher.cs;65212</p>
<p>Games\Pirates\Start\keygen.exe;1024</p>
<p>exe in Games</p>
</td>
<td width="265">
<p>keygen.exe - 1024 KB</p>
<p>wow.exe - 1024 KB</p>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="435">
<p>3</p>
<p>C:\Documents\01. problems.docx;6521</p>
<p>D:\Documents\02. Documents\ presentation.pptx;44234</p>
<p>E:\Movies\Classics\someclassicmovie.avi;6221235212</p>
<p>docx in E:</p>
</td>
<td width="265">
<p>No</p>
</td>
</tr>
</tbody>
</table>

<p>&nbsp;</p>

<p>&nbsp;</p>
</article>

<h1><a id="user-content-problem-4-files" class="anchor" href="#problem-4-files" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Problem 4. Files</h1>

<p>You are given number of files with their <strong>full file paths</strong> and <strong>file sizes</strong>. You need to <strong>print all file names</strong> with <strong>a given extension </strong>that are present in<strong> a given root directory sorted by their file size </strong>in<strong> descending order</strong>. If two files have <strong>same size</strong>, order them <strong>by alphabetical order</strong>.</p>

<p>If a <strong>file name (file name + extension) appears more than once in a given root</strong>, <strong>save only its latest value. </strong>If a file name appears in more than one root, they are treated as different files.</p>

<p>If there <strong>aren't any files</strong> that correspond to the query, print <strong>"No"</strong>.</p>

<h2><a id="user-content-input--constrains" class="anchor" href="#input--constrains" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Input / Constrains</h2>

<ul>
<li>On the <strong>first line</strong> of input you will get <strong>N</strong> the <strong>number of files to be read from the console</strong></li>
<li>On the next N lines, you receive <strong>the actual files in the format "root\folder\filename.extension;filesize"</strong></li>
<li>There may be more than one folder e.g. <strong>files can be deeply nested</strong></li>
<li>On the last line you receive a query string in format <strong>"{extension} in {root}"</strong>. You need to print all files with the given extension that are in present in the given root</li>
</ul>

<h2><a id="user-content-output" class="anchor" href="#output" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Output</h2>

<ul>
<li>You need to print all files sorted by their size in descending order.</li>
<li>If two files have the same size, order them by alphabetical order.</li>
<li>Files should be printed in the given format <strong>"filename.extension - filesize KB" </strong></li>
<li>If there <strong>aren't any movies</strong> that correspond to the query, print <strong>"No"</strong>.</li>
</ul>

<h2><a id="user-content-examples" class="anchor" href="#examples" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Examples</h2>

<table width="699">
<tbody>
<tr>
<td width="435">
<p><strong>Input</strong></p>
</td>
<td width="265">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="435">
<p>4</p>
<p>Windows\Temp\win.exe;5423</p>
<p>Games\Wow\wow.exe;1024</p>
<p>Games\Wow\patcher.cs;65212</p>
<p>Games\Pirates\Start\keygen.exe;1024</p>
<p>exe in Games</p>
</td>
<td width="265">
<p>keygen.exe - 1024 KB</p>
<p>wow.exe - 1024 KB</p>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="435">
<p>3</p>
<p>C:\Documents\01. problems.docx;6521</p>
<p>D:\Documents\02. Documents\ presentation.pptx;44234</p>
<p>E:\Movies\Classics\someclassicmovie.avi;6221235212</p>
<p>docx in E:</p>
</td>
<td width="265">
<p>No</p>
</td>
</tr>
</tbody>
</table>

<article class="markdown-body entry-content" itemprop="text"><h1><a id="user-content-problem-4-files" class="anchor" href="#problem-4-files" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Problem 4. Files</h1>

<p>You are given number of files with their <strong>full file paths</strong> and <strong>file sizes</strong>. You need to <strong>print all file names</strong> with <strong>a given extension </strong>that are present in<strong> a given root directory sorted by their file size </strong>in<strong> descending order</strong>. If two files have <strong>same size</strong>, order them <strong>by alphabetical order</strong>.</p>

<p>If a <strong>file name (file name + extension) appears more than once in a given root</strong>, <strong>save only its latest value. </strong>If a file name appears in more than one root, they are treated as different files.</p>

<p>If there <strong>aren't any files</strong> that correspond to the query, print <strong>"No"</strong>.</p>

<h2><a id="user-content-input--constrains" class="anchor" href="#input--constrains" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Input / Constrains</h2>

<ul>
<li>On the <strong>first line</strong> of input you will get <strong>N</strong> the <strong>number of files to be read from the console</strong></li>
<li>On the next N lines, you receive <strong>the actual files in the format "root\folder\filename.extension;filesize"</strong></li>
<li>There may be more than one folder e.g. <strong>files can be deeply nested</strong></li>
<li>On the last line you receive a query string in format <strong>"{extension} in {root}"</strong>. You need to print all files with the given extension that are in present in the given root</li>
</ul>

<h2><a id="user-content-output" class="anchor" href="#output" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Output</h2>

<ul>
<li>You need to print all files sorted by their size in descending order.</li>
<li>If two files have the same size, order them by alphabetical order.</li>
<li>Files should be printed in the given format <strong>"filename.extension - filesize KB" </strong></li>
<li>If there <strong>aren't any movies</strong> that correspond to the query, print <strong>"No"</strong>.</li>
</ul>

<h2><a id="user-content-examples" class="anchor" href="#examples" aria-hidden="true"><svg aria-hidden="true" class="octicon octicon-link" height="16" version="1.1" viewBox="0 0 16 16" width="16"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Examples</h2>

<table width="699">
<tbody>
<tr>
<td width="435">
<p><strong>Input</strong></p>
</td>
<td width="265">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="435">
<p>4</p>
<p>Windows\Temp\win.exe;5423</p>
<p>Games\Wow\wow.exe;1024</p>
<p>Games\Wow\patcher.cs;65212</p>
<p>Games\Pirates\Start\keygen.exe;1024</p>
<p>exe in Games</p>
</td>
<td width="265">
<p>keygen.exe - 1024 KB</p>
<p>wow.exe - 1024 KB</p>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="435">
<p>3</p>
<p>C:\Documents\01. problems.docx;6521</p>
<p>D:\Documents\02. Documents\ presentation.pptx;44234</p>
<p>E:\Movies\Classics\someclassicmovie.avi;6221235212</p>
<p>docx in E:</p>
</td>
<td width="265">
<p>No</p>
</td>
</tr>
</tbody>
</table>

<p>&nbsp;</p>

<p>&nbsp;</p>
</article>
</body>