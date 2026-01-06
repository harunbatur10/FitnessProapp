using System.Collections.Generic;

namespace Fitnessapp
{
    
    public class Exercise
    {
        public string? Name { get; set; }
        public string? FileName { get; set; }
        public string? Category { get; set; }

       
        public string Gender
        {
            get
            {
                if (string.IsNullOrEmpty(FileName)) return "belirsiz";

                if (FileName.ToLower().StartsWith("erkek") || FileName.ToLower().StartsWith("male"))
                    return "erkek";

                
                return "kadin";
            }
        }
    }

    
    public static class ExerciseData
    {
        public static List<Exercise> GetExercises()
        {
            return new List<Exercise>
            {
                
                // ERKEK HAREKETLERİ
               
                new Exercise { Name = "Barbell Calf Jump", FileName = "erkekaltbacakbarbellcalfjumpside", Category = "Alt Bacak" },
                new Exercise { Name = "Bilateral Eccentric", FileName = "erkekaltbacakbilateraleccentricfloorfront", Category = "Alt Bacak" },
                new Exercise { Name = "Forward Lunges", FileName = "erkekaltbacakforwardlungesside", Category = "Alt Bacak" },
                new Exercise { Name = "Kettlebell Calf Raise", FileName = "erkekaltbacakkettlebellcalfraiseside", Category = "Alt Bacak" },
                new Exercise { Name = "Plate Loaded Calf Raise", FileName = "erkekaltbacakmachineplateloadedcalfraisefront", Category = "Alt Bacak" },
                new Exercise { Name = "Machine Standing Calf", FileName = "erkekaltbacakmachinestanding", Category = "Alt Bacak" },
                new Exercise { Name = "Smith Machine Calf", FileName = "erkekaltbacakSmithmachinecalfraiseside", Category = "Alt Bacak" },
                new Exercise { Name = "Barbell Calf Raise", FileName = "erkekkaltbacakbarbellcalfraises", Category = "Alt Bacak" },

                
                new Exercise { Name = "Alt Kol Genel", FileName = "erkekaltkol", Category = "Bilek" },
                new Exercise { Name = "Barbell Bent Over Row", FileName = "erkekaltkolbarbellbentoverrowfront", Category = "Bilek" },
                new Exercise { Name = "Barbell Wrist Curl", FileName = "erkekaltkolbarbellwristcurlside", Category = "Bilek" },
                new Exercise { Name = "Cable Wrist Curl", FileName = "erkekaltkolcablewristcurlfront", Category = "Bilek" },
                new Exercise { Name = "Dumbbell Wrist Curl", FileName = "erkekaltkoldumbbellwristcurlfront", Category = "Bilek" },
                new Exercise { Name = "Kettlebell Wrist Curl", FileName = "erkekaltkolkettlebellwristcurlside", Category = "Bilek" },

                new Exercise { Name = "Band Pushdown", FileName = "erkekarkakolbandpushdownside", Category = "Arka Kol" },
                new Exercise { Name = "Bench Dips", FileName = "erkekarkakolbenchdips", Category = "Arka Kol" },
                new Exercise { Name = "Diamond Push Up", FileName = "erkekarkakolBodyweightdiamondpush-upsfront", Category = "Arka Kol" },
                new Exercise { Name = "Parallel Bar Dips", FileName = "erkekarkakolBodyweightparralelbardipsfront", Category = "Arka Kol" },
                new Exercise { Name = "Cable Overhead Ext.", FileName = "erkekarkakolcableoverheadtricepextension", Category = "Arka Kol" },
                new Exercise { Name = "Cable Pushdown", FileName = "erkekarkakolcablepushdownside", Category = "Arka Kol" },
                new Exercise { Name = "Dumbbell Skullcrusher", FileName = "erkekarkakoldumbbellskullcrusherfront", Category = "Arka Kol" },

                new Exercise { Name = "Barbell Incline Press", FileName = "erkekgogusbarbellincline", Category = "Göğüs" },
                new Exercise { Name = "Cable Chest Press", FileName = "erkekgoguscablechestpressfront", Category = "Göğüs" },
                new Exercise { Name = "Deficit Push Up", FileName = "erkekgogusdeficitpushupfront", Category = "Göğüs" },
                new Exercise { Name = "Dumbbell Incline Press", FileName = "erkekgogusdumbbellincline", Category = "Göğüs" },
                new Exercise { Name = "Incline Chest Flys", FileName = "erkekgogusdumbbellinclinechest-flysside", Category = "Göğüs" },
                new Exercise { Name = "Incline Push Up", FileName = "erkekgogusinclinepushupfront", Category = "Göğüs" },
                new Exercise { Name = "Machine Chest Press", FileName = "erkekgogusmachinechestpress", Category = "Göğüs" },
                new Exercise { Name = "Machine Pec Fly", FileName = "erkekgogusmachinepecfly", Category = "Göğüs" },
                new Exercise { Name = "Parallel Bar Dips", FileName = "erkekgogusparralelbardipsside", Category = "Göğüs" },

                new Exercise { Name = "Barbell Rollout", FileName = "erkekkarinbarbellrolloutside", Category = "Karın" },
                new Exercise { Name = "Barbell Sit Up", FileName = "erkekkarinbarbellsitupfront", Category = "Karın" },
                new Exercise { Name = "Cable Kneeling Crunch", FileName = "erkekkarincablekneeling", Category = "Karın" },
                new Exercise { Name = "Hanging Knee Raises", FileName = "erkekkarinhangingkneeraisesfront", Category = "Karın" },
                new Exercise { Name = "Kettlebell Russian Twist", FileName = "erkekkarinkettlebellrussiantwistfront", Category = "Karın" },
                new Exercise { Name = "Laying Leg Raises", FileName = "erkekkarinlayinglegraises", Category = "Karın" },
                new Exercise { Name = "Mountain Climber", FileName = "erkekkarinmountainclimberside", Category = "Karın" },
                new Exercise { Name = "Russian Twist", FileName = "erkekkarinrussiantwistfront", Category = "Karın" },

                new Exercise { Name = "Barbell Reverse Curl", FileName = "erkekkolbarbellreversecurlside", Category = "Kol" },
                new Exercise { Name = "Cable Bayesian Curl", FileName = "erkekkolcablebayesiancurlfront", Category = "Kol" },
                new Exercise { Name = "Chin Up", FileName = "erkekkolchinupside", Category = "Kol" },
                new Exercise { Name = "Dumbbell Curl", FileName = "erkekkoldumbbellcurlside", Category = "Kol" },
                new Exercise { Name = "Dumbbell Hammer Curl", FileName = "erkekkoldumbbellhammercurlfront", Category = "Kol" },
                new Exercise { Name = "Dumbbell Incline Curl", FileName = "erkekkoldumbbellinclinecurlside", Category = "Kol" },
                new Exercise { Name = "Kettlebell Preacher", FileName = "erkekkolkettlebellpreachercurlfront", Category = "Kol" },
                new Exercise { Name = "Assisted Chin Up", FileName = "erkekkolmachineassistedneutralchin-upfront", Category = "Kol" },
                new Exercise { Name = "Twisting Curl", FileName = "erkekkoltwistingcurlside", Category = "Kol" },

                
                new Exercise { Name = "Barbell Upright Row", FileName = "erkekomuzbarbelluprightrow", Category = "Omuz" },
                new Exercise { Name = "Barbell Z Press", FileName = "erkekomuzbarbellzpressside", Category = "Omuz" },
                new Exercise { Name = "Cable Rope Upright", FileName = "erkekomuzcableropeuprightrowfront", Category = "Omuz" },
                new Exercise { Name = "Dumbbell Press", FileName = "erkekomuzDumbbells", Category = "Omuz" },
                new Exercise { Name = "DB Silverback Shrug", FileName = "erkekomuzdumbbellsilverbackshrugfront", Category = "Omuz" },
                new Exercise { Name = "KB Incline Shrug", FileName = "erkekomuzkettlebellinclineshrugfront", Category = "Omuz" },
                new Exercise { Name = "Silverback Shrug", FileName = "erkekomuzsilverbackshrugfront", Category = "Omuz" },

               
                new Exercise { Name = "Barbell Bent Over Row", FileName = "erkeksirtbarbellbentoverrowside", Category = "Sırt" },
                new Exercise { Name = "Cable Lat Prayer", FileName = "erkeksirtcablelatprayerside", Category = "Sırt" },
                new Exercise { Name = "Incline Row", FileName = "erkeksirtdumbbelllayingincline", Category = "Sırt" },
                new Exercise { Name = "Dumbbell Row", FileName = "erkeksirtdumbbellrowunilateralside", Category = "Sırt" },
                new Exercise { Name = "Kettlebell Shoulder Ext.", FileName = "erkeksirtkettlebellshoulderextension", Category = "Sırt" },
                new Exercise { Name = "Machine Pulldown", FileName = "erkeksirtmachinepulldownfront", Category = "Sırt" },
                new Exercise { Name = "Machine Underhand Row", FileName = "erkeksirtmachineunderhand", Category = "Sırt" },
                new Exercise { Name = "Sırt Genel", FileName = "erkeksirtt", Category = "Sırt" },

              
                new Exercise { Name = "Barbell Deadlift", FileName = "erkeksquatbarbelldeadlift", Category = "Squat" },
                new Exercise { Name = "Barbell Hip Thrust", FileName = "erkeksquatbarbellhipthrust", Category = "Squat" },
                new Exercise { Name = "Stiff Leg Deadlift", FileName = "erkeksquatbarbellstifflegdeadliftside", Category = "Squat" },
                new Exercise { Name = "Dumbbell Hip Thrust", FileName = "erkeksquatDumbbellsdumbbellhipthrustside", Category = "Squat" },
                new Exercise { Name = "Goblet Squat", FileName = "erkeksquatdumbbellgobletsquat", Category = "Squat" },
                new Exercise { Name = "Leg Press (Squat)", FileName = "erkeksquatMachinemachinelegpressside", Category = "Squat" },

               
                new Exercise { Name = "High Bar Squat", FileName = "erkekustbacakbarbellhighbarsquatside", Category = "Üst Bacak" },
                new Exercise { Name = "Barbell Squat (Front)", FileName = "erkekustbacakbarbellsquatfront", Category = "Üst Bacak" },
                new Exercise { Name = "Bulgarian Split Squat", FileName = "erkekustbacakdumbbellbulgariansplitsquatfront", Category = "Üst Bacak" },
                new Exercise { Name = "Single Arm Lunge", FileName = "erkekustbacakkettlebellsingle-armforwardlungefront", Category = "Üst Bacak" },
                new Exercise { Name = "Goblet Squat (Front)", FileName = "erkekustbacakkobletsquatfront", Category = "Üst Bacak" },
                new Exercise { Name = "Leg Extension", FileName = "erkekustbacakmachineleg", Category = "Üst Bacak" },
                new Exercise { Name = "Leg Press (Quad)", FileName = "erkekustbacakmachinelegpressside", Category = "Üst Bacak" },
                new Exercise { Name = "Glute Ham Raise", FileName = "male-machine-glute-ham-raise-side", Category = "Üst Bacak" },


              
                //KADIN HAREKETLERİ
                
                new Exercise { Name = "Machine Horiz. Press", FileName = "kadinsquatmachinehorizontallegpressfront", Category = "Squat" },
                new Exercise { Name = "Dumbbell Hip Thrust", FileName = "kadinsquatdumbbellhipthrustside", Category = "Squat" },
                new Exercise { Name = "Cable RDL", FileName = "kadinsquatcableromaniandeadliftside", Category = "Squat" },
                new Exercise { Name = "High Bar Squat", FileName = "kadinsquatbarbellhighbarsquatside", Category = "Squat" },
                new Exercise { Name = "Cable Pull Through", FileName = "kadinsquatcablepullthroughside", Category = "Squat" },
                new Exercise { Name = "Kettlebell Swing", FileName = "kadinsquatkettlebellswingfront", Category = "Squat" },
                new Exercise { Name = "Dumbbell RDL", FileName = "kadinsquatdumbbellromaniandeadliftfront", Category = "Squat" },
                new Exercise { Name = "Machine Leg Press", FileName = "kadinsquatmachinelegpressside", Category = "Squat" },
                new Exercise { Name = "Goblet Squat", FileName = "kadinsquatdumbbellgobletsquatfront", Category = "Squat" },
                new Exercise { Name = "Barbell Hip Thrust", FileName = "kadinsquatbarbellhipthrustfront", Category = "Squat" },

                new Exercise { Name = "KB Single Row", FileName = "kadinsirtkettlebellrowsinglefront", Category = "Sırt" },
                new Exercise { Name = "Underhand Row", FileName = "kadinsirtmachineunderhandrowside", Category = "Sırt" },
                new Exercise { Name = "Assisted Chin Up", FileName = "kadinsirtmachineassistedneutralchinupfront", Category = "Sırt" },
                new Exercise { Name = "Machine Pulldown", FileName = "kadinsirtmachinepulldownfront", Category = "Sırt" },
                new Exercise { Name = "Cable Pull In", FileName = "kadinsirtcablepullinfront", Category = "Sırt" },
                new Exercise { Name = "Pull Up", FileName = "kadinsirtbodyweightpullupfront", Category = "Sırt" },
                new Exercise { Name = "Cable Lat Prayer", FileName = "kadinsirtcablelatprayerfront", Category = "Sırt" },

                new Exercise { Name = "Cable Cross Pushdown", FileName = "kadinarkakolcablecrosspushdownfront", Category = "Arka Kol" },
                new Exercise { Name = "Cable Pulldown (Tri)", FileName = "kadinarkakolmachinecablepulldownfront", Category = "Arka Kol" },
                new Exercise { Name = "Parallel Dips", FileName = "kadinarkakolBodyweightparralelbardipsfront", Category = "Arka Kol" },
                new Exercise { Name = "Decline Skullcrusher", FileName = "kadinarkakolkettlebelldeclineskullcrusherside", Category = "Arka Kol" },
                new Exercise { Name = "Overhead Extension", FileName = "kadinarkakolcableoverheadtricepextensionside", Category = "Arka Kol" },
                new Exercise { Name = "Bench Dips", FileName = "kadinarkakolBodyweightbenchdipsfront", Category = "Arka Kol" },
                new Exercise { Name = "Cable Pushdown", FileName = "kadinarkakolcablepushdownfront", Category = "Arka Kol" },

                new Exercise { Name = "Plate Calf Raise", FileName = "kadinaltbacakmachineplateloadedcalfraisefront", Category = "Alt Bacak" },
                new Exercise { Name = "45 Deg Calf Raise", FileName = "kadinaltbacakmachine45degreecalfraiseside", Category = "Alt Bacak" },
                new Exercise { Name = "TRX Calf Raise", FileName = "kadinaltbacaktrxcalfraisefront", Category = "Alt Bacak" },
                new Exercise { Name = "Leg Press Calf Jump", FileName = "kadinaltbacakmachinehorizontallegpresscalfjumpfront", Category = "Alt Bacak" },
                new Exercise { Name = "Cable Calf Raise", FileName = "kadinaltbacakcablecalveraisefront", Category = "Alt Bacak" },
                new Exercise { Name = "Standing Calf Raise", FileName = "kadinaltbacakmachinestandingcalfraisesfront", Category = "Alt Bacak" },

                
                new Exercise { Name = "Assisted Split Squat", FileName = "kadinustbacakBodyweightassistedbulgariansplitsquatfront", Category = "Üst Bacak" },
                new Exercise { Name = "Standing Leg Ext.", FileName = "kadinustbacakcablestandinglegextensionside", Category = "Üst Bacak" },
                new Exercise { Name = "Horizontal Leg Press", FileName = "kadinustbacakmachinehorizontallegpressfront", Category = "Üst Bacak" },
                new Exercise { Name = "KB Forward Lunge", FileName = "kadinustbacakkettlebellsinglearmforwardlungefront", Category = "Üst Bacak" },
                new Exercise { Name = "High Bar Squat", FileName = "kadinustbacakbarbellhighbarsquatside", Category = "Üst Bacak" },
                new Exercise { Name = "Goblet Squat (Quad)", FileName = "kadinustbacakdumbbellgobletsquatfront", Category = "Üst Bacak" },

                
                new Exercise { Name = "Rope Oblique Crunch", FileName = "kadinkarincableropekneelingobliquecrunchside", Category = "Karın" },
                new Exercise { Name = "Bicycle Crunch", FileName = "kadinkarinBodyweightbicyclecrunchfront", Category = "Karın" },
                new Exercise { Name = "Mountain Climber", FileName = "kadinkarinbodyweightmountainclimberfront", Category = "Karın" },
                new Exercise { Name = "Standing Crunch", FileName = "kadinkarincablestandingcrunchfront", Category = "Karın" },
                new Exercise { Name = "Kneeling Crunch", FileName = "kadinkarincablekneelingcrunchside", Category = "Karın" },
                new Exercise { Name = "Russian Twist", FileName = "kadinkarindumbbellrussiantwistfront", Category = "Karın" },

               
                new Exercise { Name = "Reverse Grip Curl", FileName = "kadinbilekcablebarreversegripcurlfront", Category = "Bilek" },
                new Exercise { Name = "Plate Pinch", FileName = "kadinbilekplatepinch-gripdeadliftfront", Category = "Bilek" },
                new Exercise { Name = "KB Single Row (Bilek)", FileName = "kadinbilekkettlebellsinglearmrowfront", Category = "Bilek" },
                new Exercise { Name = "KB Row", FileName = "kadinbilekkettlebellrowsinglefront", Category = "Bilek" },
                new Exercise { Name = "Cable Wrist Curl", FileName = "kadinbilekcablewristcurlfront", Category = "Bilek" },
                new Exercise { Name = "KB Wrist Curl", FileName = "kadinbilekkettlebellwristcurlfront", Category = "Bilek" },

               
                new Exercise { Name = "Squat Hold Curl", FileName = "kadinustkolplatesquatholdcurlfront", Category = "Kol" },
                new Exercise { Name = "KB Single Row (Bi)", FileName = "kadinustkolkettlebellsinglearmrowfront", Category = "Kol" },
                new Exercise { Name = "Assisted Chin Up (Bi)", FileName = "kadinustkolmachineassistedneutralchinupfront", Category = "Kol" },
                new Exercise { Name = "Concentration Curl", FileName = "kadinustkolkettlebellconcentrationcurlfront", Category = "Kol" },
                new Exercise { Name = "Cable Pull In (Bi)", FileName = "kadinustkolcablepullinfront", Category = "Kol" },
                new Exercise { Name = "Hammer Curl", FileName = "kadinustkoldumbbellhammercurlside", Category = "Kol" },
                new Exercise { Name = "Preacher Curl", FileName = "kadinustkoldumbbellpreachercurlside", Category = "Kol" },
                new Exercise { Name = "Chin Up", FileName = "kadinustkolbodyweightchinupside", Category = "Kol" },

                
                new Exercise { Name = "Cable Single Arm Shrug (30°)", Category = "Omuz", FileName = "kadinomuzcablesinglearm30-degreeshrugfront" },
                new Exercise { Name = "Single Arm Overhead Press", Category = "Omuz", FileName = "kadinomuzsinglearmoverheadpressside" },
                new Exercise { Name = "Dumbbell Seated Shrug", Category = "Omuz", FileName = "kadinomuzdumbbellseated-shrugfront" },
                new Exercise { Name = "Barbell Upright Row", Category = "Omuz",  FileName = "kadinomuzbarbelluprightrowside" },
                new Exercise { Name = "Cable Shrug (30°)", Category = "Omuz", FileName = "kadinomuzcable30degreeshrugfront" },
                new Exercise { Name = "Barbell Silverback Shrug", Category = "Omuz", FileName = "kadinomuzbarbellsilverbacshrugside" },



                new Exercise { Name = "Smith Incline Press", FileName = "kadingogussmithmachineinclinebenchpressfront", Category = "Göğüs" },
                new Exercise { Name = "Deficit Push Up", FileName = "kadingogusplatedeficitpushupfront", Category = "Göğüs" },
                new Exercise { Name = "KB Single Fly", FileName = "kadingoguskettlebellsinglearmchestflyside", Category = "Göğüs" },
                new Exercise { Name = "Assisted Dips", FileName = "kadingogusmachineassistedparralelbardipsfront", Category = "Göğüs" },
                new Exercise { Name = "Cable Chest Press", FileName = "kadingoguscablechestpressfront", Category = "Göğüs" },
                new Exercise { Name = "Machine Pec Fly", FileName = "kadingogusMachinemachinepecflyside", Category = "Göğüs" },
                new Exercise { Name = "DB Incline Press", FileName = "kadingogusdumbbellinclinebenchpressfront", Category = "Göğüs" }
            };
        }
    }
}