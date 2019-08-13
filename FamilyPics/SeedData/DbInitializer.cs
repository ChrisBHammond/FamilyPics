using Microsoft.AspNetCore.Identity;
using FamilyPics.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FamilyPics.SeedData
{
    public class DbInitializer
    {
        public static void Initialize(Context ctx)
        {

            SeedUsers(ctx);



        }


        private static void SeedUsers(Context ctx)
        {
            ctx.Users.Add(new User { FirstName = "Chris2" });

            ctx.SaveChanges();
        }
    }

}
