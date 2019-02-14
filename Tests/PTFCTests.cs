using System;
using System.Threading;
using ACUtils;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class PTFCTests
    {
        [SetUp]
        public void Setup()
        {
        }
        /*
        [Test]
        public void TestPFC()
        {
            int n = 100;
            int count = 0;
            new Producer<int?>().Produce((outQueue) =>
                {
                    for (int i = 0; i < n; i++)
                    {
                        Thread.Sleep(2 * i);
                        outQueue.Enqueue(i);
                    }
                })
                .Filter((t) =>
                {
                    if (!t.HasValue) return null;
                    if ((t.GetValueOrDefault() % 2) == 0) return t;
                    return null;
                })
                .Filter((t) =>
                {
                    if (!t.HasValue) return null;
                    Thread.Sleep(2 * t.GetValueOrDefault());
                    if (t > n / 2) return t;
                    return null;
                })
                .Consume((i) =>
                {
                    if (!i.HasValue) return;
                    Thread.Sleep(i.GetValueOrDefault());
                    Assert.IsTrue((i.GetValueOrDefault() % 2) == 0);
                    Assert.IsTrue(i.GetValueOrDefault() > n / 2);
                    count++;
                });
            Assert.AreEqual((n / 4) - 1, count);

            count = 0;
            new Producer<int?>().Produce((outQueue) =>
                {
                    for (int i = 0; i < n; i++)
                    {
                        outQueue.Enqueue(i);
                    }
                })
                .Filter((t) =>
                {
                    if (!t.HasValue) return null;
                    if ((t.GetValueOrDefault() % 2) == 0) return t;
                    return null;
                })
                .Filter<string>((t) =>
                {
                    if (!t.HasValue) return null;
                    Thread.Sleep(2 * t.GetValueOrDefault());
                    if (t > n / 2) return t;
                    return null;
                })
                .Transmorm<int?>((t) =>
                {
                    if (!t.HasValue) return null;
                    return t.ToString();
                })
                .Transmorm((t) =>
                {
                    if (string.IsNullOrEmpty(t)) return null;
                    return Convert.ToInt32(t);
                })
                .Consume((i) =>
                {
                    if (!i.HasValue) return;
                    Thread.Sleep(i.GetValueOrDefault());
                    Assert.IsTrue((i.GetValueOrDefault() % 2) == 0);
                    Assert.IsTrue(i.GetValueOrDefault() > n / 2);
                    count++;
                });
            Assert.AreEqual((n / 4) - 1, count);
        }
        */
        private volatile int count;
        [Test]
        public void TestPTFC()
        {
            int n = 100;
            count = 0;
            new PTFC<int?>().Produce((outQueue) =>
                {
                    for (int i = 0; i < n; i++)
                    {
                        Thread.Sleep(2 * i);
                        outQueue.Enqueue(i);
                    }
                })
                .Filter((t) =>
                {
                    if (!t.HasValue) return null;
                    if ((t.GetValueOrDefault() % 2) == 0) return t;
                    return null;
                })
                .Filter((t) =>
                {
                    if (!t.HasValue) return null;
                    Thread.Sleep(2 * t.GetValueOrDefault());
                    if (t > n / 2) return t;
                    return null;
                })
                .Consume((i) =>
                {
                    if (!i.HasValue) return;
                    Thread.Sleep(i.GetValueOrDefault());
                    Assert.IsTrue((i.GetValueOrDefault() % 2) == 0);
                    Assert.IsTrue(i.GetValueOrDefault() > n / 2);
                    count++;
                });
            Assert.AreEqual((n / 4) - 1, count);
        }
        
        [Test]
        public void TestPFC()
        {
            int n = 100;
            count = 0;
            
            new Producer<int?>().Produce((outQueue) =>
                {
                    for (int i = 0; i < n; i++)
                    {
                        outQueue.Enqueue(i);
                    }
                })
                .Filter((t) =>
                {
                    if (!t.HasValue) return null;
                    if ((t.GetValueOrDefault() % 2) == 0) return t;
                    return null;
                })
                .Filter<string>((t) =>
                {
                    if (!t.HasValue) return null;
                    Thread.Sleep(2 * t.GetValueOrDefault());
                    if (t > n / 2) return t;
                    return null;
                })
                .Transmorm<int?>((t) =>
                {
                    if (!t.HasValue) return null;
                    return t.ToString();
                })
                .Transmorm((t) =>
                {
                    if (string.IsNullOrEmpty(t)) return null;
                    return Convert.ToInt32(t);
                })
                .Consume((i) =>
                {
                    if (!i.HasValue) return;
                    Thread.Sleep(i.GetValueOrDefault());
                    Assert.IsTrue((i.GetValueOrDefault() % 2) == 0);
                    Assert.IsTrue(i.GetValueOrDefault() > n / 2);
                    count++;
                });
            Assert.AreEqual((n / 4) - 1, count);
        }
    }
}