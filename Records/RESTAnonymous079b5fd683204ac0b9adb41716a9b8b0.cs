using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderTempRecord
public class RESTRC_1cda0f8d3a174e3a7f752b5be5436b83 : AbstractRESTStructure<RC_1cda0f8d3a174e3a7f752b5be5436b83> {
[JsonProperty("OrderTemp")]
public ssConectaProveedores.RestRecords.RESTST_9b020d447acc32d28b5e58ce81130d00Structure AttrOrderTemp;

public RESTRC_1cda0f8d3a174e3a7f752b5be5436b83() { }

public RESTRC_1cda0f8d3a174e3a7f752b5be5436b83 (RC_1cda0f8d3a174e3a7f752b5be5436b83 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderTemp = ConvertToRestWithoutDefaults(s.ssSTOrderTemp, new ST_9b020d447acc32d28b5e58ce81130d00Structure(), ssConectaProveedores.RestRecords.RESTST_9b020d447acc32d28b5e58ce81130d00Structure.FromStructure, config);
  } else {
AttrOrderTemp = ssConectaProveedores.RestRecords.RESTST_9b020d447acc32d28b5e58ce81130d00Structure.FromStructure(s.ssSTOrderTemp, config);
  }
}

public static RC_1cda0f8d3a174e3a7f752b5be5436b83 ToStructure(ssConectaProveedores.RestRecords.RESTRC_1cda0f8d3a174e3a7f752b5be5436b83 obj) { 
  RC_1cda0f8d3a174e3a7f752b5be5436b83 s = new RC_1cda0f8d3a174e3a7f752b5be5436b83();
  if(obj != null) {
  s.ssSTOrderTemp = ssConectaProveedores.RestRecords.RESTST_9b020d447acc32d28b5e58ce81130d00Structure.ToStructure(obj.AttrOrderTemp);
  }
  return s;
}

public static Func<RC_1cda0f8d3a174e3a7f752b5be5436b83, ssConectaProveedores.RestRecords.RESTRC_1cda0f8d3a174e3a7f752b5be5436b83> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1cda0f8d3a174e3a7f752b5be5436b83 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_1cda0f8d3a174e3a7f752b5be5436b83 FromStructure(RC_1cda0f8d3a174e3a7f752b5be5436b83 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_1cda0f8d3a174e3a7f752b5be5436b83(s, config);
}

}


