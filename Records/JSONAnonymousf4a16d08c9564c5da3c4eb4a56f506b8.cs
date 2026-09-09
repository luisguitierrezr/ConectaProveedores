using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderStatusOrderMainCompanyRecord
public class JSONRC_cbbe4b608ba4cd678dd3afd544ca547e : AbstractRESTStructure<RC_cbbe4b608ba4cd678dd3afd544ca547e> {
[JsonProperty("OrderStatus")]
[JsonPropertyName("OrderStatus")]
public ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord AttrOrderStatus;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("Company")]
[JsonPropertyName("Company")]
public ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

public JSONRC_cbbe4b608ba4cd678dd3afd544ca547e() { }

public JSONRC_cbbe4b608ba4cd678dd3afd544ca547e (RC_cbbe4b608ba4cd678dd3afd544ca547e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderStatus = ConvertToRestWithoutDefaults(s.ssENOrderStatus, new EN_5eda60810da752f579e01795bb7e0de0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
  } else {
AttrOrderStatus = ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure(s.ssENOrderStatus, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_cbbe4b608ba4cd678dd3afd544ca547e, RC_cbbe4b608ba4cd678dd3afd544ca547e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_cbbe4b608ba4cd678dd3afd544ca547e s) => ToStructure(s, config);
}
public static RC_cbbe4b608ba4cd678dd3afd544ca547e ToStructure(ssConectaProveedores.RestRecords.JSONRC_cbbe4b608ba4cd678dd3afd544ca547e obj, IBehaviorsConfiguration config) { 
  RC_cbbe4b608ba4cd678dd3afd544ca547e s = new RC_cbbe4b608ba4cd678dd3afd544ca547e();
  if(obj != null) {
  s.ssENOrderStatus = ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord.ToStructure(obj.AttrOrderStatus, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany, config);
  }
  return s;
}

public static Func<RC_cbbe4b608ba4cd678dd3afd544ca547e, ssConectaProveedores.RestRecords.JSONRC_cbbe4b608ba4cd678dd3afd544ca547e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cbbe4b608ba4cd678dd3afd544ca547e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_cbbe4b608ba4cd678dd3afd544ca547e FromStructure(RC_cbbe4b608ba4cd678dd3afd544ca547e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_cbbe4b608ba4cd678dd3afd544ca547e(s, config);
}

}


