using StudentService.Models;
using StudentService.Data;
using System.Linq;

namespace StudentService.Data
{
    public class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Check if StateLGAs already exist
            if (!context.StateLGAs.Any())
            {
                context.StateLGAs.AddRange(
                    // Lagos State LGAs
                    new StateLGA { State = "Lagos", LGA = "Ikeja" },
                    new StateLGA { State = "Lagos", LGA = "Surulere" },
                    new StateLGA { State = "Lagos", LGA = "Agege" },
                    new StateLGA { State = "Lagos", LGA = "Lekki" },
                    new StateLGA { State = "Lagos", LGA = "Apapa" },

                    // Kano State LGAs
                    new StateLGA { State = "Kano", LGA = "Nassarawa" },
                    new StateLGA { State = "Kano", LGA = "Gwale" },
                    new StateLGA { State = "Kano", LGA = "Fagge" },
                    new StateLGA { State = "Kano", LGA = "Kumbotso" },
                    new StateLGA { State = "Kano", LGA = "Bebeji" },

                    // Abuja Federal Capital Territory (FCT) LGAs
                    new StateLGA { State = "Abuja", LGA = "Abuja Municipal Area Council" },
                    new StateLGA { State = "Abuja", LGA = "Bwari" },
                    new StateLGA { State = "Abuja", LGA = "Kuje" },
                    new StateLGA { State = "Abuja", LGA = "Gwagwalada" },

                    // Rivers State LGAs
                    new StateLGA { State = "Rivers", LGA = "Port Harcourt" },
                    new StateLGA { State = "Rivers", LGA = "Obio-Akpor" },
                    new StateLGA { State = "Rivers", LGA = "Ikwerre" },
                    new StateLGA { State = "Rivers", LGA = "Emuoha" },

                    // Oyo State LGAs
                    new StateLGA { State = "Oyo", LGA = "Ibadan South West" },
                    new StateLGA { State = "Oyo", LGA = "Ibadan North" },
                    new StateLGA { State = "Oyo", LGA = "Ogbomosho North" },
                    new StateLGA { State = "Oyo", LGA = "Akinyele" },

                    // Anambra State LGAs
                    new StateLGA { State = "Anambra", LGA = "Awka North" },
                    new StateLGA { State = "Anambra", LGA = "Awka South" },
                    new StateLGA { State = "Anambra", LGA = "Onitsha South" },
                    new StateLGA { State = "Anambra", LGA = "Onitsha North" },

                    // Kaduna State LGAs
                    new StateLGA { State = "Kaduna", LGA = "Kaduna North" },
                    new StateLGA { State = "Kaduna", LGA = "Kaduna South" },
                    new StateLGA { State = "Kaduna", LGA = "Zaria" },
                    new StateLGA { State = "Kaduna", LGA = "Kachia" },

                    // Ekiti State LGAs
                    new StateLGA { State = "Ekiti", LGA = "Ado-Ekiti" },
                    new StateLGA { State = "Ekiti", LGA = "Ikere" },
                    new StateLGA { State = "Ekiti", LGA = "Ikole" },

                    // Delta State LGAs
                    new StateLGA { State = "Delta", LGA = "Asaba" },
                    new StateLGA { State = "Delta", LGA = "Warri North" },
                    new StateLGA { State = "Delta", LGA = "Warri South" },

                    // Ogun State LGAs
                    new StateLGA { State = "Ogun", LGA = "Abeokuta North" },
                    new StateLGA { State = "Ogun", LGA = "Abeokuta South" },
                    new StateLGA { State = "Ogun", LGA = "Ijebu North" },
                    new StateLGA { State = "Ogun", LGA = "Ijebu South" }
                );

                // Save changes to the database
                context.SaveChanges();
            }
        }
    }
}
