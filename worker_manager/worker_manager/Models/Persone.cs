using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worker_manager.Models
{
    class Persone:GlobalPersone
    {
       public static IEnumerable<GlobalPersone> GetPeople()
        {
            return new List<GlobalPersone>
            {
                new GlobalPersone
                {
                    ID=1,
                    NAME="Alex",
                    ADRESS="Kyiv",
                    BIRTHDAY="23.12.2000",
                    PHONE="58758586",
                    PersonPozition=ChangetPozition.PersonPozition.Developer,
                    PersonStatus=ChangetStatus.PersonStatus.Input,
                    SALARY=34.89,
                    INPUT="01.01.2018",
                    EXIT="default"
                },
                new GlobalPersone
                {
                    ID=2,
                    NAME="Fred",
                    ADRESS="Lwiv",
                    BIRTHDAY="23.12.1987",
                    PHONE="58733586",
                    PersonPozition=ChangetPozition.PersonPozition.Developer,
                    PersonStatus=ChangetStatus.PersonStatus.Input,
                    SALARY=15.89,
                    INPUT="01.01.2000",
                    EXIT="default"
                },new GlobalPersone
                {
                    ID=3,
                    NAME="Tania",
                    ADRESS="Rovno",
                    BIRTHDAY="23.12.2002",
                    PHONE="58758586",
                    PersonPozition=ChangetPozition.PersonPozition.Developer,
                    PersonStatus=ChangetStatus.PersonStatus.Exit,
                    SALARY=18.89,
                    INPUT="01.01.2018",
                    EXIT="12.12.2023"
                },new GlobalPersone
                {
                    ID=4,
                    NAME="Frenkee",
                    ADRESS="Kyiv",
                    BIRTHDAY="23.12.1990",
                    PHONE="58758586",
                    PersonPozition=ChangetPozition.PersonPozition.Developer,
                    PersonStatus=ChangetStatus.PersonStatus.Exit,
                    SALARY=34.89,
                    INPUT="01.01.2015",
                    EXIT="07.08.2019"
                }
            };

        }
        
    }
}
