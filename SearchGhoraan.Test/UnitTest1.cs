using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using NUnit.Framework;
using System.Runtime.Caching;

namespace SearchGhoraan.Test
{
    //[TestClass]
    //public class UnitTest1
    //{
    //    [TestMethod]
    //    public void TestStringComparission()
    //    {
    //        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-SA");
    //        string name1 = "محمد";
    //        string name2 = "مُـحمَّـد";
    //        if (name1 == name2)
    //            Console.WriteLine("Strings are identical");
    //        else
    //            Console.WriteLine("Strings are different!");
    //        if (String.Compare(name1, name2) == 0)
    //            Console.WriteLine("Strings are identical");
    //        else
    //            Console.WriteLine("Strings are different!");
    //        if (String.Compare(name1, name2,
    //        System.Threading.Thread.CurrentThread.CurrentCulture,CompareOptions.IgnoreSymbols) == 0)
    //            Console.WriteLine("Strings are identical");
    //        else
    //            Console.WriteLine("Strings are different!");
    //    }
        
       
    //}
    [TestFixture]
    public class TestCache
    {
        [TestCase("Cache1",1)]
        [TestCase("Cache2", 2)]
        [TestCase("Cache3", 3)]
        public void CanCache(string key, int value)
        {
            ObjectCache cache = MemoryCache.Default;

            var policyItem = new CacheItemPolicy { 
                Priority=CacheItemPriority.NotRemovable,
                AbsoluteExpiration=new DateTimeOffset(DateTime.Now.AddSeconds(2)),
            };
            policyItem.RemovedCallback += new CacheEntryRemovedCallback(OnRemoveCacheItem);
            cache.Add(new CacheItem("Id", 200),policyItem);
            System.Threading.Thread.Sleep(10000);
        }
        private void OnRemoveCacheItem(CacheEntryRemovedArguments removed)
        {
            Console.WriteLine(removed.RemovedReason);
        }
        [TestCase(2,3,Result=6)]
        [TestCase(3, 4, Result = 12)]
        public int TestWithCheckingResult(int a,int b)
        {
            return a * b;
        }
    }
}
