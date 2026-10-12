
using System;
using System.Reflection;

namespace ReflectionDemo
{
    public class SampleClass
    {
        public int SampleField;
        public string SampleProperty { get; set; }

        public void SampleMethod1()
        {
            Console.WriteLine("Sample Method 1 called");
        }

        public int SampleMethod2(int p1, string p2)
        {
            return p1 + p2.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            Console.WriteLine("Assembly Full Name: " + asm.FullName);

            Type[] types = asm.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine("\nType: " + type.FullName);

                MethodInfo[] methods = type.GetMethods();

                foreach (MethodInfo method in methods)
                {
                    Console.WriteLine("Method: " + method.Name);
                    Console.WriteLine("Return Type: " +
                        method.ReturnType.Name);

                    ParameterInfo[] parameters = method.GetParameters();

                    foreach (ParameterInfo p in parameters)
                    {
                        Console.WriteLine("Parameter: " + p.Name +
                            ", Type: " + p.ParameterType.Name);
                    }
                }

                PropertyInfo[] properties = type.GetProperties();

                foreach (PropertyInfo p in properties)
                {
                    Console.WriteLine("Property: " + p.Name);
                }

                FieldInfo[] fields = type.GetFields();

                foreach (FieldInfo f in fields)
                {
                    Console.WriteLine("Field: " + f.Name);
                }
            }

            Console.ReadLine();
        }
    }
}
