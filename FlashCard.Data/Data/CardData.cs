using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlashCard.Data.Models;

namespace FlashCard.Data
{
    public class CardData : EntityData<Card>
    {
        public List<string> GetCategories()
        {
            using (FlashCardEntities context = new FlashCardEntities())
            {
                List<string> list =
                    context.Cards
                    .Select(x => x.Category)
                    .Distinct()
                    .ToList();

                return list;
            }
        }

        public List<Cell> GetCells(string category)
        {
            using (FlashCardEntities context = new FlashCardEntities())
            {
                var query = from x in context.Cards
                            where x.Category == category
                            group x by x.CellNo into g
                            select new
                            {
                                CellNo = g.Key,
                                Count = g.Count()
                            };

                var list = query.ToList();

                List<Cell> cells = list.ConvertAll(x => new Cell(x.CellNo, x.Count));

                for (int i = 1; i <= 6; i++)
                    if (cells.Exists(x => x.CellNo == i) == false)
                        cells.Add(new Cell(i, 0));

                return cells.OrderBy(x => x.CellNo).ToList();
            }
        }
    }
}
