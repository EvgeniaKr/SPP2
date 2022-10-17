using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    public class Cycle
    {
        public List<Type> fields;
        public List<Type> dependencyList;
        public Cycle()
        {
            fields = new List<Type>();
            dependencyList = new List<Type>();
        }
        public bool IsContainsCycles(Type objectType)
        {
            fields.Add(objectType);
            FieldInfo[] objectFields = objectType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
            List<Type> fieldsList = new List<Type>();
            foreach (FieldInfo field in objectFields)
            {
                if (field.FieldType.IsClass)
                {
                    if (fieldsList.Contains(field.FieldType) == false)
                        fieldsList.Add(field.FieldType);
                }
            }
            foreach (var field in fieldsList)
            {
                if (fields.Contains(field) == false)
                {
                    if (IsContainsCycles(field))
                    {
                        dependencyList.Add(field);
                        return true;
                    }
                }
                else
                {
                    dependencyList.Add(field);
                    return true;
                }
            }
            return false;
        }
    }
}
