using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class seedcontent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CatName",
                value: "Learning to Dance");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "Now" },
                values: new object[] { "Many women feel frustrated at social dances because they do not get asked to dance. Here is my advice to help women get asked to dance more often: 1. Look as good as you can. Pay attention to which clothes and hairstyles get you the most dances and wear them. 2. Be a good dancer. Take lessons and classes. When your dance partners give you feedback on your dancing, pay attention. 3. Greet leaders when you arrive. You can even ask them to save a dance for you later. 4. After you dance with someone, thank them for the dance, smile and try to communicate to them that you had a good time dancing with them. 5. Move to a different location. If you are not getting asked to dance, walk to a different part of the room and try your luck over there. 6. Stand at the edge of the dance floor, look towards the dance floor and smile. 7. When you are dancing, do not back lead and do not criticize your partners. 8. When you are not dancing, spend some time talking and getting to know other people. Make friends. When you have friends, these people will likely dance with you in the future. 9. If you sweat when dancing (and who doesn't) consider wearing a light blouse or shirt with sleeves. Spaghetti straps my look sexy. But sweaty skin is a turn off for many people. A light blouse may feel better to your dance partners when they touch you. 10. Lastly, don't be discouraged. Most social dances have more followers than leaders. If you see many women sitting out dances, then you can know that the male female ratio is not in your favor. It is nothing personal.", new DateTime(2021, 10, 25, 9, 31, 33, 53, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "Now" },
                values: new object[] { "Serious dancers buy special shoes just for dancing. If you want to dance well, it will pay off to buy dance shoes. Good dance shoes have leather soles and will cost $100 or more if you buy them new. You will probably have to order them online or go to a special store. Good tango shoes brands are Comme Il Faut from Buenos Aires and Tangolera from Italy. Salsa dancers can search for ballroom or latin dance shoes online. Again make sure they have leather or suede soles. Ladies' heels should be 2 inches or less for salsa. It is hard to spin in high heels. I do not recommend ordering cheap shoes from China. They may look cute, but they will be uncomfortable and they will not last long. Good dance shoes should fit snugly, but not hurt. If the shoes are leather, they will stretch over time. They may be a little tight at first but will break in after a little wear. Try to try the shoes on before you buy them. If you want to save money, you can buy used shoes on Poshmark. Yes, dance shoes cost a little bit of money, but the investment is worth it. You will notice an improvement in your dancing with the right shoes.", new DateTime(2021, 10, 25, 9, 31, 33, 59, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "Now" },
                values: new object[] { "I am from Puerto Rico and I grew up listening to bachata music. Some of my favorite bachateros are: Anthony Santos and Joey Vera.", new DateTime(2021, 10, 25, 9, 31, 33, 59, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Body", "Now", "Title" },
                values: new object[] { "You could write a PhD dissertation on the origins of salsa music. Here is my understanding of it. Salsa music (like the food salsa) is a mixture - a mixture of different music from many different parts of the world. All the ingredients of salsa come together and create sabor rico. Salsa comes from African percussion music and Cuban music styles such as danzon, guajira and son. Danzon has origins in Spanish music from Spain. But salsa was born in New York City. It was created by Puerto Rican and Cuban immigrants in the 1960s and 1970s. It also incorporates elements of American jazz. And it grew out of mambo and cha cha, which were popular in the 1950s. We also need to keep in mind that many Puerto Ricans have native, indigenous Taino heritage, and this is also another culture in the mix.", new DateTime(2021, 10, 25, 9, 31, 33, 59, DateTimeKind.Local).AddTicks(2904), "The Origins of Salsa Music" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Body", "Now" },
                values: new object[] { "Of course you do not need to know Spanish to enjoy dancing Bachata. However it does deepen your appreciation of the music, if you can understand what the lyrics say. If you are learning Spanish, listening to popular Latin music is a great way to improve your language skills. Also you can look up your favorite songs translated into English using Google. You can use Shazaam to identify the dance songs that are being played in your favorite Latin club. Then make a list of dance music using YouTube or YouTube Music. Then you can listen to Bachata music at home or in your car. The more you know the music, the better dancer you will be.", new DateTime(2021, 10, 25, 9, 31, 33, 59, DateTimeKind.Local).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Body", "Now" },
                values: new object[] { "I think tango is the hardest dance to learn, especially for beginners. It can take years before you feel proficient at tango. However every dance is complicated in its own way. And you never know everything there is to know about any dance. Salsa is also hard to learn because the timing is tricky. Bachata and merengue are easier to learn and this makes them very popular.", new DateTime(2021, 10, 25, 9, 31, 33, 59, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Body", "Now", "Title" },
                values: new object[] { "Social dancing is a great way for single people to meet each other, but things can become a little complicated when you are in a relationship and you and/or your partner want to go out dancing. Should you dance only with each other or should you dance with other people? What if your partner feels jealous, or you feel jealous? Here are some tips: 1. Communication is key. Talk to your partner and agree on some rules. The rules will likely change over time, and that is okay. It will take time and mistakes to see what works for your relationship. 2. Jealousy is VERY common when partners dance with other people. It is totally natural and normal. Jealousy can be controlled if you work at it. 3. Some couples only dance with each other. Some couples dance with other people. Both are common and either way is totally fine. It depends on how you feel comfortable. Sometimes partners like to go dancing separately. 4. Here are some common social dancing rules that may or may not work for you. You can use them to explore what rules your relationships needs: a. not dancing in close embrace with other people b. dance the last dance of the night with your partner c. stand next to your partner, when you are not dancing d. introduce your dance partners to your significant other e. never say no to your partner when they ask for a dance", new DateTime(2021, 10, 25, 9, 31, 33, 59, DateTimeKind.Local).AddTicks(2946), "The Couple's Guide to Social Dancing" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Body", "Now" },
                values: new object[] { "Are you interested in learning to dance salsa, but don't know where to start? Here are some salsa moves that you can start with: 1. The Basic - Start with the basic timing and footwork. can't dance. Timing is everything. Without timing you Practice the timing until you can do it automatically without having to count in your head. When you are dancing, your feet should be doing the basic all the time. 2. Right Turn - turn to the right. 3. Left Turn - turn to the left. 4. Cross Body Lead - the man leads the woman past him. Basically you switch directions 180. 5. Shines - this is when you dance separately, not touching you partner.", new DateTime(2021, 10, 25, 9, 31, 33, 59, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Body", "Now" },
                values: new object[] { "A milonga is the name for a social dance in Argentine Tango. If you want to go to a milonga, it is good to learn a few important social rules. 1. Cabaceo - In Argentine Tango, it is considered impolite to walk up to someone and ask them to dance. Instead we use cabaceo. Here is the process. First a woman looks at a man she wants to dance with. This is called Mirada. Then the man makes a subtle signal to her, such as a nod towards the dance floor. The woman nods in agreement. Then the man walks over to her and escorts her to the dance floor. Not every tango dancer uses cabaceo, but many do, and some people will get upset if you ask for a dance more directly. Cabaceo may seem weird and confusing at first, but it does work. It also makes rejection very easy. All you do is look away and you do not have to dance with that person. 2. Tandas - Tango music is played in sets of three or four songs together, called a tanda. When you accept a dance in tango, you are agreeing to dance the entire tanda with your partner. It is considered rude to walk away from your partner in the middle of a tanda. You will know when the tanda is over because the DJ will play a cortina, which a short bit of non-tango music. The cortina can be any style of music: pop music, jazz, etc. During the cortina, you thank your partner for dancing with you, go back to your seat and look for another partner for the next tanda. 3. Please remember it is not appreciated to teach on the dance floor or offer unwanted criticisms of your partners dancing.", new DateTime(2021, 10, 25, 9, 31, 33, 59, DateTimeKind.Local).AddTicks(3128) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CatName",
                value: "Dance Steps");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "Now" },
                values: new object[] { "Body body body body body body body body body body body body body body body body body", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "Now" },
                values: new object[] { "Body body body body body body body body body body body body body body body body body", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "Now" },
                values: new object[] { "Body body body body body body body body body body body body body body body body body", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Body", "Now", "Title" },
                values: new object[] { "Body body body body body body body body body body body body body body body body body", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Who Is The Best Salsa Singer Of All Time: Marc Anthony Or Hector Lavoe?" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Body", "Now" },
                values: new object[] { "Body body body body body body body body body body body body body body body body body", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Body", "Now" },
                values: new object[] { "Body body body body body body body body body body body body body body body body body", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Body", "Now", "Title" },
                values: new object[] { "Body body body body body body body body body body body body body body body body body", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dancing Couple's Guide To Navigating Jealousy" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Body", "Now" },
                values: new object[] { "Body body body body body body body body body body body body body body body body body", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Body", "Now" },
                values: new object[] { "Body body body body body body body body body body body body body body body body body", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
