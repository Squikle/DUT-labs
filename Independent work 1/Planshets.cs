using System.Collections.Generic;
using System.Text;

namespace Independent_work_1
{
    class Planshets
    {
        private readonly List<Planshet> _planshetsCollection;

        public Planshets()
        {
            _planshetsCollection = new List<Planshet>
            {
                new Planshet("Samsung", 2018, 8000, new List<string>() {"black", "red"}),
                new Planshet("Apple", 2020, 15000, new List<string>() {"black"}),
                new Planshet("Apple", 2019, 20000, new List<string>() {"white", "gold"}),
                new Planshet("Huawei", 2018, 15000, new List<string>() {"black", "red"}),
                new Planshet("Xiaomi", 2017, 7000, new List<string>() {"black", "silver"}),
            };
        }

        public IEnumerable<Planshet> GetPlanshets(Planshet planshet)
        {
            LinkedList<Planshet> candidates = new LinkedList<Planshet>();
            foreach (var _planshet in _planshetsCollection)
            {
                if (planshet.Colors == null)
                    continue;

                bool colorIsMatch = false;
                foreach (var color in _planshet.Colors)
                {
                    if (planshet.Colors[0].ToLower() != color.ToLower())
                        colorIsMatch = true;
                }
                if (!colorIsMatch)
                    continue;

                if (planshet.Year != 0 && _planshet.Year != planshet.Year)
                    continue;
                if (planshet.Price != 0 && _planshet.Price != planshet.Price)
                    continue;
                if (planshet.Brand != "0" && _planshet.Brand.ToLower() != planshet.Brand.ToLower())
                    continue;

                candidates.AddFirst(_planshet);
            }
            return candidates;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder("Все планшеты:\n");
            for (int i = 0; i < _planshetsCollection.Count; i++)
            {
                info.Append($"Планшет #{i}:\n{_planshetsCollection[i]}\n\n");
            }
            return info.ToString();
        }
    }
}
