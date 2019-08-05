using ACUtils;
using NUnit.Framework;
using System;
using System.Threading;

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
                    if (!t.HasValue)
                    {
                        return null;
                    }

                    if ((t.GetValueOrDefault() % 2) == 0)
                    {
                        return t;
                    }

                    return null;
                })
                .Filter((t) =>
                {
                    if (!t.HasValue)
                    {
                        return null;
                    }

                    Thread.Sleep(2 * t.GetValueOrDefault());
                    if (t > n / 2)
                    {
                        return t;
                    }

                    return null;
                })
                .Consume((i) =>
                {
                    if (!i.HasValue)
                    {
                        return;
                    }

                    Thread.Sleep(i.GetValueOrDefault());
                    Assert.IsTrue((i.GetValueOrDefault() % 2) == 0);
                    Assert.IsTrue(i.GetValueOrDefault() > n / 2);
                    count++;
                });
            Assert.AreEqual((n / 4) - 1, count);
        }


        [Test]
        public void TestPTFC_OnError()
        {
            int n = 100;
            count = 0;
            string exceptionMessage = "test exception";
            bool success = false;
            new PTFC<int?>().Produce((outQueue) =>
            {
                for (int i = 0; i < n; i++)
                {
                    Thread.Sleep(2 * i);
                    outQueue.Enqueue(i);
                }
            })
                .OnError((e) =>
                {
                    Assert.AreEqual(e.Message, exceptionMessage);
                    Console.WriteLine("test concluso");
                    success = true;
                    Assert.Pass("action OnError eseguita");
                })
                .Filter((t) =>
                {
                    throw new Exception(exceptionMessage);
                })
                .Filter((t) =>
                {
                    Assert.Fail("questa action non dovrebbe essere mai eseguita");
                    return null;
                })
                .Consume((i) =>
                {
                    Assert.Fail("questa action non dovrebbe essere mai eseguita");
                });
            Assert.IsTrue(success);
        }

        [Test]
        public void TestPTFC_Trasform()
        {
            int n = 100;
            count = 0;
            new PTFC<int>().Produce((outQueue) =>
            {
                for (int i = 0; i < n; i++)
                {
                    Thread.Sleep(2 * i);
                    outQueue.Enqueue(i);
                }
            })
                .Filter((t) =>
                {
                   
                    if ((t % 2) == 0)
                    {
                        return t;
                    }

                    throw new ACUtils.Exceptions.DiscartException();
                })
                .Filter<string>((t) =>
                {
                    Thread.Sleep(2 * t);
                    if (t > n / 2)
                    {
                        return t;
                    }

                    throw new ACUtils.Exceptions.DiscartException();
                })
                .Transform((t) =>
                {
                    return t.ToString();
                })
                .Consume((s) =>
                {
                    var i = Convert.ToInt32(s);
                    Thread.Sleep(i);
                    Assert.IsTrue((i % 2) == 0);
                    Assert.IsTrue(i > n / 2);
                    count++;
                });
            Assert.AreEqual((n / 4) - 1, count);
        }


        [Test]
        public void TestPTFC_Trasform_OnError()
        {
            int n = 100;
            count = 0;
            string exceptionMessage = "test exception";
            bool success = false;
            new PTFC<int?>().Produce((outQueue) =>
            {
                for (int i = 0; i < n; i++)
                {
                    Thread.Sleep(2 * i);
                    outQueue.Enqueue(i);
                }
            })
                .OnError((e) =>
                {
                    Assert.AreEqual(e.Message, exceptionMessage);
                    success = true;
                    Assert.Pass("action OnError eseguita");
                })
                .Filter<string>((a) =>
                {
                    return a;
                })
                .Transform((a) =>
                {
                    return a?.ToString();
                })
                .Filter((t) =>
                {
                    throw new Exception(exceptionMessage);
                })
                .Filter((t) =>
                {
                    Assert.Fail("questa action non dovrebbe essere mai eseguita");
                    return null;
                })
                .Consume((i) =>
                {
                    Assert.Fail("questa action non dovrebbe essere mai eseguita");
                });
            Assert.IsTrue(success);
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
                    if (!t.HasValue)
                    {
                        return null;
                    }

                    if ((t.GetValueOrDefault() % 2) == 0)
                    {
                        return t;
                    }

                    return null;
                })
                .Filter<string>((t) =>
                {
                    if (!t.HasValue)
                    {
                        return null;
                    }

                    Thread.Sleep(2 * t.GetValueOrDefault());
                    if (t > n / 2)
                    {
                        return t;
                    }

                    return null;
                })
                .Transmorm<int?>((t) =>
                {
                    if (!t.HasValue)
                    {
                        return null;
                    }

                    return t.ToString();
                })
                .Transmorm((t) =>
                {
                    if (string.IsNullOrEmpty(t))
                    {
                        return null;
                    }

                    return Convert.ToInt32(t);
                })
                .Consume((i) =>
                {
                    if (!i.HasValue)
                    {
                        return;
                    }

                    Thread.Sleep(i.GetValueOrDefault());
                    Assert.IsTrue((i.GetValueOrDefault() % 2) == 0);
                    Assert.IsTrue(i.GetValueOrDefault() > n / 2);
                    count++;
                });
            Assert.AreEqual((n / 4) - 1, count);
        }
    }
}