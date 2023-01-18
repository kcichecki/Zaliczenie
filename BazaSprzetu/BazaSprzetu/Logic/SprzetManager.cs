using BazaSprzetu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazaSprzetu.Logic
{
    public class SprzetManager
    {
        
            public SprzetManager AddSprzet(SprzetModel sprzetModel)
            {
            using (var context = new SprzetContext())
            {
                try
                {
                    context.Sprzet.Add(sprzetModel);
                    context.SaveChanges();
                }
                catch (System.Exception e)
                {

                    if (sprzetModel.ID != 0)
                    {
                        sprzetModel.ID = 0;
                        context.Sprzet.Add(sprzetModel);
                        context.SaveChanges();
                    }
                }
            }
            return this;
        }

            public SprzetManager RemoveSprzet(int id)
            {
            using (var context = new SprzetContext())
            {
                var sprzetToRemove = context.Sprzet.SingleOrDefault(f => f.ID == id);
                
                    context.Sprzet.Remove(sprzetToRemove);
                    context.SaveChanges();
                
            }

            return this;
        }

            public void UpdateSprzet(SprzetModel sprzet)
            {
            using (var context = new SprzetContext())
            {
                context.Sprzet.Update(sprzet);
                context.SaveChanges();
            }
        }

            

            public SprzetModel GetSprzet(int id)
            {
            using (var context = new SprzetContext())
            {
                return context.Sprzet.SingleOrDefault(x => x.ID == id);
            }
        }

            public List<SprzetModel> GetSprzets()
            {
            using (var context = new SprzetContext())
            {
                return context.Sprzet.ToList();
            }
        }
        
    }
}
