using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xyrille.ResearchDatabaseManagement.Windows.DAL
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseAlways<RDBManagementDBContext>
    {
        protected override void Seed(RDBManagementDBContext context)
        {
            #region Research
            context.Researches.Add(new Models.Research()
            {
                Author = "Mr. Gary Garay (Faculty Research)",
                Title = "TWO- WAY ANALYSIS OF FORMS, FUNCTIONS AND MEANING IN SCHOOL MEMORANDA",
                Abstract = "This research was conceptualized to analyze the different characteristics of memorandum in terms of form and structure through Text Linguistics and meaning through Discourse Analysis. It is a document used for organizational communication that records observation on important events, a form of communication most commonly used in the academe. The length of a memorandum may vary according to the message it wants to impart ( Acheson, 2012). Text Linguistics studies the different means or systems of communication. Its main objective is to analyze and describe text grammars while discourse analysis is an analysis of any form of communication by considering meaning as it is handed down to readers. Findings revealed that the most commonly employed techniques used by crafters of memo are principle of reference and meaning reference. The former means that specific nature is signaled for retrieval while the latter constitutes idea to be retrieved. The research revealed that the crafters may completely know how to write memo because they just patterned it from their predecessors. The outcome of this study shall be utilized as basis for conducting enhancement and training programs both for the writers and readers of said memorandum.",
                Leadline = "The former means that specific nature is signaled for retrieval while the latter constitutes idea to be retrieved. The research revealed that the crafters may completely know how to write memo because they just patterned it from their predecessors. The outcome of this study shall be utilized as basis for conducting enhancement and training programs both for the writers and readers of said memorandum.",
                Year = "12-18-2020",
                ResearchID = Guid.Parse("30c53f9e-f0d7-479d-9454-4465555e2568"),
                IsPublish = true,
            });

            context.Researches.Add(new Models.Research()
            {
                Author = "Dr. Editha A. Lupdag-Padama (Arellano University)",
                Title = "An Approximation of the Internal Rate of Return of Investment in Selected Undergraduate Degree Programs (*CHED Research Project)",
                Abstract = "The situation of a typical Filipino household, overseas employment, and the culture of migration are deemed as determinants for investing in higher education such as in the specialized fields of accountancy, education science and teacher training, engineering, and nursing. We examine both local and international labor demand for accountants, teachers, engineers, and nurses as well as its underlying implications on the exodus of professionals. As such, the determination of the internal rate of return to investment is of crucial importance to households to fully maximize educational opportunities and for the government and other institutions to confront this globally-changing situation. Using a combination of quantitative and qualitative analysis, we compute for the internal rates of return of investment of the mentioned degree programs. Results have shown that the relatively high rates of return are incentives to practice profession abroad despite various delays.",
                Leadline = "we compute for the internal rates of return of investment of the mentioned degree programs. Results have shown that the relatively high rates of return are incentives to practice profession abroad despite various delays.",
                Year = "12-18-2020",
                ResearchID = Guid.Parse("426a7ddd-4286-4d96-bb10-f27442a52f3b"),
                IsPublish = true,
            });

            context.Researches.Add(new Models.Research()
            {
                Author = "BGEN Marlene R Padua, AFP (Ret)",
                Title = "The Spiritual Wellbeing among Cancer Survivors: A Journey through a Valley of Darkness",
                Abstract = "In this grounded study, the social process explored is the experience of attaining wellbeing among cancer survivors. The main theme, “The Spiritual Wellbeing among Cancer Survivors: A Journey through a Valley of Darkness” bespeaks of a spirit-centric transformation among cancer survivors. Their pain and suffering induced a striving for higher integration to find balance. Spirituality emerged as a significant aspect among the participants. Realizing their physical limitations and mortality, they looked up to their faith. Their spirits rise from their ailing bodies. Connecting to God for strength and healing was a necessity for them to find relief. Communing with God/ Higher Being made their spirits stronger and alive. Thus spirit driven, they strived and struggled for development to become whole and transcend to a new concept of wellbeing. The cancer survivors went beyond their pain and suffering for higher integration and transcendence",
                Leadline = "Communing with God/ Higher Being made their spirits stronger and alive. Thus spirit driven, they strived and struggled for development to become whole and transcend to a new concept of wellbeing. The cancer survivors went beyond their pain and suffering for higher integration and transcendence",
                Year = "12 -18-2020",
                ResearchID = Guid.Parse("f3ce9c3e-3942-40dd-b131-796d6f11cafa"),
                IsPublish = true,
            });

            context.Researches.Add(new Models.Research()
            {
                Author = "Eduardo M. Lorico",
                Title = "Isolation and Determination of the Bioremediation Potential of Bunker Sludge Degrading Bacteria from Manila Bay",
                Abstract = "Bunker sludge degrading microorganisms were isolated using enrichment culture technique from the polluted waters of Manila Bay. Water samples were inoculated using liquid mineral media (LAM). Isolates were tentatively identified as Xanthomonas sp.,Alcaligenes sp, Enterobacter sp. and Flavobacterium sp. Two parameters were tested evaluating the biodegradative abilities of individual isolates to degrade bunker sludge and the effect of chicken manure as added source of nitrates and phosphates. Results revealed no significant difference between pure and mixed cultures in ability to degrade Microorganisms can be complimentary or competitive. Adding chicken manure resulted is a decreased ability to degrade bunker sludge. However, addition of chicken manure resulted in the highest biodegradation rate. This result can be attributed to exponential growth of microorganisms due to augmentation of necessary metabolites leading to cooperative catabolism of bunker sludge",
                Leadline = "Two parameters were tested evaluating the biodegradative abilities of individual isolates to degrade bunker sludge and the effect of chicken manure as added source of nitrates and phosphates. Results revealed no significant difference between pure and mixed cultures in ability to degrade",
                Year = "12 -18-2020",
                ResearchID = Guid.Parse("f9240419-7f16-46b5-8309-da663afba848"),
                IsPublish = true,
            });

            context.Researches.Add(new Models.Research()
            {
                Author = "Anthony Rios Marin",
                Title = "Hepatoprotective Activity of the Flavonoids from the Rind of Pomelo (Citrus grandis, Linn., Family Rutaceae) on Carbon Tetrachloride-Induced Liver Damage on Rats",
                Abstract = "This  study was conducted to determine the hepatoprotective activity of the flavonoids obtained from the rind of pomelo (Citrus grandis Linn.). Specifically the study aimed to determine the flavonoids present, its physical and chemical properties, toxicity levels, and pharmacological activity when compared with the commercially available Silymarin. The significant difference in the hepatoprotective activity of the flavonoids when orally and intra-peritoneally administered was also established",
                Leadline = "The significant difference in the hepatoprotective activity of the flavonoids when orally and intra-peritoneally administered was also established",
                Year = "12 -18-2020",
                ResearchID = Guid.Parse("19e25c1b-5bf8-4a31-8120-ad7fedea88a6"),
                IsPublish = true,
            });

            #endregion

            #region ResearchAuthor
            context.ResearchAuthors.Add(new Models.Research_Author()
            {
                ResearchAuthorID = Guid.Parse("30c53f9e-f0d7-479d-9454-4465555e2568"),
                Year = "12-18-2020",
            });

            context.ResearchAuthors.Add(new Models.Research_Author()
            {
                ResearchAuthorID = Guid.Parse("426a7ddd-4286-4d96-bb10-f27442a52f3b"),
                Year = "12-18-2020",
            });

            context.ResearchAuthors.Add(new Models.Research_Author()
            {
                ResearchAuthorID = Guid.Parse("f3ce9c3e-3942-40dd-b131-796d6f11cafa"),
                Year = "12-18-2020",
            });

            context.ResearchAuthors.Add(new Models.Research_Author()
            {
                ResearchAuthorID = Guid.Parse("f9240419-7f16-46b5-8309-da663afba848"),
                Year = "12-18-2020",
            });

            context.ResearchAuthors.Add(new Models.Research_Author()
            {
                ResearchAuthorID = Guid.Parse("19e25c1b-5bf8-4a31-8120-ad7fedea88a6"),
                Year = "12-18-2020",
            });
            #endregion

            #region Author
            context.Authors.Add(new Models.Author()
            {
                AuthorID = Guid.Parse("56af0fb8-c64d-4bf5-a2cd-8b0990a50289"),
                FirstName = "Gary",
                LastName = "Garay",
                URL = "123456789.com"

            });


            context.Authors.Add(new Models.Author()
            {
                AuthorID = Guid.Parse("5fa6476d-03f4-45b7-a0cc-067e76e40a6e"),
                FirstName = "Editha",
                LastName = "Lupdag-Padama",
                URL = "123456789.com"

            });

            context.Authors.Add(new Models.Author()
            {
                AuthorID = Guid.Parse("e7bcc62c-b3d9-4842-bc18-1cd35068fd54"),
                FirstName = "BGEN Marlene",
                LastName = "Padua",
                URL = "123456789.com"

            });

            context.Authors.Add(new Models.Author()
            {
                AuthorID = Guid.Parse("f0dc85ec-41e2-459b-8916-ada1eaee9717"),
                FirstName = "Eduardo",
                LastName = " Lorico",
                URL = "123456789.com"

            });


            context.Authors.Add(new Models.Author()
            {
                AuthorID = Guid.Parse("a978db4e-e10d-4ff9-911d-84b0138a8862"),
                FirstName = "Anthony ",
                LastName = "Rios Marin",
                URL = "123456789.com"

            });
            #endregion


            #region User
            context.Users.Add(new Models.User()
            {
               Username = "Apple",
               Address = "Apple_Dinalupihan_Bataan",
               Password = "123456789",
               UserEmail = "Apple@gmail.com",
               UserID = Guid.Parse("84d65440-4aec-4c48-a029-d558d384a66a"),

            });


        

            context.Users.Add(new Models.User()
            {
                Username = "Buko",
                Address = "Buko",
                Password = "123456789",
                UserEmail = "buko@gmail.com",
                UserID = Guid.Parse("4438e7ed-f04e-40e6-96ec-7d8c535f7f12"),

            });

            context.Users.Add(new Models.User()
            {
                Username = "Cat",
                Address = "Cat_Dinalupihan_Bataan",
                Password = "123456789",
                UserEmail = "cat@gmail.com",
                UserID = Guid.Parse("bcc88381-576a-408c-aad6-a2ff34c0f8ff"),

            });


            context.Users.Add(new Models.User()
            {
                Username = "Dog",
                Address = "Dog_Dinalupihan_Bataan",
                Password = "123456789",
                UserEmail = "dog@gmail.com",
                UserID = Guid.Parse("01036f30-0bbc-4689-a3d1-8f87fcbd9126"),

            });

                context.Users.Add(new Models.User()
            {
                Username = "Egg",
                Address = "Egg_Dinalupihan_Bataan",
                Password = "123456789",
                UserEmail = "egg    @gmail.com",
                UserID = Guid.Parse("95a5ffc7-e9d2-4acc-be9e-3f6dcd18d847"),

            });
            #endregion


        }
    }
}
