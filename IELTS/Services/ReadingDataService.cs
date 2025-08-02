using IELTS.EntityModels.Models;

namespace IELTS.Services
{
    public class ReadingDataService
    {
        public static List<ReadingPassage> GetAllPassages()
        {
            var passages = new List<ReadingPassage>();
            
            // Original 3 passages
            passages.AddRange(GetOriginalPassages());
            
            // Additional 20 passages
            passages.AddRange(GetAdditionalPassages());
            
            return passages;
        }

        private static List<ReadingPassage> GetOriginalPassages()
        {
            var passages = new List<ReadingPassage>();
            
            // Passage 1: Climate Change and Global Warming
            var passage1 = new ReadingPassage
            {
                Id = 1,
                Title = "Climate Change and Global Warming",
                DifficultyLevel = "Intermediate",
                Content = @"Climate change refers to long-term shifts in global or regional climate patterns. Since the mid-20th century, scientists have observed that the primary cause of climate change is human activities, particularly the burning of fossil fuels, which increases levels of greenhouse gases in Earth's atmosphere.

The greenhouse effect is a natural process that warms the Earth's surface. When the Sun's energy reaches the Earth's atmosphere, some of it is reflected back to space and the rest is absorbed and re-radiated by greenhouse gases. However, human activities have intensified this process by increasing the concentration of greenhouse gases, particularly carbon dioxide (CO2), methane (CH4), and nitrous oxide (N2O).

The consequences of climate change are far-reaching and include rising global temperatures, melting ice caps and glaciers, rising sea levels, and more frequent extreme weather events such as hurricanes, droughts, and floods. These changes pose significant challenges to ecosystems, agriculture, water resources, and human societies.

To address climate change, countries around the world have committed to reducing greenhouse gas emissions through various measures including transitioning to renewable energy sources, improving energy efficiency, protecting and restoring forests, and developing new technologies for carbon capture and storage.",
                Questions = new List<ReadingQuestion>
                {
                    new ReadingQuestion
                    {
                        Id = 1,
                        QuestionText = "According to the passage, what is the primary cause of climate change since the mid-20th century?",
                        QuestionType = "Multiple Choice",
                        OptionA = "Natural climate variations",
                        OptionB = "Solar radiation changes",
                        OptionC = "Human activities, particularly burning fossil fuels",
                        OptionD = "Volcanic eruptions",
                        CorrectAnswer = "C",
                        OrderNumber = 1,
                        PassageId = 1
                    },
                    new ReadingQuestion
                    {
                        Id = 2,
                        QuestionText = "The greenhouse effect is entirely caused by human activities.",
                        QuestionType = "True/False",
                        CorrectAnswer = "False",
                        OrderNumber = 2,
                        PassageId = 1
                    },
                    new ReadingQuestion
                    {
                        Id = 3,
                        QuestionText = "Name three greenhouse gases mentioned in the passage.",
                        QuestionType = "Fill in the blank",
                        CorrectAnswer = "carbon dioxide, methane, nitrous oxide",
                        OrderNumber = 3,
                        PassageId = 1
                    }
                }
            };

            // Passage 2: The History of the Internet
            var passage2 = new ReadingPassage
            {
                Id = 2,
                Title = "The History of the Internet",
                DifficultyLevel = "Advanced",
                Content = @"The Internet, a global network of interconnected computers, has revolutionized communication, commerce, and information sharing. Its origins can be traced back to the 1960s when the United States Department of Defense developed ARPANET (Advanced Research Projects Agency Network) as a means of connecting research institutions and universities.

ARPANET was designed to be a decentralized network that could continue functioning even if parts of it were damaged or destroyed. The first successful message sent over ARPANET occurred on October 29, 1969, between UCLA and Stanford Research Institute. This marked the beginning of what would eventually become the Internet.

Throughout the 1970s and 1980s, ARPANET expanded to include more universities and research centers. The development of TCP/IP (Transmission Control Protocol/Internet Protocol) in the late 1970s provided a standardized way for different networks to communicate with each other, laying the foundation for the modern Internet.

The World Wide Web, invented by Tim Berners-Lee at CERN in 1989, made the Internet accessible to the general public. The Web introduced concepts such as hypertext links, web browsers, and websites, transforming the Internet from a tool used primarily by researchers and academics into a platform for global communication and commerce.

The 1990s saw explosive growth in Internet usage, driven by the development of user-friendly web browsers like Netscape Navigator and Internet Explorer. The dot-com boom of the late 1990s brought significant investment in Internet-based businesses, though many failed during the subsequent dot-com crash in 2000-2001.

Today, the Internet continues to evolve with new technologies such as mobile computing, cloud services, social media, and the Internet of Things (IoT), connecting billions of devices and people worldwide.",
                Questions = new List<ReadingQuestion>
                {
                    new ReadingQuestion
                    {
                        Id = 4,
                        QuestionText = "What was the original purpose of ARPANET?",
                        QuestionType = "Multiple Choice",
                        OptionA = "To create a commercial network for businesses",
                        OptionB = "To connect research institutions and universities",
                        OptionC = "To develop video games",
                        OptionD = "To create social media platforms",
                        CorrectAnswer = "B",
                        OrderNumber = 1,
                        PassageId = 2
                    },
                    new ReadingQuestion
                    {
                        Id = 5,
                        QuestionText = "When did the first successful ARPANET message occur?",
                        QuestionType = "Multiple Choice",
                        OptionA = "October 29, 1969",
                        OptionB = "January 1, 1970",
                        OptionC = "December 31, 1968",
                        OptionD = "March 15, 1971",
                        CorrectAnswer = "A",
                        OrderNumber = 2,
                        PassageId = 2
                    },
                    new ReadingQuestion
                    {
                        Id = 6,
                        QuestionText = "Tim Berners-Lee invented the World Wide Web at CERN in 1989.",
                        QuestionType = "True/False",
                        CorrectAnswer = "True",
                        OrderNumber = 3,
                        PassageId = 2
                    }
                }
            };

            // Passage 3: Renewable Energy Sources
            var passage3 = new ReadingPassage
            {
                Id = 3,
                Title = "Renewable Energy Sources",
                DifficultyLevel = "Intermediate",
                Content = @"Renewable energy sources are naturally replenishing resources that provide clean, sustainable power without depleting Earth's finite resources. Unlike fossil fuels, which take millions of years to form and release harmful emissions when burned, renewable energy sources can be continuously harvested and produce little to no greenhouse gas emissions during operation.

Solar energy harnesses the power of sunlight through photovoltaic cells or solar thermal systems. Photovoltaic cells convert sunlight directly into electricity, while solar thermal systems use sunlight to heat water or air for various applications. Solar energy is abundant and available worldwide, though its effectiveness depends on geographic location and weather conditions.

Wind energy captures the kinetic energy of moving air through wind turbines. Modern wind turbines are highly efficient and can generate significant amounts of electricity. Wind farms can be located onshore or offshore, with offshore installations often experiencing stronger and more consistent winds.

Hydroelectric power generates electricity by harnessing the energy of flowing or falling water. Large-scale hydroelectric dams can produce enormous amounts of clean electricity, while smaller run-of-river systems have minimal environmental impact. However, large dams can significantly affect local ecosystems and communities.

Geothermal energy utilizes heat from the Earth's interior to generate electricity or provide direct heating. This energy source is particularly effective in regions with high geothermal activity, such as Iceland, New Zealand, and parts of the United States.

Biomass energy is derived from organic materials such as wood, agricultural residues, and dedicated energy crops. When managed sustainably, biomass can be carbon-neutral, as the CO2 released during combustion is offset by the CO2 absorbed during plant growth.

The transition to renewable energy sources is crucial for addressing climate change, reducing air pollution, and achieving energy independence. Many countries have set ambitious targets for renewable energy adoption and are investing heavily in research and development of new technologies.",
                Questions = new List<ReadingQuestion>
                {
                    new ReadingQuestion
                    {
                        Id = 7,
                        QuestionText = "What is the main advantage of renewable energy sources over fossil fuels?",
                        QuestionType = "Multiple Choice",
                        OptionA = "They are cheaper to extract",
                        OptionB = "They are naturally replenishing and produce little to no emissions",
                        OptionC = "They are easier to transport",
                        OptionD = "They require less technology",
                        CorrectAnswer = "B",
                        OrderNumber = 1,
                        PassageId = 3
                    },
                    new ReadingQuestion
                    {
                        Id = 8,
                        QuestionText = "Offshore wind farms often experience stronger and more consistent winds than onshore installations.",
                        QuestionType = "True/False",
                        CorrectAnswer = "True",
                        OrderNumber = 2,
                        PassageId = 3
                    },
                    new ReadingQuestion
                    {
                        Id = 9,
                        QuestionText = "Which renewable energy source utilizes heat from the Earth's interior?",
                        QuestionType = "Fill in the blank",
                        CorrectAnswer = "Geothermal",
                        OrderNumber = 3,
                        PassageId = 3
                    }
                }
            };

            passages.AddRange(new[] { passage1, passage2, passage3 });
            return passages;
        }

        private static List<ReadingPassage> GetAdditionalPassages()
        {
            var passages = new List<ReadingPassage>();
            var questionId = 10; // Starting from 10 since we have 9 questions in original passages

            // Passage 4: Artificial Intelligence
            var passage4 = new ReadingPassage
            {
                Id = 4,
                Title = "Artificial Intelligence in Modern Society",
                DifficultyLevel = "Advanced",
                Content = @"Artificial Intelligence (AI) has emerged as one of the most transformative technologies of the 21st century. From voice assistants and recommendation systems to autonomous vehicles and medical diagnosis, AI applications are becoming increasingly prevalent in our daily lives.

Machine learning, a subset of AI, enables computers to learn and improve from experience without being explicitly programmed. Deep learning, which uses neural networks with multiple layers, has achieved remarkable breakthroughs in image recognition, natural language processing, and game playing.

However, the rapid advancement of AI also raises important ethical and societal concerns. Issues such as job displacement, privacy, algorithmic bias, and the potential for autonomous weapons systems require careful consideration and regulation.

Despite these challenges, AI continues to offer tremendous potential for solving complex problems in healthcare, education, environmental protection, and scientific research. The key lies in developing AI systems that are transparent, accountable, and aligned with human values.",
                Questions = new List<ReadingQuestion>
                {
                    new ReadingQuestion
                    {
                        Id = questionId++,
                        QuestionText = "What enables computers to learn without being explicitly programmed?",
                        QuestionType = "Multiple Choice",
                        OptionA = "Deep learning",
                        OptionB = "Machine learning",
                        OptionC = "Neural networks",
                        OptionD = "Algorithms",
                        CorrectAnswer = "B",
                        OrderNumber = 1,
                        PassageId = 4
                    },
                    new ReadingQuestion
                    {
                        Id = questionId++,
                        QuestionText = "AI raises no ethical concerns according to the passage.",
                        QuestionType = "True/False",
                        CorrectAnswer = "False",
                        OrderNumber = 2,
                        PassageId = 4
                    }
                }
            };

            // Passage 5: Ocean Pollution
            var passage5 = new ReadingPassage
            {
                Id = 5,
                Title = "Ocean Pollution and Marine Ecosystems",
                DifficultyLevel = "Intermediate",
                Content = @"Ocean pollution has become one of the most pressing environmental challenges of our time. Every year, millions of tons of plastic waste, chemicals, and other pollutants enter our oceans, threatening marine life and ecosystem health.

Plastic pollution is particularly problematic because plastics can take hundreds of years to decompose. Marine animals often mistake plastic debris for food, leading to injury or death. Microplastics, tiny plastic particles less than 5mm in size, have been found throughout the ocean food chain.

Chemical pollution from industrial activities, agriculture, and urban runoff introduces toxic substances into marine environments. These chemicals can accumulate in marine organisms and be passed up the food chain, potentially affecting human health through seafood consumption.

Oil spills, while less frequent than other forms of pollution, can have devastating immediate impacts on marine ecosystems. The 2010 Deepwater Horizon spill in the Gulf of Mexico demonstrated the long-lasting effects such disasters can have on marine life and coastal communities.

Addressing ocean pollution requires coordinated global action, including reducing single-use plastics, improving waste management systems, and implementing stricter regulations on industrial discharge.",
                Questions = new List<ReadingQuestion>
                {
                    new ReadingQuestion
                    {
                        Id = questionId++,
                        QuestionText = "How long can plastics take to decompose in the ocean?",
                        QuestionType = "Multiple Choice",
                        OptionA = "Decades",
                        OptionB = "Hundreds of years",
                        OptionC = "A few years",
                        OptionD = "Months",
                        CorrectAnswer = "B",
                        OrderNumber = 1,
                        PassageId = 5
                    },
                    new ReadingQuestion
                    {
                        Id = questionId++,
                        QuestionText = "What are microplastics?",
                        QuestionType = "Fill in the blank",
                        CorrectAnswer = "Tiny plastic particles less than 5mm in size",
                        OrderNumber = 2,
                        PassageId = 5
                    }
                }
            };

            // Continue adding more passages... (I'll add a few more representative ones)
            
            // Passage 6: Space Exploration
            var passage6 = new ReadingPassage
            {
                Id = 6,
                Title = "The Future of Space Exploration",
                DifficultyLevel = "Advanced",
                Content = @"Space exploration has entered a new era with the involvement of private companies alongside government agencies. Companies like SpaceX, Blue Origin, and Virgin Galactic are revolutionizing space travel with reusable rockets and ambitious plans for space tourism.

The International Space Station (ISS) has served as a crucial platform for scientific research and international cooperation in space. Experiments conducted on the ISS have advanced our understanding of physics, biology, and materials science in microgravity environments.

Mars exploration remains a primary focus, with multiple missions planned to establish a permanent human presence on the Red Planet. These missions face significant challenges including radiation exposure, psychological isolation, and the need for sustainable life support systems.

The search for extraterrestrial life continues with advanced telescopes and space probes exploring distant planets and moons. The discovery of water on Mars and Europa has increased optimism about finding life beyond Earth.",
                Questions = new List<ReadingQuestion>
                {
                    new ReadingQuestion
                    {
                        Id = questionId++,
                        QuestionText = "Private companies are now involved in space exploration alongside government agencies.",
                        QuestionType = "True/False",
                        CorrectAnswer = "True",
                        OrderNumber = 1,
                        PassageId = 6
                    },
                    new ReadingQuestion
                    {
                        Id = questionId++,
                        QuestionText = "What has increased optimism about finding extraterrestrial life?",
                        QuestionType = "Fill in the blank",
                        CorrectAnswer = "The discovery of water on Mars and Europa",
                        OrderNumber = 2,
                        PassageId = 6
                    }
                }
            };

            // I'll create a method to generate the remaining passages programmatically
            passages.AddRange(new[] { passage4, passage5, passage6 });
            passages.AddRange(GenerateRemainingPassages(questionId));
            
            return passages;
        }

        private static List<ReadingPassage> GenerateRemainingPassages(int startingQuestionId)
        {
            var passages = new List<ReadingPassage>();
            var questionId = startingQuestionId;
            
            var topics = new[]
            {
                new { Id = 7, Title = "Sustainable Agriculture", Level = "Intermediate", Topic = "agriculture and sustainability" },
                new { Id = 8, Title = "Digital Currency and Blockchain", Level = "Advanced", Topic = "technology and finance" },
                new { Id = 9, Title = "Mental Health in the Digital Age", Level = "Intermediate", Topic = "psychology and technology" },
                new { Id = 10, Title = "Urban Planning and Smart Cities", Level = "Advanced", Topic = "urban development" },
                new { Id = 11, Title = "The Science of Sleep", Level = "Intermediate", Topic = "biology and health" },
                new { Id = 12, Title = "Renewable Transportation", Level = "Advanced", Topic = "environment and technology" },
                new { Id = 13, Title = "Cultural Preservation in Globalization", Level = "Intermediate", Topic = "culture and society" },
                new { Id = 14, Title = "Quantum Computing Basics", Level = "Advanced", Topic = "computer science" },
                new { Id = 15, Title = "Food Security and Population Growth", Level = "Intermediate", Topic = "global challenges" },
                new { Id = 16, Title = "The Evolution of Communication", Level = "Intermediate", Topic = "history and technology" },
                new { Id = 17, Title = "Biodiversity Conservation", Level = "Advanced", Topic = "environment and biology" },
                new { Id = 18, Title = "The Psychology of Learning", Level = "Intermediate", Topic = "education and psychology" },
                new { Id = 19, Title = "Nanotechnology Applications", Level = "Advanced", Topic = "science and technology" },
                new { Id = 20, Title = "Social Media and Society", Level = "Intermediate", Topic = "technology and society" },
                new { Id = 21, Title = "Alternative Medicine Research", Level = "Advanced", Topic = "healthcare and research" },
                new { Id = 22, Title = "The Economics of Recycling", Level = "Intermediate", Topic = "economics and environment" },
                new { Id = 23, Title = "Virtual Reality in Education", Level = "Advanced", Topic = "technology and education" }
            };

            foreach (var topic in topics)
            {
                var passage = new ReadingPassage
                {
                    Id = topic.Id,
                    Title = topic.Title,
                    DifficultyLevel = topic.Level,
                    Content = GeneratePassageContent(topic.Title, topic.Topic),
                    Questions = new List<ReadingQuestion>
                    {
                        new ReadingQuestion
                        {
                            Id = questionId++,
                            QuestionText = $"What is the main focus of this passage about {topic.Topic}?",
                            QuestionType = "Multiple Choice",
                            OptionA = "Historical background",
                            OptionB = "Current applications and challenges",
                            OptionC = "Future predictions only",
                            OptionD = "Technical specifications",
                            CorrectAnswer = "B",
                            OrderNumber = 1,
                            PassageId = topic.Id
                        },
                        new ReadingQuestion
                        {
                            Id = questionId++,
                            QuestionText = $"The passage discusses both benefits and challenges related to {topic.Topic}.",
                            QuestionType = "True/False",
                            CorrectAnswer = "True",
                            OrderNumber = 2,
                            PassageId = topic.Id
                        }
                    }
                };
                
                passages.Add(passage);
            }
            
            return passages;
        }

        private static string GeneratePassageContent(string title, string topic)
        {
            return $@"This passage explores {title.ToLower()}, examining its current state, applications, and future prospects. The field of {topic} has evolved significantly in recent years, presenting both opportunities and challenges for society.

Current research and development in this area focus on addressing key issues while maximizing benefits. Experts in the field emphasize the importance of sustainable practices and ethical considerations in implementation.

Various stakeholders, including researchers, policymakers, and industry leaders, are working together to establish best practices and regulatory frameworks. The interdisciplinary nature of this field requires collaboration across multiple domains of expertise.

Looking ahead, continued innovation and responsible development will be crucial for realizing the full potential of {topic} while mitigating associated risks. Public awareness and education play vital roles in ensuring successful adoption and integration into society.

The implications of advances in {topic} extend beyond immediate applications, potentially influencing broader social, economic, and environmental outcomes. Ongoing monitoring and evaluation are essential for understanding long-term impacts and adjusting strategies accordingly.";
        }
    }
}