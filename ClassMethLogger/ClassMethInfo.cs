using System.Text;

namespace ClassMethLogger
{
    public static class ClassMethInfo
    {
        public static string MethInfo(string className, string methodName)
        {
            return String.Format("class: {0}, method: {1}", className, methodName);
        }

        public static string MethInfo<T>(string className, string methodName, Dictionary<String, T> methParams)
        {
            StringBuilder sb = new StringBuilder();
            const string PIF = "param name: {0}, param value: {1}";

            foreach (var item in methParams)
            {
                sb.Append(String.Format(PIF, item.Key, item.Value));
            }
            
            return String.Format("class: {0}, method: {1}, method params: {2}", className, methodName, sb.ToString());
        }
    }
}