using Blog.Entities.Comments;
using System;
using System.Data.Entity.Migrations;
using System.Collections.Generic;
using Blog.Entities.Articles;

namespace Blog.Data.Migrations
{


    internal sealed class Configuration : DbMigrationsConfiguration<Context.BlogContext>
    {
        protected override void Seed(Context.BlogContext context)
        {
            var articles = new List<Article>
            {
                new Article
                {
                    Author = "John Wick",
                    Time = new DateTime(2016, 8, 20),
                    ArticleTitle = "Spain's Palma to ban holiday rentals after residents' complaints",
                    ArticleBody =
                        @"<p>The #Spanish resort city of #Palma, on the island of #Majorca, is to ban flat owners from renting their apartments to travellers, becoming the first place in #Spain to introduce such a measure. </p><br/>
                        <p>The restrictions follow complaints from residents of rising rents due to short holiday lets through websites and apps. </p><br/>
                        <p>#Palma mayor says the ban, to be introduced in July, will be a model for cities suffering with mass #tourism. </p><br/>
                        <p>But #business associations say many families will be financially impacted. </p><br/>
                        <p>It was not immediately clear if the ban was restricted only to private flats advertised by their owners on apps or websites. </p><br/>
                        <p>Houses and chalets will be exempt from the restrictions unless they are located inside protected areas, next to the #airport or in industrial zones. </p><br/>"
                },

                new Article
                {
                    Author = "The Guardian",
                    Time = new DateTime(2018, 04, 26),
                    ArticleTitle = "Facebook posts record revenues for first quarter despite privacy scandal",
                    ArticleBody =
                        @"<p>#Facebook data privacy problems have had little impact on its profitability as the company posted record revenues for the first quarter of #2018. </p><br/>
                        <p>The company made $11.97bn in revenue in the first three months of the year, up 49% from the previous year, beating Wall Street estimates of $11.41bn. </p><br/>
                        <p>“Despite facing important challenges, our community and business are off to a strong start in #2018 ” said Mark #Zuckerberg, #Facebook founder and CEO, in a statement. “We are taking a broader view of our responsibility and investing to make sure our services are used for good. But we also need to keep building new tools to help people connect, strengthen our communities, and bring the world closer together.”</p><br/>
                        <p>#Facebook releases content moderation guidelines – rules long kept secret, Read more.</p><br/>
                        <p>#Facebook approach to privacy has come under intense scrutiny over the last few weeks, following the revelation that the personal data of millions of Americans was harvested from #Facebook and improperly shared with the political consultancy Cambridge Analytica. Stoked by fears that the data may have been used to try and influence elections in the US and Europe and the discovery that #Facebook collects a lot more data than the average person realises (including web browsing history and, in some cases, text messages), some users have started a Delete #Facebook movement, including the co-founder of the #Facebook WhatsApp. </p><br/>
                        <p>#Facebook user figures indicate that the movement had little effect, with daily active users rising to 1.45bn (48 million more than the previous quarter) and monthly active users to 2.2bn. Both figures mark a 13% increase from the same quarter in #2017. </p><br/>
                        <p>However, much of the momentum behind the movement came in April, when #Zuckerberg delivered eight hours of testimony before Congress, after the quarter was over.</p><br/>
                        <p>#Facebook chief financial officer, Dave Wehner, warned that GDPR could lead to a fall in users and revenue in #Europe, particularly as people start tightening up their accounts to prevent so much targeted advertising.</p><br/>
                        <p>“While we don’t expect the changes will have a significant impact on ad revenue, any change in our ability for us and advertisers to use data can impact our optimisation potential at the margin,” he said.</p><br/>
                        <p>In spite of pledging to roll out GDPR-compliant settings to all #Facebook users, the chief operating officer, Sheryl Sandberg, said the settings “would not be exactly the same format”. Because of this, #Facebook doesn’t expect there to be any impact on ad revenue outside of #Europe, indicating that those settings would not make a difference to the way #Facebook uses people’s personal data, which is the whole point of GDPR.</p><br/>
                        <p>Sandberg rejected any suggestion that #Facebook should diversify its business model away from micro-targeted advertising.</p><br/>
                        <p>“We are proud of the ad model we’ve built,” she said. “It ensures people see more useful #ads, allows businesses to grow, and keeps the service free. Advertising-supported businesses like #Facebook equalise access and improve opportunity.”</p><br/>
                        <p>#Zuckerberg said that changes the company had made to the news feed to prioritise “meaningful interaction” rather than “passive consumption” were already having an effect – with a decline in people passively watching video.</p><br/>
                        <p>""People want #Facebook to be more about friends and family and less about content consumption,” he said.""</p><br/>"
                },

                new Article
                {
                    Author = "Matt McGrath",
                    Time = new DateTime(2018, 05, 12),
                    ArticleTitle = "Cuckoo bee species 'hiding in plain sight",
                    ArticleBody =
                        @"<p>#Scientists have discovered 15 new #species of #cuckoo #bees hidden in #North-American museum collections and in an ancient thesis. </p><br/>
                            <p>Like their avian counterparts, #cuckoo #bees lay their eggs in the nests of other bees, usually solitary dwellers. </p><br/>
                            <p>When the #cuckoo hatch they kill off the usurped bees' larva and are raised by the unsuspecting host. </p><br/>
                            <p>Researchers say that this type of behaviour is common in bees and up to 15% of species are #cuckoo. </p><br/>
                            <p>While there are many different genera, or types, of #cuckoo #bees, all the new discoveries relate to one genus, #Epeolus. The new findings bring to 43 the total of #Epeolus species in #North-America. </p><br/>
                            <p>These cuckoos are said to look more like wasps than other bees, with a smoother, less fuzzy look. This is because they don't have the body hairs that other bees use to collect pollen for their young, as they rely on the hosts to do that for them. </p><br/>
                            <p>They also tend not to be seen near flowers, but are often found hovering close to the ground searching for host nests. </p><br/>
                            <p>They are sometimes seen in the early morning ""resting"" on leaves as they don't have any nests of their own. </p><br/>
                            <p>""I've been going across the US and Canada visiting museums and institutions where these bees were collected some time ago and labelled as #Epeolus but without a species being assigned,"" said Thomas Onuferko, a PhD student at York University in Toronto. </p><br/>"
                },

                new Article
                {
                    Author = "NASA & US",
                    Time = new DateTime(2018, 05, 11),
                    ArticleTitle = "Nasa will send helicopter to Mars to test otherworldly flight",
                    ArticleBody =
                        @"<p>#Nasa is sending a #helicopter to #Mars, in the first test of a heavier-than-air #aircraft on another planet. </p><br/>
                            <p>The #Mars #Helicopter will be bundled with the #US space agency's #Mars rover when it launches in 2020. </p><br/>
                            <p>Its design team spent more than four years shrinking a working #helicopter to ""the size of a softball"" and cutting its weight to 1.8kg (4lbs). </p><br/>
                            <p>It is specifically designed to fly in the atmosphere of #Mars, which is 100 times thinner than #Earth. </p><br/>
                            <p>#Nasa describes the #helicopter as a ""heavier-than-air"" aircraft because the other type - sometimes called an aerostat - are balloons and blimps. </p><br/>
                            <p>#Soviet scientists dropped two balloons into the atmosphere of Venus in the 1980s. No aircraft has ever taken off from the surface of another planet. </p><br/>
                            <p>The helicopter's two blades will spin at close to 3,000 revolutions a minute, which #Nasa says is about 10 times faster than a standard #helicopter on #Earth. </p><br/>
                            <p>""The idea of a helicopter flying the skies of another planet is thrilling,"" said Nasa Administrator Jim Bridenstine. </p><br/>
                            <p>""The #Mars Helicopter holds much promise for our future science, discovery, and exploration missions to #Mars."" </p><br/>
                            <p>While the tiny craft is being called a #helicopter rather than a drone, there will be no pilot. </p><br/>"
                }
            };
            articles.ForEach(a => context.Articles.Add(a));
            context.SaveChanges();

            var comments = new List<Comment>
            {
                new Comment
                {
                    Author = "John Wick",
                    CommentBody = "So nice site bro!!!",
                    Time = new DateTime(2018, 04, 14)
                },

                new Comment
                {
                    Author = "Peter Parker",
                    CommentBody = "Great job!!!",
                    Time = new DateTime(2018, 01, 22)
                }
            };
            comments.ForEach(c => context.Comments.Add(c));
            context.SaveChanges();
        }
    }
}

