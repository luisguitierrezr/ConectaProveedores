using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderStatusOrderMainCompanyRecord
public class RESTRC_cbbe4b608ba4cd678dd3afd544ca547e : AbstractRESTStructure<RC_cbbe4b608ba4cd678dd3afd544ca547e> {
[JsonProperty("OrderStatus")]
public ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord AttrOrderStatus;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("Company")]
public ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

public RESTRC_cbbe4b608ba4cd678dd3afd544ca547e() { }

public RESTRC_cbbe4b608ba4cd678dd3afd544ca547e (RC_cbbe4b608ba4cd678dd3afd544ca547e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderStatus = ConvertToRestWithoutDefaults(s.ssENOrderStatus, new EN_5eda60810da752f579e01795bb7e0de0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
  } else {
AttrOrderStatus = ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure(s.ssENOrderStatus, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrCompany = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
  }
}

public static RC_cbbe4b608ba4cd678dd3afd544ca547e ToStructure(ssConectaProveedores.RestRecords.RESTRC_cbbe4b608ba4cd678dd3afd544ca547e obj) { 
  RC_cbbe4b608ba4cd678dd3afd544ca547e s = new RC_cbbe4b608ba4cd678dd3afd544ca547e();
  if(obj != null) {
  s.ssENOrderStatus = ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord.ToStructure(obj.AttrOrderStatus);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssENCompany = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany);
  }
  return s;
}

public static Func<RC_cbbe4b608ba4cd678dd3afd544ca547e, ssConectaProveedores.RestRecords.RESTRC_cbbe4b608ba4cd678dd3afd544ca547e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cbbe4b608ba4cd678dd3afd544ca547e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_cbbe4b608ba4cd678dd3afd544ca547e FromStructure(RC_cbbe4b608ba4cd678dd3afd544ca547e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_cbbe4b608ba4cd678dd3afd544ca547e(s, config);
}

}


