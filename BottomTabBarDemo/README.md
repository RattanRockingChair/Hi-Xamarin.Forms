# BottomTabBar

源:
	打算借由Forms写个运行在Droid上的小东西(别问既然用Forms为啥没有apple版，因为穷没有实体机！)，这个小程序中用到的TabbedPage的bar没法改到底部，为了解决这个问题，于是有了这个demo种的做法。
	其实已经了解到需要原生的去重新渲染，但是入门的我不会，同时又急着搞出个样例，于是决定生撸一个(这让我想起最初搞MFC时没少生撸控件)，于是就有了这个Demo。当然了该掌握的东西不能漏掉，以后有机会了再深入。
	
思路:
	一言蔽之:通过在一个Page中用View来组成。
	比方说最常见的UI结构上部分是标题，中部是内容，下部是导航。那么我可以将这三个部分分别用独立的View来做，然后在组装在一个Page中。

