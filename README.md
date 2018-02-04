
<h1><a id="cshotfix_0"></a>cshotfix</h1>
<pre><code>CSharp bug fix library
<b>QQ group：673735733</b>
一个专门用于C#热更新的工具链，使用该工具链，你可以实现两点：
1、<b>可以对已有的dll、exe进入错误修复。</b>
2、<b>可以新增功能</b>（使用第三方库，例如Scorpio-CSharp,ILRuntime,以及其他脚本程序，本工具链默认支持ILRuntime方式）。
总之，本工具链提倡使用<b>c#来修复c#的bug和新增功能，极大的提高编程效率</b>。欢迎使用。
</code></pre>
<p>使用方法：<br>
详情见我写的Word文档。<br>
总的来说，使用方法极其简单，基本上你可以当做没有热更新来编程。因为我们的情怀就是用c#实现热更新，为的就是节约宝贵的时间，所以自动化必须有！</p>
<p>已知问题或者限制：<br>
1、函数参数无法使用无限多个参数，目前受限于ILRT的Action和Func的参数个数，从原理来说，可以扩展到无限多个，需要手动写那块的扩展，详情ILRT的QQ群或者git。<br>
2、无法支持函数的ref和out参数，如果有用到该类参数的，请封装一个参数类（或者比较正式的叫法是实体类或者数据类）。</p>

更新情况：<br>
	   2018年2月4日11:40:57：添加注入标记，方便选择性控制哪些代码需要注入。<br>
	   2018年2月3日：完成对apk等demo的验证，可以正常使用。<br>