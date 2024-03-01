namespace TriviaQuiz
{
    public static class VirtualDatabase
    {
        public static List<Question> quiz_questions = new List<Question>();
        // store questions in vertial database
        static VirtualDatabase()
        {
            Question new_question = new Question();

            new_question.question = "What is the half-life of Uranium-235?";
            new_question.options.Add("703,800,000 years");
            new_question.options.Add("4,300,400,000 years");
            new_question.options.Add("1,260,900,000 years");
            new_question.options.Add("Uranium-235 is a stable isotope");
            new_question.correct_option = "703,800,000 years";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "Which of the following is NOT a real element?";
            new_question.options.Add("Vitrainium");
            new_question.options.Add("Praseodymium");
            new_question.options.Add("Hassium");
            new_question.options.Add("Lutetium");
            new_question.correct_option = "Vitrainium";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "Which color cannot be produced in Roses, even through genetic alteration?";
            new_question.options.Add("Blue");
            new_question.options.Add("Black");
            new_question.options.Add("Orange");
            new_question.options.Add("Brown");
            new_question.correct_option = "Blue";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "All of the following human genetic haplogroup names are shared between Y-chromosome and mitochondrial DNA haplogroups EXCEPT:";
            new_question.options.Add("Haplogroup U");
            new_question.options.Add("Haplogroup L");
            new_question.options.Add("Haplogroup T");
            new_question.options.Add("Haplogroup J");
            new_question.correct_option = "Haplogroup U";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "What is the Linnean name of the domestic apple tree?";
            new_question.options.Add("Malus pumila");
            new_question.options.Add("Malus americana");
            new_question.options.Add("Pomus domestica");
            new_question.options.Add("Appelus delectica");
            new_question.correct_option = "Malus pumila";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "How long is a light-year?";
            new_question.options.Add("9.461 Trillion Kilometres");
            new_question.options.Add("1 AU");
            new_question.options.Add("105.40 Earth-years");
            new_question.options.Add("501.2 Million Miles");
            new_question.correct_option = "9.461 Trillion Kilometres";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "What is the standard atomic weight of a Plutonium nucleus?";
            new_question.options.Add("244");
            new_question.options.Add("94");
            new_question.options.Add("481");
            new_question.options.Add("128");
            new_question.correct_option = "244";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "What is the chemical formula for ammonia?";
            new_question.options.Add("NH3");
            new_question.options.Add("CO2");
            new_question.options.Add("NO3");
            new_question.options.Add("CH4");
            new_question.correct_option = "NH3";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "What term is best associated with Sigmund Freud?";
            new_question.options.Add("Psychoanalysis");
            new_question.options.Add("Cognitive-Behavioral Therapy");
            new_question.options.Add("Theory of Gravity");
            new_question.options.Add("Dialectical Behavior Therapy");
            new_question.correct_option = "Psychoanalysis";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "What is the unit of electrical capacitance?";
            new_question.options.Add("Farad");
            new_question.options.Add("Gauss");
            new_question.options.Add("Henry");
            new_question.options.Add("Watt");
            new_question.correct_option = "Farad";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "Which of the following plastic is commonly used for window frames, gutters and drain pipes?";
            new_question.options.Add("Polyvinylchloride (PVC) ");
            new_question.options.Add("Polyethylene (PE)");
            new_question.options.Add("Polypropylene (PP)");
            new_question.options.Add("Polystyrene (PS)");
            new_question.correct_option = "Polyvinylchloride (PVC) ";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "The medial meniscus forms which part of what joint in the human body?";
            new_question.options.Add("Knee");
            new_question.options.Add("Elbow");
            new_question.options.Add("Ankle");
            new_question.options.Add("Shoulder");
            new_question.correct_option = "Knee";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "What is the unit of electrical resistance?";
            new_question.options.Add("Ohm");
            new_question.options.Add("Mho");
            new_question.options.Add("Tesla");
            new_question.options.Add("Joule");
            new_question.correct_option = "Ohm";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "What is the official name of the star located closest to the North Celestial Pole?";
            new_question.options.Add("Polaris");
            new_question.options.Add("Eridanus");
            new_question.options.Add("Gamma Cephei");
            new_question.options.Add("Iota Cephei");
            new_question.correct_option = "Polaris";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "On which mission did the Space Shuttle Columbia break up upon re-entry?";
            new_question.options.Add("STS-107");
            new_question.options.Add("STS-51-L");
            new_question.options.Add("STS-61-C");
            new_question.options.Add("STS-109");
            new_question.correct_option = "STS-107";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "In quantum physics, which of these theorised sub-atomic particles has yet to be observed?";
            new_question.options.Add("Graviton");
            new_question.options.Add("Z boson");
            new_question.options.Add("Tau neutrino");
            new_question.options.Add("Gluon");
            new_question.correct_option = "Graviton";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "The medical condition osteoporosis affects which part of the body?";
            new_question.options.Add("Bones");
            new_question.options.Add("Skin");
            new_question.options.Add("Brain");
            new_question.options.Add("Heart");
            new_question.correct_option = "Bones";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "What polymer is used to make CDs, safety goggles and riot shields?";
            new_question.options.Add("Polycarbonate");
            new_question.options.Add("Rubber");
            new_question.options.Add("Nylon");
            new_question.options.Add("Bakelite");
            new_question.correct_option = "Polycarbonate";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "Which of the following bones is not in the leg?";
            new_question.options.Add("Radius");
            new_question.options.Add("Patella");
            new_question.options.Add("Tibia");
            new_question.options.Add("Fibula ");
            new_question.correct_option = "Radius";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "How many chromosomes are in your body cells?";
            new_question.options.Add("23");
            new_question.options.Add("21");
            new_question.options.Add("22");
            new_question.options.Add("24");
            new_question.correct_option = "23";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "What is the standard SI unit for temperature?";
            new_question.options.Add("Kelvin");
            new_question.options.Add("Fahrenheit");
            new_question.options.Add("Celsius");
            new_question.options.Add("Rankine");
            new_question.correct_option = "Kelvin";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "Down Syndrome is usually caused by an extra copy of which chromosome?";
            new_question.options.Add("21");
            new_question.options.Add("23");
            new_question.options.Add("15");
            new_question.options.Add("24");
            new_question.correct_option = "21";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "How many bones are in the human body?";
            new_question.options.Add("206");
            new_question.options.Add("203");
            new_question.options.Add("209");
            new_question.options.Add("200");
            new_question.correct_option = "206";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "Which of these is NOT a part of the structure of a typical neuron?";
            new_question.options.Add("Islets of Langerhans");
            new_question.options.Add("Node of Ranvier");
            new_question.options.Add("Schwann cell");
            new_question.options.Add("Myelin sheath");
            new_question.correct_option = "Islets of Langerhans";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "Autosomal-dominant Compelling Helio-Ophthalmic Outburst syndrome is the need to do what when seeing the Sun?";
            new_question.options.Add("Sneeze");
            new_question.options.Add("Cough");
            new_question.options.Add("Yawn");
            new_question.options.Add("Hiccup");
            new_question.correct_option = "Sneeze";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "Folic acid is the synthetic form of which vitamin?";
            new_question.options.Add("Vitamin B");
            new_question.options.Add("Vitamin A");
            new_question.options.Add("Vitamin C");
            new_question.options.Add("Vitamin D");
            new_question.correct_option = "Vitamin B";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "What is the chemical makeup of water?";
            new_question.options.Add("H20");
            new_question.options.Add("C12H6O2");
            new_question.options.Add("CO2");
            new_question.options.Add("H");
            new_question.correct_option = "H20";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "What does LASER stand for?";
            new_question.options.Add("Light amplification by stimulated emission of radiation");
            new_question.options.Add("Lite analysing by stereo ecorazer");
            new_question.options.Add("Light amplifier by standby energy of radio");
            new_question.options.Add("Life antimatter by standing entry of range");
            new_question.correct_option = "Light amplification by stimulated emission of radiation";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "What name is given to all baby marsupials?";
            new_question.options.Add("Joey");
            new_question.options.Add("Calf");
            new_question.options.Add("Pup");
            new_question.options.Add("Cub");
            new_question.correct_option = "Joey";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "Which constellation contains the center of the Milky Way?";
            new_question.options.Add("Sagittarius");
            new_question.options.Add("Scorpius");
            new_question.options.Add("Ophiuchus");
            new_question.options.Add("Capricornus");
            new_question.correct_option = "Sagittarius";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "To the nearest minute, how long does it take for light to travel from the Sun to the Earth?";
            new_question.options.Add("8 Minutes");
            new_question.options.Add("6 Minutes");
            new_question.options.Add("2 Minutes");
            new_question.options.Add("12 Minutes");
            new_question.correct_option = "8 Minutes";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "A positron is an antiparticle of a what?";
            new_question.options.Add("Electron");
            new_question.options.Add("Neutron");
            new_question.options.Add("Proton");
            new_question.options.Add("Photon");
            new_question.correct_option = "Electron";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "Who developed the first successful polio vaccine in the 1950s?";
            new_question.options.Add("Jonas Salk");
            new_question.options.Add("John F. Enders");
            new_question.options.Add("Thomas Weller");
            new_question.options.Add("Frederick Robbins");
            new_question.correct_option = "Jonas Salk";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "Which chemical element was originally known as Alabamine?";
            new_question.options.Add("Astatine");
            new_question.options.Add("Selenium");
            new_question.options.Add("Antimony");
            new_question.options.Add("Molybdenum");
            new_question.correct_option = "Astatine";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "What is the largest animal currently on Earth?";
            new_question.options.Add("Blue Whale");
            new_question.options.Add("Orca");
            new_question.options.Add("Colossal Squid");
            new_question.options.Add("Giraffe");
            new_question.correct_option = "Blue Whale";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "How many planets are in our Solar System?";
            new_question.options.Add("Eight");
            new_question.options.Add("Nine");
            new_question.options.Add("Seven");
            new_question.options.Add("Ten");
            new_question.correct_option = "Eight";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "In human biology, a circadium rhythm relates to a period of roughly how many hours?";
            new_question.options.Add("24");
            new_question.options.Add("8");
            new_question.options.Add("16");
            new_question.options.Add("32");
            new_question.correct_option = "24";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "What is radiation measured in?";
            new_question.options.Add("Gray ");
            new_question.options.Add("Watt");
            new_question.options.Add("Decibel");
            new_question.options.Add("Kelvin");
            new_question.correct_option = "Gray ";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "What stage of development do the majority of eukaryotic cells remain in for most of their life?";
            new_question.options.Add("Interphase");
            new_question.options.Add("Prophase");
            new_question.options.Add("Stasis");
            new_question.options.Add("Telophase");
            new_question.correct_option = "Interphase";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "Where did the Great Storm of 1987 make landfall at, first?";
            new_question.options.Add("Cornwall");
            new_question.options.Add("Surrey");
            new_question.options.Add("Wales");
            new_question.options.Add("The Midlands");
            new_question.correct_option = "Cornwall";

            quiz_questions.Add(new_question);

            new_question = new Question();

            new_question.question = "Which of the following men does not have a chemical element named after him?";
            new_question.options.Add("Sir Isaac Newton");
            new_question.options.Add("Albert Einstein");
            new_question.options.Add("Niels Bohr");
            new_question.options.Add("Enrico Fermi");
            new_question.correct_option = "Sir Isaac Newton";

            quiz_questions.Add(new_question);
        }

    }
}
