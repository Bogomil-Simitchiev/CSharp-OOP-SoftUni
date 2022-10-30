using System;
using System.Linq;
using System.Reflection;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();

            foreach (var item in properties)
            {
                var attributes = item.GetCustomAttributes().Where(x => x.GetType().IsSubclassOf(typeof(MyValidationAttribute)))
                    .Cast<MyValidationAttribute>()
                    .ToArray();
                foreach (var item2 in attributes)
                {
                    bool isValid = item2.IsValid(item.GetValue(obj));
                    if (!isValid)
                    {
                        return false;

                    }
                }

            }


            return true;
        }
    }
}