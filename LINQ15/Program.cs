using System;

namespace LINQ15.Shared
{
    internal class Program
    {
        static void Main(String[] args)
        {
            UnionAndUnionBy();
            Console.ReadKey();
        }

        private static void DisAndDisBy()
        {
            var parm1m2 = Repository.Meeting1.Participants.Concat(Repository.Meeting2.Participants);
            parm1m2.Print("Par in Meeting1 and Meeting2");

            var distinctParm1sm2 = parm1m2.Distinct();
            distinctParm1sm2.Print("Distincts");

            var distictByParm1m2 = parm1m2.DistinctBy(x => x.EmployeeNo);
            distictByParm1m2.Print("Disincts By");
            Console.ReadKey();
        }
        private static void ExceptAndExceptBy()
        {
            var set1 = Repository.Meeting1.Participants;
            var set2 = Repository.Meeting2.Participants;

            set1.Print($"============ Meeting 1 Par ({set1.Count()})");
            set2.Print($"============ Meeting 2 Par ({set2.Count()})");

            var set3 = set1.Except(set2);
            set3.Print("meeting 1 except meeting 2");

            var set4 = set1.ExceptBy(set2.Select(x => x.EmployeeNo), x => x.EmployeeNo);
            set4.Print("ExceptBy:");


        }
        private static void IntersecAndIntersect()
        {
            var set1 = Repository.Meeting1.Participants;
            var set2 = Repository.Meeting2.Participants;

            set1.Print($"============ Meeting 1 Par ({set1.Count()})");
            set2.Print($"============ Meeting 2 Par ({set2.Count()})");

            var set3 = set1.Intersect(set2);
            set3.Print("meeting 1 except meeting 2");

            var set4 = set1.IntersectBy(set2.Select(x => x.EmployeeNo), x => x.EmployeeNo);
            set4.Print("IntersectBy:");


        }
        private static void UnionAndUnionBy()
        {
            var set1 = Repository.Meeting1.Participants;
            var set2 = Repository.Meeting2.Participants;

            set1.Print($"============ Meeting 1 Par ({set1.Count()})");
            set2.Print($"============ Meeting 2 Par ({set2.Count()})");
            var set3 = set1.Union(set2);
            set3.Print("meeting 1 Union meeting 2");

            var set4 = set1.UnionBy(set2, x => x.EmployeeNo);

            set3.Print("meeting 1 UnionBy meeting 2");
        }


    }
}