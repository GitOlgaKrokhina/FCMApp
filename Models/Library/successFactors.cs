using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCMApp.Models.Library
{
    public class successFactors
    {
        int id_factor;
        string name_factor;
        string description_factor;
        membershipFunction membership_function_factor;
        defuzzificationMethod dfm;
        public int ID_FACTOR { get; set; }
        public string NAME_FACTOR {
            get
            {
                return name_factor;    // возвращаем значение свойства
            }
            set
            {
                name_factor = value;   // устанавливаем новое значение свойства
            }
        }
        public string DESCRIPTION_FACTOR {
            get
            {
                return description_factor;    // возвращаем значение свойства
            }
            set
            {
                description_factor = value;   // устанавливаем новое значение свойства
            }
        }
        public membershipFunction MEMBERSHIP_FUNCTION_FACTOR { get; set; }
        public defuzzificationMethod DFM { get; set; }

        public successFactors(int id, string name, string value, membershipFunction MF, defuzzificationMethod DFM)
        {
            this.id_factor = id;
            this.name_factor = name;
            this.description_factor = value;
            this.membership_function_factor = MF;
            this.dfm = DFM;
        }
        public static List<successFactors> listOfSuccessFactors = new List<successFactors>() {
            new successFactors(1,"Качество проектируемой системы", "Как оценивается качественность проектируемой системы?", null, null),
            new successFactors(2, "Качество процессов управления проектом", "Как оценивается качественность процессов управления проектом?", null, null),
            new successFactors(3, "Соблюдение сроков", "Соблюдаются ли сроки?", null, null),
            new successFactors(4, "Соблюдение бюджета", "Соблюдается ли бюджет?", null, null),
            new successFactors(5, "Удовлетворенность стейкхолдеров", "Как оценивается удовлетворенность заинтересованных лиц?", null, null),
            new successFactors(6, "Удовлетворенность пользователя", "Как оценивается удовлетворенность пользователя?", null, null)
        }
        ;
        public static void addToList(string name, string value)
        {
            listOfSuccessFactors.Add(new successFactors(listOfSuccessFactors.Count + 1, name, value, null, null));
        }
    }
}
