using System;
using System.Reflection;

namespace CLR_via_CSharp.PrimitiveDataType
{
    internal sealed class TypeDynamicTest
    {
        //Следующий фрагмент показывает , как использовать отражение для вызова метода (Contains)  с
        //аргументом Srting("ff") для строки ("Jeffre Richtor") и поместить результат с типом Int32 в
        //локальную переменную result.
        private static readonly Object _target = "Jeffrey Richtor";
        private static readonly Object _arg = "ff";
        
        //Находим метод который подходит по типам аргументов.
        private static readonly Type[] _argTypes = { _arg.GetType()};
        private static readonly MethodInfo? _methobInfo = _target.GetType().GetMethod("Contains", _argTypes);
        
        //Вызов метода с желаемым аргументом.
        private static readonly Object?[]? _arguments = {_arg};
        private static readonly Boolean _result = Convert.ToBoolean(_methobInfo?.Invoke(_target, _arguments));

        public string Result()
        {
            return _result.ToString();
        }
        
        //Если использовать тип dynamic , это код можно значительно улучшить с точки зрения синтаксиса .
        private static readonly dynamic _target1 = _target;
        private static readonly dynamic _arg2 = _arg;
        private static readonly Boolean _result2 = _target1.Contains(_arg2);
        
        
        public string Result2()
        { 
            return _result2.ToString();
        }
        
   }
}