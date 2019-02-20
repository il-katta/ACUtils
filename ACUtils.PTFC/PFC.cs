using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACUtils
{
    public abstract class BaseRunner<T>
    {
        public ConcurrentQueue<T> OutQueue { get; }

        protected bool isRunning;
        public bool IsRunning => isRunning;

        public bool IsRunningOrNotEmpty => IsRunning || !OutQueue.IsEmpty;

        public BaseRunner()
        {
            OutQueue = new ConcurrentQueue<T>();
        }

        public bool TryDequeue(out T t)
        {
            if (IsRunningOrNotEmpty)
            {
                return OutQueue.TryDequeue(out t);
            }

            t = default(T);
            return false;
        }

        public abstract List<T> Consume();

        public abstract void Consume(Action<T> action);
    }

    public class Transmormer<TO, TI> : BaseRunner<TO>
    {
        private BaseRunner<TI> producer;

        public Transmormer(BaseRunner<TI> producer)
        {
            this.producer = producer;
        }

        public override List<TO> Consume()
        {
            var l = new List<TO>();
            while (IsRunningOrNotEmpty)
            {
                if (TryDequeue(out var t))
                {
                    l.Add(t);
                }
            }

            return l;
        }

        public override void Consume(Action<TO> action)
        {
            while (IsRunningOrNotEmpty)
            {
                if (TryDequeue(out var t))
                {
                    action(t);
                }
            }
        }

        private void _filter(Func<TI, TO> action)
        {
            while (producer.IsRunningOrNotEmpty)
            {
                if (producer.TryDequeue(out var t))
                {
                    if (t.Equals(default(TI))) continue;
                    var o = action(t);
                    if (o.Equals(default(TO))) continue;
                    OutQueue.Enqueue(o);
                }
            }
        }

        public Filterer<TO> Transmorm(Func<TI, TO> action)
        {
            isRunning = true;
            Task.Run(() =>
            {
                _filter(action);
                isRunning = false;
            });

            return new Filterer<TO>(this);
        }
        
        public Transmormer<TT, TO> Transmorm<TT>(Func<TI, TO> action)
        {
            isRunning = true;
            Task.Run(() =>
            {
                _filter(action);
                isRunning = false;
            });

            return new Transmormer<TT, TO>(this);
        }
    }

    public class Producer<T> : BaseRunner<T>
    {
        public Filterer<T> Produce(Action<ConcurrentQueue<T>> action)
        {
            isRunning = true;
            Task.Run(() =>
            {
                action(OutQueue);
                isRunning = false;
            });
            return new Filterer<T>(this);
        }

        public override List<T> Consume()
        {
            var l = new List<T>();
            while (IsRunningOrNotEmpty)
            {
                if (TryDequeue(out var t))
                {
                    if (t.Equals(default(T))) continue;
                    l.Add(t);
                }
            }

            return l;
        }

        public override void Consume(Action<T> action)
        {
            while (IsRunningOrNotEmpty)
            {
                if (TryDequeue(out var t))
                {
                    if (t.Equals(default(T))) return;
                    action(t);
                }
            }
        }
    }

    public class Filterer<T> : BaseRunner<T>
    {
        private BaseRunner<T> producer;

        public Filterer(BaseRunner<T> producer)
        {
            this.producer = producer;
        }


        private void _filter(Func<T, T> action)
        {
            while (producer.IsRunningOrNotEmpty)
            {
                if (producer.TryDequeue(out var t))
                {
                    if (t.Equals(default(T))) continue;
                    var o = action(t);
                    if (o.Equals(default(T))) continue;
                    OutQueue.Enqueue(o);
                }
            }
        }

        public Filterer<T> Filter(Func<T, T> action)
        {
            isRunning = true;
            Task.Run(() =>
            {
                _filter(action);
                isRunning = false;
            });
            return new Filterer<T>(this);
        }

        public Transmormer<TO, T> Filter<TO>(Func<T, T> action)
        {
            isRunning = true;
            Task.Run(() =>
            {
                _filter(action);
                isRunning = false;
            });
            return new Transmormer<TO, T>(this);
        }


        public override List<T> Consume()
        {
            var l = new List<T>();
            while (producer.IsRunningOrNotEmpty)
            {
                if (producer.TryDequeue(out var t))
                {
                    l.Add(t);
                }
            }

            return l;
        }

        public override void Consume(Action<T> action)
        {
            while (producer.IsRunningOrNotEmpty)
            {
                if (producer.TryDequeue(out var t))
                {
                    action(t);
                }
            }
        }
    }
}