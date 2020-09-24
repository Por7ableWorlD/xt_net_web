using System;

namespace Bases
{
    public class AwardBase
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public override string ToString() => string.Format("Award Title: {0}", Title);
    }
}