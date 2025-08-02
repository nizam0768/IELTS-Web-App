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
                // Practice Test 1 - Climate Change and Arctic Ice
                new ReadingPassage
                {
                    Title = "Climate Change and Arctic Ice",
                    Content = @"The Arctic region is experiencing some of the most dramatic effects of climate change on Earth. Scientists have observed that Arctic temperatures are rising at twice the global average, a phenomenon known as Arctic amplification. This rapid warming has profound implications for the Arctic ice sheets, sea ice, and permafrost.

Arctic sea ice has been declining at an alarming rate of approximately 13% per decade since satellite observations began in 1979. The minimum extent of sea ice, which occurs in September each year, has shown the most dramatic decreases. In 2012, the Arctic sea ice reached its lowest recorded extent, covering only 3.41 million square kilometers compared to the long-term average of 6.14 million square kilometers.

The loss of Arctic sea ice creates a feedback loop that accelerates warming. Ice reflects approximately 90% of solar radiation back to space, while dark ocean water absorbs about 90% of solar energy. As ice melts, more dark water is exposed, leading to increased absorption of heat and further ice loss. This process, known as the albedo effect, is one of the primary drivers of Arctic amplification.

Permafrost, the permanently frozen ground that underlies much of the Arctic, is also thawing at unprecedented rates. Permafrost contains vast amounts of organic carbon - approximately twice as much carbon as currently exists in the atmosphere. When permafrost thaws, microorganisms decompose the organic matter, releasing carbon dioxide and methane into the atmosphere. These greenhouse gases contribute to further warming, creating another positive feedback loop.

The implications of Arctic ice loss extend far beyond the polar region. The melting of land-based ice sheets, particularly the Greenland ice sheet, contributes directly to global sea level rise. Current estimates suggest that complete melting of the Greenland ice sheet would raise global sea levels by approximately 7 meters, though this process would occur over centuries.

Arctic ice loss also affects global weather patterns through its impact on the jet stream. The jet stream is a band of fast-moving air that circles the northern hemisphere, separating cold Arctic air from warmer air to the south. As the temperature difference between the Arctic and lower latitudes decreases due to Arctic warming, the jet stream becomes more unstable and can develop large meanders. These meandering patterns can lead to extreme weather events, including prolonged heat waves, severe cold snaps, and persistent precipitation patterns in mid-latitude regions.

Indigenous communities in the Arctic face particular challenges from these changes. Traditional hunting and fishing practices, which have sustained Arctic peoples for thousands of years, are being disrupted by changing ice conditions and shifting wildlife populations. Coastal erosion, exacerbated by the loss of protective sea ice, threatens many Arctic communities with displacement.

Scientists are employing various methods to study Arctic ice changes, including satellite observations, ice core drilling, and computer modeling. Ice cores provide valuable historical data about past climate conditions, allowing researchers to place current changes in a long-term context. Paleoclimatic evidence suggests that current rates of Arctic warming and ice loss are unprecedented in human history.

International cooperation is essential for addressing Arctic climate change. The Arctic Council, consisting of eight Arctic nations, coordinates research and policy efforts. However, the Arctic is also becoming increasingly important for shipping routes and resource extraction as ice retreats, creating potential conflicts between conservation and economic interests.

Mitigation efforts to address Arctic ice loss must focus on reducing global greenhouse gas emissions. While some changes are already locked in due to the thermal inertia of the climate system, rapid and substantial emissions reductions could slow the rate of future ice loss and limit the most severe impacts on both Arctic ecosystems and global climate stability.",
                    DifficultyLevel = "Academic",
                    Section = "Section 1",
                    TimeLimit = 20,
                    Description = "A comprehensive passage about Arctic ice loss and its global implications, featuring multiple choice and True/False/Not Given questions.",
                    CreatedOn = DateTime.UtcNow,
                    Questions = new List<ReadingQuestion>
                    {
                        new ReadingQuestion
                        {
                            QuestionNumber = 1,
                            QuestionText = "Arctic temperatures are rising at what rate compared to the global average?",
                            QuestionType = "MultipleChoice",
                            Options = JsonSerializer.Serialize(new List<string> { "The same rate", "Twice the rate", "Three times the rate", "Half the rate" }),
                            CorrectAnswer = "Twice the rate",
                            Explanation = "The passage states 'Arctic temperatures are rising at twice the global average'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 2,
                            QuestionText = "Arctic sea ice has been declining at approximately 13% per decade since 1979.",
                            QuestionType = "TrueFalse",
                            CorrectAnswer = "True",
                            Explanation = "The passage explicitly states this statistic about Arctic sea ice decline.",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 3,
                            QuestionText = "In 2012, Arctic sea ice covered _______ million square kilometers at its minimum extent.",
                            QuestionType = "FillInTheBlank",
                            CorrectAnswer = "3.41",
                            Explanation = "The passage states that in 2012, Arctic sea ice reached its lowest recorded extent, covering only 3.41 million square kilometers.",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 4,
                            QuestionText = "Ice reflects what percentage of solar radiation back to space?",
                            QuestionType = "ShortAnswer",
                            CorrectAnswer = "90%",
                            Explanation = "The passage states 'Ice reflects approximately 90% of solar radiation back to space'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 5,
                            QuestionText = "Complete melting of the Greenland ice sheet would raise sea levels by 10 meters.",
                            QuestionType = "TrueFalse",
                            CorrectAnswer = "False",
                            Explanation = "The passage states it would raise sea levels by approximately 7 meters, not 10 meters.",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        }
                    }
                },

                // Practice Test 2 - The History of Printing
                new ReadingPassage
                {
                    Title = "The History of Printing Technology",
                    Content = @"The development of printing technology represents one of humanity's most significant innovations, fundamentally transforming the dissemination of knowledge and ideas. While many associate the invention of printing with Johannes Gutenberg in 15th-century Europe, the history of printing actually begins much earlier in East Asia.

The earliest forms of printing can be traced back to ancient China during the Tang Dynasty (618-907 CE). Chinese inventors developed woodblock printing, where text and images were carved into wooden blocks, inked, and then pressed onto paper or fabric. The Diamond Sutra, printed in 868 CE, is the world's oldest known printed book with a specific date. This method allowed for the mass production of texts, particularly Buddhist scriptures and government documents.

During the Song Dynasty (960-1279 CE), Chinese inventor Bi Sheng created the world's first movable type system around 1040 CE. His innovation used individual ceramic characters that could be arranged and rearranged to form different texts. This was a revolutionary advancement over woodblock printing, as it allowed for greater flexibility and efficiency in text production. However, the complexity of the Chinese writing system, with its thousands of characters, limited the widespread adoption of movable type in China.

The printing revolution in Europe began in the mid-15th century with Johannes Gutenberg's development of the printing press around 1440. Gutenberg's key innovations included the use of metal movable type, oil-based ink, and a mechanical printing press adapted from wine and olive presses. His system was particularly well-suited to European languages, which use alphabetic scripts with a limited number of characters.

Gutenberg's most famous work, the Gutenberg Bible, was completed around 1455 and demonstrated the potential of printing technology. Approximately 180 copies were produced, of which 49 survive today. The quality of these Bibles was so high that they rivaled hand-copied manuscripts, helping to establish printing as a legitimate alternative to traditional book production.

The impact of Gutenberg's printing press was immediate and far-reaching. Book production costs decreased dramatically, making books accessible to a broader population. Before printing, books were luxury items available only to the wealthy and religious institutions. The printing press democratized knowledge, contributing to increased literacy rates and the spread of ideas during the Renaissance and Reformation.

The printing industry expanded rapidly across Europe. By 1500, printing presses had been established in over 250 cities, and approximately 8 million books had been produced. Venice became a major printing center, with the Aldine Press, founded by Aldus Manutius, pioneering the production of small, portable books and introducing italic typeface.

Technological improvements continued throughout the following centuries. In the 18th century, the invention of stereotyping allowed for the creation of duplicate printing plates, enabling larger print runs. The 19th century brought steam-powered printing presses, which dramatically increased production speed. The rotary printing press, invented by Richard March Hoe in 1843, revolutionized newspaper production by allowing continuous printing on rolls of paper.

The 20th century introduced offset printing, which used photographic processes to transfer images to printing plates. This method provided higher quality reproduction of images and became the standard for commercial printing. The development of phototypesetting in the 1960s began the transition from mechanical to digital typesetting.

The digital revolution of the late 20th and early 21st centuries has transformed printing once again. Desktop publishing software made professional-quality design accessible to individuals and small businesses. Digital printing technologies eliminated the need for traditional printing plates, allowing for cost-effective short-run printing and personalized materials.

Today, three-dimensional printing represents the latest frontier in printing technology. 3D printers can create physical objects from digital designs using various materials, including plastics, metals, and even biological materials. This technology has applications in manufacturing, medicine, architecture, and many other fields.

The evolution of printing technology continues to shape how we create, distribute, and consume information. From ancient Chinese woodblocks to modern 3D printers, each advancement has expanded the possibilities for human communication and creativity. As digital technologies continue to evolve, the future of printing promises even more revolutionary changes in how we interact with printed materials.",
                    DifficultyLevel = "Academic",
                    Section = "Section 2",
                    TimeLimit = 20,
                    Description = "A detailed passage about the evolution of printing technology from ancient China to modern 3D printing, featuring matching and completion questions.",
                    CreatedOn = DateTime.UtcNow,
                    Questions = new List<ReadingQuestion>
                    {
                        new ReadingQuestion
                        {
                            QuestionNumber = 1,
                            QuestionText = "The Diamond Sutra was printed in which year?",
                            QuestionType = "MultipleChoice",
                            Options = JsonSerializer.Serialize(new List<string> { "618 CE", "868 CE", "907 CE", "1040 CE" }),
                            CorrectAnswer = "868 CE",
                            Explanation = "The passage states 'The Diamond Sutra, printed in 868 CE, is the world's oldest known printed book with a specific date.'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 2,
                            QuestionText = "Bi Sheng invented movable type using ceramic characters.",
                            QuestionType = "TrueFalse",
                            CorrectAnswer = "True",
                            Explanation = "The passage mentions that Bi Sheng 'created the world's first movable type system around 1040 CE' using 'individual ceramic characters'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 3,
                            QuestionText = "Gutenberg's printing press was adapted from _______ and _______ presses.",
                            QuestionType = "FillInTheBlank",
                            CorrectAnswer = "wine and olive",
                            Explanation = "The passage states that Gutenberg used 'a mechanical printing press adapted from wine and olive presses'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 4,
                            QuestionText = "How many copies of the Gutenberg Bible were originally produced?",
                            QuestionType = "ShortAnswer",
                            CorrectAnswer = "180",
                            Explanation = "The passage states 'Approximately 180 copies were produced, of which 49 survive today.'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 5,
                            QuestionText = "By 1500, printing presses had been established in over 250 cities.",
                            QuestionType = "TrueFalse",
                            CorrectAnswer = "True",
                            Explanation = "The passage explicitly states this fact about the spread of printing presses by 1500.",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        }
                    }
                }
            };

            // Add the remaining 8 practice tests here...
            passages.AddRange(CreateAdditionalPracticeTests());

            context.ReadingPassages.AddRange(passages);
            await context.SaveChangesAsync();
        }

        private static List<ReadingPassage> CreateAdditionalPracticeTests()
        {
            return new List<ReadingPassage>
            {
                // Practice Test 3 - Renewable Energy
                new ReadingPassage
                {
                    Title = "The Future of Renewable Energy",
                    Content = @"Renewable energy technologies have emerged as crucial solutions to address climate change and energy security challenges. Solar, wind, hydroelectric, geothermal, and biomass energy sources offer sustainable alternatives to fossil fuels, each with unique advantages and limitations.

Solar energy has experienced remarkable growth, with photovoltaic (PV) technology costs declining by over 80% since 2010. Modern solar panels achieve efficiency rates of 20-22% in commercial applications, with laboratory demonstrations reaching over 40% efficiency. Concentrated solar power (CSP) systems use mirrors to focus sunlight, generating heat that drives turbines to produce electricity. Unlike traditional PV systems, CSP can store thermal energy, enabling power generation even after sunset.

Wind energy represents the fastest-growing renewable technology globally. Modern wind turbines can generate up to 15 megawatts of power, with blade diameters exceeding 200 meters. Offshore wind farms benefit from stronger and more consistent winds, though installation and maintenance costs are significantly higher than onshore facilities. Floating wind turbines are being developed to access deeper waters with superior wind resources.

Hydroelectric power remains the world's largest source of renewable electricity, providing approximately 16% of global electricity generation. Large-scale hydroelectric projects can generate thousands of megawatts, but they often face environmental and social concerns related to ecosystem disruption and community displacement. Small-scale hydroelectric systems offer more environmentally friendly alternatives for local power generation.

Geothermal energy harnesses heat from the Earth's interior, providing both electricity generation and direct heating applications. Enhanced geothermal systems (EGS) use hydraulic fracturing to create artificial reservoirs in hot dry rock formations, potentially expanding geothermal resources to regions without natural hydrothermal activity. However, EGS technology raises concerns about induced seismicity.

Biomass energy converts organic materials into electricity, heat, or biofuels. Advanced biofuel technologies, including cellulosic ethanol and algae-based fuels, promise to reduce competition with food crops while providing carbon-neutral transportation fuels. Biogas production from waste materials offers dual benefits of waste management and energy generation.

Energy storage technologies are critical for integrating variable renewable sources into electrical grids. Lithium-ion batteries have become the dominant storage technology, with costs declining by 90% since 2010. Alternative storage solutions include pumped hydro storage, compressed air energy storage, and emerging technologies like hydrogen fuel cells and thermal storage systems.

Smart grid technologies enable better integration of renewable energy sources by providing real-time monitoring and control of electricity distribution. Advanced forecasting systems predict renewable energy output, allowing grid operators to balance supply and demand more effectively. Demand response programs incentivize consumers to adjust electricity usage based on renewable energy availability.

Government policies play crucial roles in renewable energy deployment. Feed-in tariffs guarantee long-term contracts for renewable energy producers, while renewable portfolio standards require utilities to source specified percentages of electricity from renewable sources. Carbon pricing mechanisms make fossil fuels more expensive relative to clean alternatives.

Economic factors increasingly favor renewable energy adoption. Levelized costs of electricity (LCOE) for solar and wind power have become competitive with or lower than fossil fuel alternatives in many markets. Job creation in renewable energy sectors often exceeds losses in traditional energy industries, though geographic and skill mismatches can create transition challenges.

International cooperation accelerates renewable energy development through technology sharing, financing mechanisms, and coordinated research efforts. The International Renewable Energy Agency (IRENA) facilitates global collaboration, while initiatives like the International Solar Alliance promote specific technology deployment.

Challenges remain for achieving 100% renewable energy systems. Grid stability requires maintaining consistent electricity supply despite variable renewable output. Seasonal storage needs, particularly in high-latitude regions with limited winter solar resources, require long-duration storage technologies that remain expensive. Industrial processes requiring high-temperature heat may require synthetic fuels produced from renewable electricity.

The transition to renewable energy systems represents both a technological and social transformation. Success requires coordinated efforts across technology development, policy implementation, and public acceptance. While challenges persist, the trajectory toward renewable energy dominance appears increasingly inevitable as costs continue declining and climate pressures intensify.",
                    DifficultyLevel = "Academic",
                    Section = "Section 3",
                    TimeLimit = 20,
                    Description = "An advanced passage about renewable energy technologies and their implementation challenges, featuring complex question types.",
                    CreatedOn = DateTime.UtcNow,
                    Questions = new List<ReadingQuestion>
                    {
                        new ReadingQuestion
                        {
                            QuestionNumber = 1,
                            QuestionText = "Solar panel costs have declined by what percentage since 2010?",
                            QuestionType = "MultipleChoice",
                            Options = JsonSerializer.Serialize(new List<string> { "Over 60%", "Over 70%", "Over 80%", "Over 90%" }),
                            CorrectAnswer = "Over 80%",
                            Explanation = "The passage states 'photovoltaic (PV) technology costs declining by over 80% since 2010'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 2,
                            QuestionText = "Modern wind turbines can generate up to 15 megawatts of power.",
                            QuestionType = "TrueFalse",
                            CorrectAnswer = "True",
                            Explanation = "The passage explicitly states this capacity for modern wind turbines.",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 3,
                            QuestionText = "Hydroelectric power provides approximately _______% of global electricity generation.",
                            QuestionType = "FillInTheBlank",
                            CorrectAnswer = "16",
                            Explanation = "The passage states hydroelectric power provides 'approximately 16% of global electricity generation'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 4,
                            QuestionText = "What does EGS stand for in geothermal energy?",
                            QuestionType = "ShortAnswer",
                            CorrectAnswer = "Enhanced geothermal systems",
                            Explanation = "The passage defines EGS as 'Enhanced geothermal systems'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 5,
                            QuestionText = "Lithium-ion battery costs have declined by 90% since 2010.",
                            QuestionType = "TrueFalse",
                            CorrectAnswer = "True",
                            Explanation = "The passage states lithium-ion batteries 'have become the dominant storage technology, with costs declining by 90% since 2010'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        }
                    }
                },

                // Practice Test 4 - Urban Planning and Smart Cities
                new ReadingPassage
                {
                    Title = "Smart Cities and Urban Innovation",
                    Content = @"The concept of smart cities represents a paradigm shift in urban planning and management, leveraging technology to improve quality of life, enhance sustainability, and optimize municipal services. As urbanization accelerates globally, with over 68% of the world's population expected to live in cities by 2050, the need for intelligent urban solutions becomes increasingly critical.

Smart cities integrate information and communication technologies (ICT) into urban infrastructure and services. Sensors, data analytics, artificial intelligence, and the Internet of Things (IoT) form the technological backbone of these systems. Traffic management represents one of the most visible applications, with intelligent transportation systems reducing congestion and emissions through real-time traffic optimization, dynamic routing, and coordinated traffic signals.

Barcelona exemplifies successful smart city implementation through its comprehensive approach to urban innovation. The city has deployed over 20,000 smart meters for water management, reducing consumption by 25% and saving €42.5 million annually. Smart lighting systems adjust brightness based on pedestrian and vehicle presence, cutting energy consumption by 30%. The city's sensor network monitors air quality, noise levels, and foot traffic, providing data for evidence-based policy decisions.

Singapore's smart nation initiative demonstrates how technology can address urban challenges in a resource-constrained environment. The city-state has implemented a comprehensive sensor network that monitors everything from traffic patterns to air quality. Predictive analytics help anticipate and prevent urban problems before they occur. The national digital identity system streamlines government services, while smart mobility solutions include autonomous vehicle trials and comprehensive public transportation integration.

Energy management in smart cities involves sophisticated grid systems that balance supply and demand in real-time. Microgrids enable neighborhoods to generate, store, and share renewable energy locally. Smart buildings automatically adjust heating, cooling, and lighting based on occupancy and weather conditions. District energy systems optimize heating and cooling across multiple buildings, achieving efficiency gains impossible at the individual building level.

Waste management benefits significantly from smart city technologies. Sensors in waste bins alert collection services when containers are full, optimizing collection routes and reducing unnecessary trips. Pneumatic waste systems transport refuse through underground tubes, eliminating truck traffic in dense urban areas. Advanced recycling facilities use artificial intelligence to sort materials more accurately than manual processes.

Water management systems in smart cities monitor quality and pressure throughout distribution networks, detecting leaks and contamination in real-time. Smart irrigation systems in parks and green spaces adjust watering schedules based on weather forecasts and soil moisture levels. Stormwater management systems use predictive modeling to anticipate flooding and activate mitigation measures automatically.

Citizen engagement platforms enable residents to report issues, access services, and participate in decision-making processes through mobile applications and online portals. Digital democracy initiatives allow for more direct citizen participation in urban governance. Open data policies make government information accessible to residents and researchers, fostering transparency and innovation.

Economic development in smart cities benefits from innovation ecosystems that connect startups, established companies, research institutions, and government agencies. Digital infrastructure attracts technology companies and enables new business models. The sharing economy thrives in smart cities, with platforms for bike-sharing, car-sharing, and co-working spaces reducing resource consumption while improving access to services.

Privacy and security concerns present significant challenges for smart city development. The extensive data collection required for smart city operations raises questions about surveillance and citizen privacy. Cybersecurity threats targeting critical urban infrastructure could have severe consequences for public safety and economic activity. Balancing the benefits of data-driven services with privacy protection requires careful policy design and robust security measures.

Digital divide issues can exacerbate urban inequalities if smart city benefits are not equally accessible. Low-income residents may lack access to smartphones or high-speed internet required for many smart city services. Elderly populations may struggle with digital interfaces, potentially excluding them from improved services. Inclusive design principles are essential to ensure smart city benefits reach all residents.

Interoperability challenges arise when different smart city systems cannot communicate effectively. Proprietary technologies and competing standards can create information silos that limit the potential for integrated solutions. Open standards and collaborative approaches are necessary to maximize the benefits of smart city investments.

The COVID-19 pandemic has accelerated smart city adoption in many areas, particularly in health monitoring and contact tracing. Digital health passports, remote work technologies, and contactless service delivery have become essential urban functions. These experiences have demonstrated both the potential benefits and risks of pervasive urban technology systems.

Future smart city development will likely focus on artificial intelligence integration, with machine learning algorithms optimizing urban systems autonomously. Digital twins - virtual replicas of physical urban systems - will enable sophisticated simulation and planning capabilities. Quantum computing may eventually provide the processing power needed for real-time optimization of entire urban systems.

The success of smart cities ultimately depends on their ability to improve residents' lives while addressing urban challenges sustainably. Technology alone is insufficient; effective governance, citizen engagement, and inclusive design principles are equally important. As cities continue to grow and evolve, smart city approaches will play an increasingly important role in creating livable, sustainable urban environments.",
                    DifficultyLevel = "Academic",
                    Section = "Section 1",
                    TimeLimit = 20,
                    Description = "A comprehensive examination of smart city technologies and their implementation, featuring various IELTS question types including matching information.",
                    CreatedOn = DateTime.UtcNow,
                    Questions = new List<ReadingQuestion>
                    {
                        new ReadingQuestion
                        {
                            QuestionNumber = 1,
                            QuestionText = "What percentage of the world's population is expected to live in cities by 2050?",
                            QuestionType = "MultipleChoice",
                            Options = JsonSerializer.Serialize(new List<string> { "Over 58%", "Over 68%", "Over 78%", "Over 88%" }),
                            CorrectAnswer = "Over 68%",
                            Explanation = "The passage states 'over 68% of the world's population expected to live in cities by 2050'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 2,
                            QuestionText = "Barcelona's smart water meters have reduced consumption by 25%.",
                            QuestionType = "TrueFalse",
                            CorrectAnswer = "True",
                            Explanation = "The passage states Barcelona 'has deployed over 20,000 smart meters for water management, reducing consumption by 25%'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 3,
                            QuestionText = "Barcelona's smart lighting systems cut energy consumption by _______% .",
                            QuestionType = "FillInTheBlank",
                            CorrectAnswer = "30",
                            Explanation = "The passage mentions smart lighting systems 'cutting energy consumption by 30%'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 4,
                            QuestionText = "Which city is mentioned as having a comprehensive smart nation initiative?",
                            QuestionType = "ShortAnswer",
                            CorrectAnswer = "Singapore",
                            Explanation = "The passage discusses 'Singapore's smart nation initiative'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        },
                        new ReadingQuestion
                        {
                            QuestionNumber = 5,
                            QuestionText = "Digital twins are virtual replicas of physical urban systems.",
                            QuestionType = "TrueFalse",
                            CorrectAnswer = "True",
                            Explanation = "The passage defines digital twins as 'virtual replicas of physical urban systems'",
                            Points = 1,
                            CreatedOn = DateTime.UtcNow
                        }
                    }
                }
            };
        }
    }
}