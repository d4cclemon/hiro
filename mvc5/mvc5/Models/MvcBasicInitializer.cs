using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvc5.Models
{
    public class MvcBasicInitializer : DropCreateDatabaseAlways<MvcBasicContext>
    {
        protected override void Seed(MvcBasicContext context)
        {
            var members = new List<Member>
            {
                new Member
                {
                    Name = "田中太郎",
                    EMail = "rio@wings.msn.to",
                    Birth = DateTime.Parse("1980-09-25"),
                    Married = false,
                    Memo = "趣味はピアノ"
                },
                new Member
                {
                    Name = "山田孝雄",
                    EMail = "aaa@docomo.ne.jp",
                    Birth = DateTime.Parse("2009-09-11"),
                    Married = false,
                    Memo = "サッカー好き"
                }
            };

            members.ForEach(m => context.Members.Add(m));
            context.SaveChanges();
        }
    }
}