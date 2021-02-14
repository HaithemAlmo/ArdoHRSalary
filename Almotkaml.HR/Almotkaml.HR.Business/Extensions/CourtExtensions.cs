using Almotkaml.HR.Domain;
using Almotkaml.HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almotkaml.HR.Business.Extensions
{
 
    public static class CourtExtensions
    {
        public static IEnumerable<CourtListItem> ToList(this IEnumerable<Court> courts)
           => courts.Select(d => new CourtListItem()
           {
               CourtName = d.CourtName,
               CourtId = d.CourtId
           });
    }
}
