using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Enums{
    // [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MyEnum{
        Value1,
        Value2,
        Value3
    }

    // [JsonConverter(typeof(JsonStringEnumConverter))]
    // public enum MyEnum2{
    //     [EnumMember(Value = "first")]
    //     Value1,
    //     [EnumMember(Value = "secondValue")]
    //     Value2,
    //     [EnumMember(Value = "thirdValue")]
    //     Value3
    // }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MyEnum2{
        Value1,
        Value2,
        Value3
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MyEnum3{
        [EnumMember(Value = "firstValue")]
        Value1,
        [EnumMember(Value = "secondValue")]
        Value2,
        [EnumMember(Value = "thirdValue")]
        Value3
    }

    public static class DemoClass{
        public static void demo(){
            MyEnum e = MyEnum.Value1;
            MyEnum2 e2 = MyEnum2.Value1;
            MyEnum3 e3 = MyEnum3.Value1;

            Console.WriteLine($"first enum: {JsonConvert.SerializeObject(e)}");
            // Console.WriteLine($"second enum: {JsonSerializer.Serialize(e2)}");
            Console.WriteLine($"second enum: {JsonConvert.SerializeObject(e2)}");
            Console.WriteLine($"third enum: {JsonConvert.SerializeObject(e3)}");
        }
    }

}