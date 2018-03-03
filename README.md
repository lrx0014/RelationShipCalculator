# RelationShipCalculator

(工程使用MVVMLight重新组织)

The traditional Chinese kinship is complicated and difficult to remember. The project is a practical and interesting application. The corresponding relative call can be gained after inputting a relation chain in the calculator (e.g input: the son of dad’s elder brother’s wife; input: cousin); it is a Win10 UWP application; use C# + XAML in VS2017 for development; the data is from a open source project 

**(Thanks:mumuy:https://github.com/mumuy/relationship)**

中国传统的亲戚关系称谓繁多复杂难以记忆，亲戚关系计算器是一个实用的趣味应用，在计算器中输入一个关系链条就可以获得其对应的亲戚称呼(e.g:输入：爸爸的哥哥的老婆的儿子，输出：堂兄弟)；这是一个Win10 UWP应用，在VS2017上使用C# + XAML开发.

数据取自开源项目 **(感谢mumuy:https://github.com/mumuy/relationship)**

原作者的版本是用JS实现，功能完整数据齐全，这个库衍生了许多web应用、微信小程序和安卓APP；但是我发现Windows应用商店鲜有同类应用，所以就开发了一个Win10版本，使用C#对原版程序进行了重写，并且修改了逻辑，使用MVVM开发模式重构，使数据和逻辑解耦，从而实现数据的动态更新。 
