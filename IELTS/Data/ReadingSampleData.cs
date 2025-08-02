using IELTS.EntityModels;
using IELTS.EntityModels.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace IELTS.Data
{
    public static class ReadingSampleData
    {
        public static async Task SeedReadingData(IELTSStoreDbContext context)
        {
            // Check if data already exists
            if (await context.ReadingPassages.AnyAsync())
                return;

            var passages = new List<ReadingPassage>
            {
                // Academic Reading - Section 1
                new ReadingPassage
                {
                    Title = "The History of Chocolate",
                    Content = @"Chocolate has a rich and fascinating history that spans over 3,000 years. The story begins with the ancient civilizations of Mesoamerica, where the cacao tree (Theobroma cacao) was first cultivated. The Olmecs, who lived in what is now Mexico around 1500-400 BCE, were likely the first to discover the potential of cacao beans.

The Maya civilization (2000 BCE - 1500 CE) elevated cacao to divine status. They believed that the cacao tree was a gift from the gods and used cacao beans not only as a beverage but also as currency. The Maya prepared a bitter drink called 'xocolatl' by grinding cacao beans with spices like chili peppers and vanilla. This drink was reserved for nobility and warriors, and it played a central role in religious ceremonies.

The Aztecs, who dominated central Mexico from the 14th to 16th centuries, inherited the Maya's reverence for cacao. They believed that the god Quetzalcoatl had given cacao to humans, and they used cacao beans as a form of currency throughout their empire. The Aztec emperor Montezuma II was said to consume dozens of cups of chocolate daily, believing it gave him strength and vitality.

When Spanish conquistador Hernán Cortés arrived in Mexico in 1519, he encountered this chocolate drink. Initially, the Spanish found the bitter taste unpalatable, but they soon learned to sweeten it with sugar and honey. By the late 16th century, chocolate had made its way to Spain, where it became popular among the aristocracy.

The spread of chocolate throughout Europe was gradual but steady. From Spain, it traveled to other European courts, reaching France in the 17th century when Spanish princess Maria Theresa married French King Louis XIV. The French refined chocolate preparation techniques and opened the first chocolate houses, similar to coffeehouses.

The Industrial Revolution brought significant changes to chocolate production. In 1828, Dutch chemist Coenraad van Houten invented a hydraulic press that could extract cocoa butter from cacao beans, creating cocoa powder. This innovation made chocolate more affordable and easier to prepare. The first solid chocolate bar was created in 1847 by British company Fry & Sons.

Swiss chocolatiers made crucial contributions to modern chocolate. In 1875, Daniel Peter invented milk chocolate by adding condensed milk to chocolate. Rodolphe Lindt developed the conching process in 1879, which gave chocolate its smooth texture and enhanced flavor. These innovations established Switzerland as a leader in chocolate production.

The 20th century saw chocolate become a global commodity. Companies like Hershey, Cadbury, and Nestlé mass-produced chocolate, making it accessible to people worldwide. Today, chocolate is enjoyed in countless forms, from simple candy bars to elaborate desserts, and the global chocolate industry is worth billions of dollars annually.",
                    DifficultyLevel = "Academic",
                    Section = "Section 1",
                    TimeLimit = 20,
                    Description = "A passage about the historical development of chocolate from ancient civilizations to modern times.",
                    CreatedOn = DateTime.UtcNow,
                    Questions = new List<ReadingQuestion>
                    {
                        new ReadingQuestion
                        {
                            QuestionNumber = 1,
                            QuestionText = "According to the passage, which civilization was likely the first to discover cacao beans?",
                            QuestionType = "MultipleChoice",
                            Options = JsonSerializer.Serialize(new List<string> { "The Maya", "The Olmecs", "The Aztecs", "The Spanish" }),
                            CorrectAnswer = "The Olmecs",
                            Explanation = "The passage states that 'The Olmecs, who lived in what is now Mexico around 1500-400 BCE, were likely the first to discover the potential of cacao beans.'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 2,
                            QuestionText = "The Maya used cacao beans as currency.",
                            QuestionType = "TrueFalse",
                            CorrectAnswer = "True",
                            Explanation = "The passage mentions that the Maya 'used cacao beans not only as a beverage but also as currency.'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 3,
                            QuestionText = "What was the name of the bitter drink prepared by the Maya?",
                            QuestionType = "FillInTheBlank",
                            CorrectAnswer = "xocolatl",
                            Explanation = "The passage states that 'The Maya prepared a bitter drink called 'xocolatl' by grinding cacao beans with spices.'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 4,
                            QuestionText = "Which Spanish conquistador first encountered chocolate in Mexico?",
                            QuestionType = "ShortAnswer",
                            CorrectAnswer = "Hernán Cortés",
                            Explanation = "The passage mentions 'Spanish conquistador Hernán Cortés arrived in Mexico in 1519, he encountered this chocolate drink.'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 5,
                            QuestionText = "The first solid chocolate bar was created in 1847.",
                            QuestionType = "TrueFalse",
                            CorrectAnswer = "True",
                            Explanation = "The passage states 'The first solid chocolate bar was created in 1847 by British company Fry & Sons.'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        }
                    }
                },

                // Academic Reading - Section 2
                new ReadingPassage
                {
                    Title = "Urban Wildlife Conservation",
                    Content = @"As cities continue to expand globally, the intersection between urban development and wildlife conservation has become increasingly critical. Urban wildlife conservation represents a paradigm shift from traditional conservation approaches, which typically focused on protecting wilderness areas far from human settlements. Today, conservationists recognize that cities can serve as important habitats for various species and play a crucial role in maintaining biodiversity.

Urban environments present unique challenges and opportunities for wildlife. On one hand, urbanization fragments natural habitats, creates pollution, and introduces artificial lighting and noise that can disrupt animal behavior. Roads and buildings create barriers to animal movement, while domestic pets, particularly cats, pose significant threats to urban wildlife populations. The heat island effect in cities can alter local microclimates, affecting species that are sensitive to temperature changes.

However, cities also offer unexpected benefits for certain species. Urban areas often provide diverse microhabitats, from parks and gardens to green roofs and abandoned lots that can support various forms of wildlife. Many cities have more consistent water sources than surrounding rural areas, particularly in arid regions. Additionally, some urban environments are free from certain natural predators, allowing prey species to thrive in ways they might not in wild settings.

Several species have demonstrated remarkable adaptability to urban life. Peregrine falcons, once endangered due to DDT poisoning, have made a spectacular recovery partly due to their successful adaptation to city environments. These birds nest on tall buildings and hunt pigeons and other urban birds, with some urban populations showing higher breeding success rates than their rural counterparts. Similarly, coyotes have expanded their range into cities across North America, learning to navigate urban landscapes and exploit new food sources.

Urban wildlife conservation strategies must be multifaceted and collaborative. Green infrastructure development is fundamental, including the creation of wildlife corridors that connect fragmented habitats. These corridors allow animals to move safely between different areas of the city, facilitating breeding and genetic exchange. Parks, green belts, and even small pocket parks can serve as stepping stones for wildlife movement.

Community engagement is equally important in urban wildlife conservation. Citizen science programs enable residents to contribute to wildlife monitoring and research. For example, the eBird project has collected millions of bird observations from urban areas worldwide, providing valuable data for researchers and conservationists. Educational programs help residents understand how to coexist with urban wildlife, such as securing garbage cans to prevent conflicts with raccoons or creating bird-friendly gardens.

Technology plays an increasingly important role in urban wildlife conservation. GPS tracking devices help researchers understand how animals navigate urban environments, while acoustic monitoring systems can track bird and bat populations in cities. Remote cameras provide insights into nocturnal urban wildlife behavior without human interference.

Policy and planning integration is crucial for successful urban wildlife conservation. Cities need to incorporate wildlife considerations into urban planning processes, ensuring that new developments include provisions for wildlife habitat and movement. Building codes can require green roofs or bird-friendly glass to reduce collision mortality. Zoning laws can protect critical urban habitats from development.

The economic benefits of urban wildlife conservation are becoming increasingly recognized. Urban green spaces that support wildlife also provide ecosystem services such as air purification, temperature regulation, and stormwater management. These areas enhance property values and contribute to residents' physical and mental well-being. Wildlife tourism in urban areas can generate significant economic benefits, as seen in cities like Vancouver with its urban beaver populations or New York City's Central Park bird watching.

Despite these opportunities, urban wildlife conservation faces significant challenges. Limited space and high property values make habitat creation expensive. Conflicts between humans and wildlife can generate public opposition to conservation efforts. Climate change adds another layer of complexity, as species ranges shift and extreme weather events become more frequent.

The future of urban wildlife conservation lies in innovative approaches that recognize cities as ecosystems in their own right. Vertical forests, green walls, and rooftop gardens represent new frontiers in creating urban habitats. Smart city technologies could be leveraged to create real-time wildlife monitoring systems and adaptive management strategies.

Success in urban wildlife conservation requires a fundamental shift in how we view cities – not as places devoid of nature, but as complex ecosystems where humans and wildlife can coexist. This vision demands collaboration between urban planners, conservationists, policymakers, and residents to create cities that are truly sustainable and biodiverse.",
                    DifficultyLevel = "Academic",
                    Section = "Section 2",
                    TimeLimit = 20,
                    Description = "A comprehensive passage about wildlife conservation in urban environments, discussing challenges, opportunities, and strategies.",
                    CreatedOn = DateTime.UtcNow,
                    Questions = new List<ReadingQuestion>
                    {
                        new ReadingQuestion
                        {
                            QuestionNumber = 1,
                            QuestionText = "Traditional conservation approaches primarily focused on:",
                            QuestionType = "MultipleChoice",
                            Options = JsonSerializer.Serialize(new List<string> { "Urban areas", "Wilderness areas far from human settlements", "Suburban environments", "Agricultural lands" }),
                            CorrectAnswer = "Wilderness areas far from human settlements",
                            Explanation = "The passage states that traditional conservation approaches 'typically focused on protecting wilderness areas far from human settlements.'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 2,
                            QuestionText = "Urban environments always have negative effects on wildlife.",
                            QuestionType = "TrueFalse",
                            CorrectAnswer = "False",
                            Explanation = "The passage mentions both challenges and benefits of urban environments for wildlife, stating that 'cities also offer unexpected benefits for certain species.'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 3,
                            QuestionText = "Which species is mentioned as having made a spectacular recovery partly due to urban adaptation?",
                            QuestionType = "ShortAnswer",
                            CorrectAnswer = "Peregrine falcons",
                            Explanation = "The passage specifically mentions 'Peregrine falcons, once endangered due to DDT poisoning, have made a spectacular recovery partly due to their successful adaptation to city environments.'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 4,
                            QuestionText = "Wildlife corridors are important because they:",
                            QuestionType = "MultipleChoice",
                            Options = JsonSerializer.Serialize(new List<string> { "Provide food sources", "Allow safe movement between habitats", "Reduce noise pollution", "Control urban temperatures" }),
                            CorrectAnswer = "Allow safe movement between habitats",
                            Explanation = "The passage explains that wildlife corridors 'allow animals to move safely between different areas of the city, facilitating breeding and genetic exchange.'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 5,
                            QuestionText = "The eBird project is an example of a citizen science program.",
                            QuestionType = "TrueFalse",
                            CorrectAnswer = "True",
                            Explanation = "The passage mentions eBird as an example when discussing citizen science programs: 'the eBird project has collected millions of bird observations from urban areas worldwide.'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        }
                    }
                },

                // General Training - Section 1
                new ReadingPassage
                {
                    Title = "Community Center Programs",
                    Content = @"Riverside Community Center
Weekly Program Schedule

MONDAY
Morning Yoga (9:00 AM - 10:30 AM)
Instructor: Sarah Johnson
Fee: $15 per session or $50 for 4-week package
Suitable for all levels. Bring your own mat.

Senior Citizens' Coffee Morning (10:00 AM - 12:00 PM)
Free event for residents aged 65+
Tea, coffee, and light refreshments provided
Weekly guest speakers on health and wellness topics

Computer Classes for Beginners (2:00 PM - 4:00 PM)
Instructor: Mark Thompson
Fee: $25 per session
Maximum 8 participants
Basic computer skills, internet browsing, and email

TUESDAY
Toddler Playgroup (9:30 AM - 11:00 AM)
For children aged 18 months - 3 years with parent/caregiver
Fee: $8 per session
Toys, books, and activities provided

Art Workshop (1:00 PM - 3:00 PM)
Instructor: Lisa Chen
Fee: $20 per session (materials included)
Different medium each week: watercolors, pastels, clay

Teen Drama Club (4:00 PM - 6:00 PM)
Ages 13-18
Fee: $12 per session
Working towards end-of-term performance

WEDNESDAY
Aqua Aerobics (8:00 AM - 9:00 AM)
Pool facility
Instructor: David Martinez
Fee: $18 per session
Suitable for all fitness levels

Mother and Baby Swimming (10:00 AM - 11:00 AM)
Ages 6 months - 2 years
Instructor: Emma Wilson
Fee: $22 per session
Small class sizes (maximum 6 babies)

Evening Language Classes (7:00 PM - 9:00 PM)
Spanish, French, or Mandarin
Instructor varies by language
Fee: $30 per session
Beginner to intermediate levels

THURSDAY
Pilates (9:00 AM - 10:00 AM)
Instructor: Sarah Johnson
Fee: $16 per session
Intermediate level - previous experience recommended

Craft Circle (1:30 PM - 3:30 PM)
Fee: $15 per session (materials extra)
Knitting, sewing, and seasonal crafts
All skill levels welcome

Youth Basketball (5:00 PM - 6:30 PM)
Ages 10-16
Coach: Michael Roberts
Fee: $10 per session
Equipment provided

FRIDAY
Zumba Dance Fitness (9:30 AM - 10:30 AM)
Instructor: Carmen Rodriguez
Fee: $14 per session
High-energy Latin dance workout

Book Club (2:00 PM - 3:30 PM)
Free event
Monthly book discussions
Current book: 'The Seven Husbands of Evelyn Hugo'

Community Choir (7:00 PM - 8:30 PM)
Director: Patricia Adams
Fee: $8 per session
All voices welcome - no audition required

SATURDAY
Family Fun Day (10:00 AM - 4:00 PM)
First Saturday of each month
Fee: $5 per family
Games, activities, and BBQ lunch (additional $8 per person)

Cooking Classes (2:00 PM - 5:00 PM)
Chef: Antonio Rossi
Fee: $45 per session (includes ingredients)
Different cuisine each week
Maximum 12 participants

SUNDAY
Community Garden Club (9:00 AM - 12:00 PM)
Free event
Maintain community vegetable garden
Tools provided, but bring gloves

Meditation and Mindfulness (4:00 PM - 5:00 PM)
Instructor: Dr. Jennifer Park
Fee: $12 per session
Quiet space for reflection and stress relief

SPECIAL NOTES:
- All fees are due at the beginning of each session
- Discounts available for seniors (65+), students, and low-income families
- Monthly membership options available for regular attendees
- Private room rentals available for birthday parties and events
- Free parking available on weekdays after 6 PM and all day weekends
- Contact reception at (555) 123-4567 for more information or to register
- Online registration available at www.riversidecommunitycenter.org",
                    DifficultyLevel = "General Training",
                    Section = "Section 1",
                    TimeLimit = 20,
                    Description = "A community center program schedule with various activities, times, and fees.",
                    CreatedOn = DateTime.UtcNow,
                    Questions = new List<ReadingQuestion>
                    {
                        new ReadingQuestion
                        {
                            QuestionNumber = 1,
                            QuestionText = "What is the fee for a 4-week Morning Yoga package?",
                            QuestionType = "ShortAnswer",
                            CorrectAnswer = "$50",
                            Explanation = "The schedule states 'Fee: $15 per session or $50 for 4-week package' for Morning Yoga.",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 2,
                            QuestionText = "The Senior Citizens' Coffee Morning is a paid event.",
                            QuestionType = "TrueFalse",
                            CorrectAnswer = "False",
                            Explanation = "The schedule clearly states 'Free event for residents aged 65+' for the Senior Citizens' Coffee Morning.",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 3,
                            QuestionText = "What is the maximum number of participants for Computer Classes for Beginners?",
                            QuestionType = "FillInTheBlank",
                            CorrectAnswer = "8",
                            Explanation = "The schedule states 'Maximum 8 participants' for Computer Classes for Beginners.",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 4,
                            QuestionText = "Which day of the week is Family Fun Day held?",
                            QuestionType = "MultipleChoice",
                            Options = JsonSerializer.Serialize(new List<string> { "Friday", "Saturday", "Sunday", "Monday" }),
                            CorrectAnswer = "Saturday",
                            Explanation = "Family Fun Day is listed under Saturday in the schedule.",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 5,
                            QuestionText = "Free parking is available all day on weekends.",
                            QuestionType = "TrueFalse",
                            CorrectAnswer = "True",
                            Explanation = "The special notes section states 'Free parking available on weekdays after 6 PM and all day weekends.'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        }
                    }
                }
            };

            context.ReadingPassages.AddRange(passages);
            await context.SaveChangesAsync();
        }
    }
}