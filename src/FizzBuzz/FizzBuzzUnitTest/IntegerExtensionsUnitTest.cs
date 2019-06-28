using FizzBuzz;
using System;
using System.Linq.Expressions;
using Xunit;

namespace FizzBuzzUnitTest
{
    public class IntegerExtensionsUnitTest
    {
        private const uint Max = 100000;

        [Fact]
        public void IsFizzTest()
        {
            var value = Expression.Parameter(typeof(uint), "value");
            var expr = Expression.Lambda<Func<uint, bool>>(
                Expression.Equal(
                    Expression.Modulo(value, Expression.Constant(3U)),
                    Expression.Constant(0U)
                ),
                value
            );
            var f = expr.Compile();
            for (var i = 0U; i < Max; i++)
            {
                Assert.Equal(f(i), i.IsFizz());
            }
        }

        [Fact]
        public void IsBuzzTest()
        {
            var value = Expression.Parameter(typeof(uint), "value");
            var expr = Expression.Lambda<Func<uint, bool>>(
                Expression.Equal(
                    Expression.Modulo(value, Expression.Constant(5U)),
                    Expression.Constant(0U)
                ),
                value
            );
            var f = expr.Compile();
            for (var i = 0U; i < Max; i++)
            {
                Assert.Equal(f(i), i.IsBuzz());
            }
        }

        [Fact]
        public void IsFizzBuzzTest()
        {
            var value = Expression.Parameter(typeof(uint), "value");
            var expr = Expression.Lambda<Func<uint, bool>>(
                Expression.Equal(
                    Expression.Modulo(value, Expression.Constant(15U)),
                    Expression.Constant(0U)
                ),
                value
            );
            var f = expr.Compile();
            for (var i = 0U; i < Max; i++)
            {
                Assert.Equal(f(i), i.IsFizzBuzz());
            }
        }

        [Fact]
        public void ToFizzBuzzTest()
        {
            var toString = typeof(object).GetMethod("ToString");
            var value = Expression.Parameter(typeof(uint), "value");
            var expr = Expression.Lambda<Func<uint, string>>(
                Expression.Condition(
                    Expression.Equal(
                        Expression.Modulo(value, Expression.Constant(15U)),
                        Expression.Constant(0U)
                    ),
                    Expression.Constant("Fizz Buzz"),
                    Expression.Condition(
                        Expression.Equal(
                            Expression.Modulo(value, Expression.Constant(3U)),
                            Expression.Constant(0U)
                        ),
                        Expression.Constant("Fizz"),
                        Expression.Condition(
                            Expression.Equal(
                                Expression.Modulo(value, Expression.Constant(5U)),
                                Expression.Constant(0U)
                            ),
                            Expression.Constant("Buzz"),
                            Expression.Call(value, toString)
                        )
                    )
                ),
                value
            );

            var f = expr.Compile();
            for (var i = 0U; i < Max; i++)
            {
                Assert.Equal(f(i), i.ToFizzBuzz());
            }
        }
    }
}
