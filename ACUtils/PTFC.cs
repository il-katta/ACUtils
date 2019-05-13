using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACUtils
{
    public class PTFC<T>
    {
        public ConcurrentQueue<T> OutQueue { get; }

        protected bool isRunning;
        public bool IsRunning => isRunning;

        public bool IsRunningOrNotEmpty => OutQueue != null && (IsRunning || !OutQueue.IsEmpty);

        private PTFC<T> producer;

        protected Action<Exception> onErrorAction;

        public PTFC()
        {
            OutQueue = new ConcurrentQueue<T>();
        }

        public PTFC(Action<Exception> onErrorAction)
        {
            OutQueue = new ConcurrentQueue<T>();
            this.onErrorAction = onErrorAction;
        }

        public PTFC(PTFC<T> producer)
        {
            OutQueue = new ConcurrentQueue<T>();
            this.producer = producer;
        }

        public PTFC(PTFC<T> producer, Action<Exception> onErrorAction)
        {
            OutQueue = new ConcurrentQueue<T>();
            this.producer = producer;
            this.onErrorAction = onErrorAction;
        }


        public PTFC<T> Produce(Action<ConcurrentQueue<T>> action)
        {
            isRunning = true;
            Task.Run(() =>
            {
                try
                {
                    action(OutQueue);
                }
                catch (Exception e)
                {
                    if (onErrorAction != null)
                    {
                        onErrorAction?.Invoke(e);
                    }
                    else
                    {
                        throw;
                    }
                }
                finally
                {
                    isRunning = false;
                }
            });
            return new PTFC<T>(this, this.onErrorAction);
        }


        private void _filter(Func<T, T> action)
        {
            while (producer.IsRunningOrNotEmpty)
            {
                if (producer.TryDequeue(out var t))
                {
                    try
                    {
                        var o = action(t);
                        OutQueue.Enqueue(o);
                    }
                    catch (DiscartException)
                    {
                        // ignore - elemento scartato
                    }
                }
            }
        }

        public PTFC<T> Filter(Func<T, T> action)
        {
            isRunning = true;
            Task.Run(() =>
            {
                try
                {
                    _filter(action);
                }
                catch (Exception e)
                {
                    if (onErrorAction != null)
                    {
                        onErrorAction?.Invoke(e);
                    }
                    else
                    {
                        throw;
                    }
                }
                finally
                {
                    isRunning = false;
                }
            });
            return new PTFC<T>(this, onErrorAction);
        }

        public PTFC<TO, T> Filter<TO>(Func<T, T> action)
        {
            isRunning = true;
            Task.Run(() =>
            {
                try
                {
                    _filter(action);
                }
                catch (Exception e)
                {
                    if (onErrorAction != null)
                    {
                        onErrorAction?.Invoke(e);
                    }
                    else
                    {
                        throw;
                    }
                }
                finally
                {
                    isRunning = false;
                }
            });
            return (new PTFC<TO, T>(this, onErrorAction));
        }

        public List<T> Consume()
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

        public void Consume(Action<T> action)
        {
            while (producer.IsRunningOrNotEmpty)
            {
                if (producer.TryDequeue(out var t))
                {
                    try
                    {
                        action(t);
                    }
                    catch (Exception e)
                    {
                        if (onErrorAction != null)
                        {
                            onErrorAction?.Invoke(e);
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
            }
        }

        public PTFC<T> Produce()
        {
            isRunning = true;
            Task.Run(() =>
            {
                try
                {
                    while (producer.IsRunningOrNotEmpty)
                    {
                        if (producer.TryDequeue(out var t))
                        {
                            OutQueue.Enqueue(t);
                        }
                    }
                }
                catch (Exception e)
                {
                    if (onErrorAction != null)
                    {
                        onErrorAction?.Invoke(e);
                    }
                    else
                    {
                        throw;
                    }
                }
                finally
                {
                    isRunning = false;
                }
            });
            return new PTFC<T>(this, this.onErrorAction);
        }

        public bool TryDequeue(out T t)
        {
            if (IsRunningOrNotEmpty && OutQueue != null)
            {
                return OutQueue.TryDequeue(out t);
            }

            t = default(T);
            return false;
        }

        public PTFC<T> OnError(Action<Exception> action)
        {
            this.onErrorAction = action;
            return this;
        }
    }


    public class PTFC<TO, TI> : PTFC<TO>
    {
        private PTFC<TI> producer;

        public PTFC(PTFC<TI> producer)
        {
            this.producer = producer;
        }

        public PTFC(PTFC<TI> producer, Action<Exception> onErrorAction) : base(onErrorAction)
        {
            this.producer = producer;
        }

        private void _filterT(Func<TI, TO> action)
        {
            while (producer.IsRunningOrNotEmpty)
            {
                if (producer.TryDequeue(out var t))
                {
                    try
                    {
                        var o = action(t);
                        OutQueue.Enqueue(o);
                    }
                    catch (DiscartException)
                    {
                        // ignore - elemento scartato
                    }
                }
            }
        }

        public PTFC<TO> Transform(Func<TI, TO> action)
        {
            isRunning = true;
            Task.Run(() =>
            {
                try
                {
                    _filterT(action);
                }
                catch (Exception e)
                {
                    if (onErrorAction != null)
                    {
                        onErrorAction?.Invoke(e);
                    }
                    else
                    {
                        throw;
                    }
                }
                finally
                {
                    isRunning = false;
                }
            });

            return new PTFC<TO>(this, this.onErrorAction);
        }

        public PTFC<TT, TO> Transform<TT>(Func<TI, TO> action)
        {
            isRunning = true;
            Task.Run(() =>
            {
                try
                {
                    _filterT(action);
                }
                catch (Exception e)
                {
                    if (onErrorAction != null)
                    {
                        onErrorAction?.Invoke(e);
                    }
                    else
                    {
                        throw;
                    }
                }
                finally
                {
                    isRunning = false;
                }
            });

            return new PTFC<TT, TO>(this, this.onErrorAction);
        }

        public new PTFC<TO, TI> OnError(Action<Exception> action)
        {
            this.onErrorAction = action;
            return this;
        }
    }
}