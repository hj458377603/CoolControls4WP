CoolControls4WP
===============
1.实现按钮右上角带有提示功能的Appbar。

效果如图：
<br />
<img src="http://images.cnblogs.com/cnblogs_com/fb-boy/520080/o_%e6%8c%89%e9%92%ae%e5%8f%b3%e4%b8%8a%e8%a7%92%e5%b8%a6%e6%9c%89%e6%96%87%e6%9c%ac%e6%8f%90%e7%a4%ba%e5%8a%9f%e8%83%bd%e7%9a%84AppBar.PNG"/>
<br />
<br />
按钮不可点击效果：
<br />
<img src="http://images.cnblogs.com/cnblogs_com/fb-boy/520080/o_%e6%8c%89%e9%92%ae%e4%b8%8d%e5%8f%af%e7%82%b9%e5%87%bb%e9%80%8f%e6%98%8e%e5%ba%a6%e6%8e%a7%e5%88%b6.PNG"/>
<br />
<br />
提示文本2位数效果，已经不同的背景色：
<br />
<img src="http://images.cnblogs.com/cnblogs_com/fb-boy/520080/o_%e6%8f%90%e7%a4%ba%e6%96%87%e6%9c%ac%e7%9a%84%e4%b8%8d%e5%90%8c%e8%83%8c%e6%99%af%e8%89%b2.PNG"/>
<br />
<a href="http://msdn.microsoft.com/zh-cn/library/windowsphone/develop/system.windows.controls.control.focus(v=vs.105).aspx">添加LostFocus事件</a>
为了能够设置焦点，必须满足以下条件：
将 Visibility 设置为 Visible。
IsTabStop 设置为 true。
IsEnabled 设置为 true。
必须在树中实例化控件（已引发 Loaded 事件）。
