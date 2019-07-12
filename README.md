# C# 課題集

## 難易度目安

| プロジェクト | 難易度 | 解説 |
| ---- | ---- | ---- |
| [FibonacciSequence](src/FibonacciSequence) |  初級  | [フィボナッチ数列](https://ja.wikipedia.org/wiki/%E3%83%95%E3%82%A3%E3%83%9C%E3%83%8A%E3%83%83%E3%83%81%E6%95%B0)。 |
| [FizzBuzz](src/FizzBuzz) |  初級  | まずはここから。みんな大好き [Fizz Buzz](https://ja.wikipedia.org/wiki/Fizz_Buzz) 問題。 |
| [PrimeNumber](src/PrimeNumber) |  初級  | [素数](https://ja.wikipedia.org/wiki/%E7%B4%A0%E6%95%B0)を数えて落ち着こう。 |
| [ShipCollection](src/ShipCollection) |  中級  | 艦隊をコレクションする的なゲームを模した問題。無関係だけど[これ](http://games.dmm.com/detail/kancolle/)とかやっておくとイメージしやすいかも？無関係だけど！ |
| [ValuePackage](src/ValuePackage) |  初級  | 型変換と論理演算・ビットシフトの問題。 |
| [Reversi](src/Reversi) |  上級  | オセロゲームを作る。ルールは[ここ](https://ja.wikipedia.org/wiki/%E3%82%AA%E3%82%BB%E3%83%AD_(%E9%81%8A%E6%88%AF))の「基本的なルール」に従う。|

## 実行環境

* Visual Studio 2019
* .NET Core 2.1

## テスト

* 各フォルダーのソリューションファイル（*.sln）を開いて、ソリューションをビルドする。
* 「テスト エクスプローラー」が表示されていない場合、「テスト」メニューから「ウィンドウ」->「テスト エクスプローラー」を選択。(既に表示されている場合は次へ)

![](ShowTestExproler.png)

* 「テスト エクスプローラー」を開いて「すべてを実行」をクリック。

![](ExecuteTest.png)

* 図のようにテストが失敗するので、コメントの指示に従って問題のコードを実装し、テストが通るようにする。

![](Failed.png)
