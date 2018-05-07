using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Entities.Articles
{
    public class MyArticle
    {
        public List<Article> myArticles = new List<Article>
        {
            new Article
            {
                AuthorName = "John Wick",
                PublishedTime = new DateTime(2016,8,20),
                ArticleTitle = "Spain's Palma to ban holiday rentals after residents' complaints",
                ArticleBody = @"<p>The Spanish resort city of Palma, on the island of Majorca, is to ban flat owners from renting their apartments to travellers, becoming the first place in Spain to introduce such a measure.</p><br/>
                <p>The restrictions follow complaints from residents of rising rents due to short holiday lets through websites and apps.</p><br/>
                <p>Palma's mayor says the ban, to be introduced in July, will be a model for cities suffering with mass tourism.</p><br/>
                <p>But business associations say many families will be financially impacted.</p><br/>
                <p>It was not immediately clear if the ban was restricted only to private flats advertised by their owners on apps or websites.</p><br/>
                <p>Houses and chalets will be exempt from the restrictions unless they are located inside protected areas, next to the airport or in industrial zones.</p><br/>"
            },

            new Article
            {
                AuthorName = "The Guardian",
                PublishedTime = new DateTime(2018,04,26),
                ArticleTitle = "Facebook posts record revenues for first quarter despite privacy scandal",
                ArticleBody = @"<p>Facebook’s data privacy problems have had little impact on its profitability as the company posted record revenues for the first quarter of 2018.</p><br/>
<p>The company made $11.97bn in revenue in the first three months of the year, up 49% from the previous year, beating Wall Street estimates of $11.41bn.</p><br/>
<p>“Despite facing important challenges, our community and business are off to a strong start in 2018,” said Mark Zuckerberg, Facebook’s founder and CEO, in a statement. “We are taking a broader view of our responsibility and investing to make sure our services are used for good. But we also need to keep building new tools to help people connect, strengthen our communities, and bring the world closer together.”</p><br/>
<p>Facebook releases content moderation guidelines – rules long kept secret, Read more.</p><br/>
<p>Facebook’s approach to privacy has come under intense scrutiny over the last few weeks, following the revelation that the personal data of millions of Americans was harvested from Facebook and improperly shared with the political consultancy Cambridge Analytica. Stoked by fears that the data may have been used to try and influence elections in the US and Europe and the discovery that Facebook collects a lot more data than the average person realises (including web browsing history and, in some cases, text messages), some users have started a #DeleteFacebook movement, including the co-founder of the Facebook-owned WhatsApp.</p><br/>
<p>Facebook’s user figures indicate that the movement had little effect, with daily active users rising to 1.45bn (48 million more than the previous quarter) and monthly active users to 2.2bn. Both figures mark a 13% increase from the same quarter in 2017.</p><br/>
<p>However, much of the momentum behind the movement came in April, when Zuckerberg delivered eight hours of testimony before Congress, after the quarter was over.</p><br/>
<p>In the last few weeks, the social network has announced a slew of changes to its privacy tools and to the way that it collects and shares user data. It has also introduced a verification process for political advertisers and page administrators and plans to comply with Europe’s General Data Protection Regulation (GDPR). As if to demonstrate its continued commitment to transparency, this week the company published its content moderation guidelines – a year after the Guardian revealed the secret rules.</p><br/>
<p>Facebook’s chief financial officer, Dave Wehner, warned that GDPR could lead to a fall in users and revenue in Europe, particularly as people start tightening up their accounts to prevent so much targeted advertising.</p><br/>
<p>“While we don’t expect the changes will have a significant impact on ad revenue, any change in our ability for us and advertisers to use data can impact our optimisation potential at the margin,” he said.</p><br/>
<p>In spite of pledging to roll out GDPR-compliant settings to all Facebook users, the chief operating officer, Sheryl Sandberg, said the settings “would not be exactly the same format”. Because of this, Facebook doesn’t expect there to be any impact on ad revenue outside of Europe, indicating that those settings would not make a difference to the way Facebook uses people’s personal data, which is the whole point of GDPR.</p><br/>
<p>Is Facebook replaceable? Tech investor launches bid to 'start the process', Read more.</p><br/>
<p>Sandberg rejected any suggestion that Facebook should diversify its business model away from micro-targeted advertising.</p><br/>
<p>“We are proud of the ad model we’ve built,” she said. “It ensures people see more useful ads, allows businesses to grow, and keeps the service free. Advertising-supported businesses like Facebook equalise access and improve opportunity.”</p><br/>
<p>Zuckerberg said that changes the company had made to the news feed to prioritise “meaningful interaction” rather than “passive consumption” were already having an effect – with a decline in people passively watching video.</p><br/>
<p>“People want [Facebook] to be more about friends and family and less about content consumption,” he said.</p><br/>"
            }
        };
    }
}