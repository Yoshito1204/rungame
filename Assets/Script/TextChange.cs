using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{

    public Text text1;
    public Text text2;


    // Start is called before the first frame update
    void Start()
    {
        int r = Random.Range(0, 82);

        if(r == 1)
        {
            text1.text = "深夜三時三十分三十三秒に合わせ鏡をすると未来の結婚相手が映る";
            text2.text = "都市伝説";
        }
        else if(r == 2)
        {
            text1.text = "ある小学校では子供が持ってきたゲームソフトを勝手に持ち帰る「ゲームばばあ」がいる";
            text2.text = "都市伝説";
        }
        else if(r == 3)
        {
            text1.text = "ティラノサウルスの脳は大体500グラムらしい";
            text2.text = "雑学";
        }
        else if (r == 4)
        {
            text1.text = "失敗？これはうまくいかないということを確認した成功だよ。";
            text2.text = "名言";
        }
        else if (r == 5)
        {
            text1.text = "「努力してます」と練習を売り物にする選手は、一流とはいえない。";
            text2.text = "名言";
        }
        else if (r == 6)
        {
            text1.text = "考えなさい。調査し、探究し、問いかけ、熟考するのです。";
            text2.text = "名言";
        }
        else if (r == 7)
        {
            text1.text = "論理はA地点からB地点まであなたを連れて行ってくれる。想像力は、あなたをどこへでも連れて行ってくれる。";
            text2.text = "名言";
        }
        else if (r == 8)
        {
            text1.text = "「ねこばば」を漢字で書くと「猫糞」";
            text2.text = "雑学";
        }
        else if (r == 9)
        {
            text1.text = "世の中には3つのやり方がある。正しいやり方。間違ったやり方。そして俺のやり方。";
            text2.text = "名言";
        }
        else if (r == 10)
        {
            text1.text = "素晴らしい計画は不要だ。計画は5％、実行が95％だ。";
            text2.text = "名言";
        }
        else if (r == 11)
        {
            text1.text = "自分が出したアイディアを、少なくとも一度は人に笑われるようでなければ、独創的な発想をしているとは言えない。";
            text2.text = "名言";
        }
        else if (r == 12)
        {
            text1.text = "待っている人達にも何かが起こるかもしれないが、それはがんばった人達の残り物だけである。";
            text2.text = "名言";
        }
        else if (r == 13)
        {
            text1.text = "撃って良いのは、撃たれる覚悟のある奴だけだ";
            text2.text = "名言";
        }
        else if (r == 14)
        {
            text1.text = "何かを変えることのできる人間がいるとすれば、その人は、きっと…大事なものを捨てることができる人だ";
            text2.text = "名言";
        }
        else if (r == 15)
        {
            text1.text = "世界に何かおもしろいことを投げかければ、必ず批判を受けるものです。批判に耐えられないのであれば、新しいことやおもしろいことをしないほうがいいでしょう";
            text2.text = "名言";
        }
        else if (r == 16)
        {
            text1.text = "ひどい目に遭ったときは良いことがある前兆だと思わないと。あとは上に行くしかないんで。それは良いことのきっかけの“エクスプロージョン”の前だ";
            text2.text = "名言";
        }
        else if (r == 17)
        {
            text1.text = "「ムラサキカガミ」という言葉を20歳まで覚えていたら死ぬ";
            text2.text = "都市伝説";
        }
        else if (r == 18)
        {
            text1.text = "「孫の手」はもともと若く美しい女性の手";
            text2.text = "雑学";
        }
        else if (r == 19)
        {
            text1.text = "無茶と無謀は若者の特権だ";
            text2.text = "名言";
        }
        else if (r == 20)
        {
            text1.text = "中途半端にやると他人のマネになる。とことんやると他人がマネできないものになる。";
            text2.text = "名言";
        }
        else if (r == 21)
        {
            text1.text = "夢を叶えるコツは狂ったように欲しがること。";
            text2.text = "名言";
        }
        else if (r == 22)
        {
            text1.text = "満足しない事は、スキルを上げる一番のテクニックだ。";
            text2.text = "名言";
        }
        else if (r == 23)
        {
            text1.text = "努力を癖にしてしまえば苦労せずに成功できるだろう。";
            text2.text = "名言";
        }
        else if (r == 24)
        {
            text1.text = "「あの頃はよかった」って？それはお前が止まっとるんじゃ。";
            text2.text = "名言";
        }
        else if (r == 25)
        {
            text1.text = "問いを持った部族は生き残ったが、答えを持った部族は滅びた";
            text2.text = "名言";
        }
        else if (r == 26)
        {
            text1.text = "常識と非常識がぶつかったときに、イノベーションが生まれる";
            text2.text = "名言";
        }
        else if (r == 27)
        {
            text1.text = "解決策がわからないのではない。問題がわかっていないのだ。";
            text2.text = "名言";
        }
        else if (r == 28)
        {
            text1.text = "最高の思考は、一人の時に生まれ、最低の思考というのは、混乱の中から生まれる。";
            text2.text = "名言";
        }
        else if (r == 29)
        {
            text1.text = "何事であれ、最終的には自分で考える覚悟がないと、情報の山に埋もれるだけである。";
            text2.text = "名言";
        }
        else if (r == 30)
        {
            text1.text = "知恵への投資こそ、最も利回りが高い。";
            text2.text = "名言";
        }
        else if (r == 31)
        {
            text1.text = "世間が必要としているものと、あなたの才能が交わっているところに天職がある。";
            text2.text = "名言";
        }
        else if (r == 32)
        {
            text1.text = "すべてのルールに従って生きていたら、私はどこにも行けやしないわ。";
            text2.text = "名言";
        }
        else if (r == 33)
        {
            text1.text = "最も強い者が生き残るのではなく、最も賢い者が生き延びるでもない。唯一生き残るのは、変化できる者である。";
            text2.text = "名言";
        }
        else if (r == 34)
        {
            text1.text = "挫折を経験した事がない者は、何も新しい事に挑戦したことが無いということだ。";
            text2.text = "名言";
        }
        else if (r == 35)
        {
            text1.text = "僕の前に道はない、僕の後に道はできる。";
            text2.text = "名言";
        }
        else if (r == 36)
        {
            text1.text = "豊かさと平和は、臆病者をつくる。苦難こそ強さの母だ。";
            text2.text = "名言";
        }
        else if (r == 37)
        {
            text1.text = "名言を探してる暇があったら勉強しろ";
            text2.text = "名言";
        }
        else if (r == 38)
        {
            text1.text = "どんなに暗くても、星は輝いている。";
            text2.text = "名言";
        }
        else if (r == 39)
        {
            text1.text = "あなたが転んでしまったことに関心はない。そこから立ち上がることに関心があるのだ。";
            text2.text = "名言";
        }
        else if (r == 40)
        {
            text1.text = "自分で自分をあきらめなければ、人生に「負け」はない。";
            text2.text = "名言";
        }
        else if (r == 41)
        {
            text1.text = "信長が秀吉につけたあだ名は「サル」ではなく「ハゲネズミ」らしい";
            text2.text = "都市伝説";
        }
        else if (r == 42)
        {
            text1.text = "「破天荒」の意味は「豪快で大胆」ではなく「誰もなしえなかったことをする」";
            text2.text = "雑学";
        }
        else if (r == 43)
        {
            text1.text = "「大学イモ」の「大学」は東京大学のこと";
            text2.text = "雑学";
        }
        else if (r == 44)
        {
            text1.text = "アンテキヌスという有袋類は交尾のし過ぎで死ぬ";
            text2.text = "雑学";
        }
        else if (r == 45)
        {
            text1.text = "トウモロコシの粒は必ず偶数";
            text2.text = "雑学";
        }
        else if (r == 46)
        {
            text1.text = "ブタの体脂肪率は15％程度";
            text2.text = "雑学";
        }
        else if (r == 47)
        {
            text1.text = "マムシはマムシに嚙まれても死なない";
            text2.text = "雑学";
        }
        else if (r == 48)
        {
            text1.text = "バナナと人間のDNAは50％が同じらしい";
            text2.text = "都市伝説";
        }
        else if (r == 49)
        {
            text1.text = "浦島太郎が助けたカメはたぶんアカウミガメのメス";
            text2.text = "都市伝説";
        }
        else if (r == 50)
        {
            text1.text = "3キロ以上の哺乳類のおしっこは約21秒";
            text2.text = "雑学";
        }
        else if (r == 51)
        {
            text1.text = "ハリセンボンの針は370本前後";
            text2.text = "雑学";
        }
        else if (r == 52)
        {
            text1.text = "「ミカンを揉むと甘くなる」は科学的に正しい";
            text2.text = "雑学";
        }
        else if (r == 53)
        {
            text1.text = "哲学者のルソーは半裸で女性に「おしりを叩いて！」と言って警察に連行されたらしい";
            text2.text = "都市伝説";
        }
        else if (r == 54)
        {
            text1.text = "禁欲主義者ガンジーは毎晩裸の女性と寝ていたらしい";
            text2.text = "都市伝説";
        }
        else if (r == 55)
        {
            text1.text = "古代ローマではおしっこでうがいをしていたらしい";
            text2.text = "都市伝説";
        }
        else if (r == 56)
        {
            text1.text = "最初に空を飛んだのはライト兄弟の弟オービル";
            text2.text = "雑学";
        }
        else if (r == 57)
        {
            text1.text = "アインシュタインの脳は切り刻まれて各地で保存されている";
            text2.text = "雑学";
        }
        else if (r == 58)
        {
            text1.text = "ナポレオンは「アソコのサイズ」にコンプレックスを持っていたらしい";
            text2.text = "都市伝説";
        }
        else if (r == 59)
        {
            text1.text = "ギリシャの国歌は158番まである";
            text2.text = "雑学";
        }
        else if (r == 60)
        {
            text1.text = "人間は1年のうち9日をまばたきに使う";
            text2.text = "雑学";
        }
        else if (r == 61)
        {
            text1.text = "キスマークはれっきとした「怪我」である";
            text2.text = "雑学";
        }
        else if (r == 62)
        {
            text1.text = "薬指が長い男性は高収入で女性にモテるらしい";
            text2.text = "都市伝説";
        }
        else if (r == 63)
        {
            text1.text = "大便に付着する大腸菌はトイレットペーパーを貫通する";
            text2.text = "雑学";
        }
        else if (r == 64)
        {
            text1.text = "使用済み歯ブラシに付着する細菌は便器の水の80倍らしい";
            text2.text = "都市伝説";
        }
        else if (r == 65)
        {
            text1.text = "お風呂でオナラをすると数万の大腸菌がお湯に溶けるらしい";
            text2.text = "都市伝説";
        }
        else if (r == 66)
        {
            text1.text = "トイレットペーパーのシングルとダブルではシングルの方がお得";
            text2.text = "雑学";
        }
        else if (r == 67)
        {
            text1.text = "実は一般人でも犯罪者を現行犯逮捕できる";
            text2.text = "雑学";
        }
        else if (r == 68)
        {
            text1.text = "マイナスドライバーを持ち歩くと罪になる";
            text2.text = "雑学";
        }
        else if (r == 69)
        {
            text1.text = "グーグルで「人生、宇宙、すべての答え」と検索してみて！";
            text2.text = "雑学";
        }
        else if (r == 70)
        {
            text1.text = "父親の25人に1人が他人の子供を知らずに育てているらしい";
            text2.text = "都市伝説";
        }
        else if (r == 71)
        {
            text1.text = "パソコンのキーボードはトイレの便座より汚いらしい";
            text2.text = "都市伝説";
        }
        else if (r == 72)
        {
            text1.text = "最初にパーを出すとジャンケンに勝ちやすい";
            text2.text = "雑学";
        }
        else if (r == 73)
        {
            text1.text = "千手観音の手は42本しかない";
            text2.text = "雑学";
        }
        else if (r == 74)
        {
            text1.text = "男性を表す「♂」はアレの形ではない";
            text2.text = "雑学";
        }
        else if (r == 75)
        {
            text1.text = "日本人が寝るときに羊を数えても意味はない";
            text2.text = "雑学";
        }
        else if (r == 76)
        {
            text1.text = "かき氷のシロップは全部同じ味";
            text2.text = "雑学";
        }
        else if (r == 77)
        {
            text1.text = "「レタス○個分」を信用してはいけない";
            text2.text = "雑学";
        }
        else if (r == 78)
        {
            text1.text = "ブルーベリーは体にいいのは確かだが視力回復効果を裏付けるデータはない";
            text2.text = "雑学";
        }
        else if (r == 79)
        {
            text1.text = "ドリンクバーは40杯以上飲まないと元が取れないらしい";
            text2.text = "都市伝説";
        }
        else if (r == 80)
        {
            text1.text = "私たちがよく食べる「合鴨肉」ははとんどがアヒル";
            text2.text = "雑学";
        }
        else if (r == 81)
        {
            text1.text = "「糖類ゼロ」は「糖質ゼロ」よりカロリーが高い";
            text2.text = "雑学";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
