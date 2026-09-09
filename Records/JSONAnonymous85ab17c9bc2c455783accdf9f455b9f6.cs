using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderApprovalOrderMainRecord
public class JSONRC_158d774b1951665b144a20e40b8bb511 : AbstractRESTStructure<RC_158d774b1951665b144a20e40b8bb511> {
[JsonProperty("OrderApproval")]
[JsonPropertyName("OrderApproval")]
public ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord AttrOrderApproval;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public JSONRC_158d774b1951665b144a20e40b8bb511() { }

public JSONRC_158d774b1951665b144a20e40b8bb511 (RC_158d774b1951665b144a20e40b8bb511 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderApproval = ConvertToRestWithoutDefaults(s.ssENOrderApproval, new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrOrderApproval = ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure(s.ssENOrderApproval, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_158d774b1951665b144a20e40b8bb511, RC_158d774b1951665b144a20e40b8bb511> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_158d774b1951665b144a20e40b8bb511 s) => ToStructure(s, config);
}
public static RC_158d774b1951665b144a20e40b8bb511 ToStructure(ssConectaProveedores.RestRecords.JSONRC_158d774b1951665b144a20e40b8bb511 obj, IBehaviorsConfiguration config) { 
  RC_158d774b1951665b144a20e40b8bb511 s = new RC_158d774b1951665b144a20e40b8bb511();
  if(obj != null) {
  s.ssENOrderApproval = ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.ToStructure(obj.AttrOrderApproval, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  }
  return s;
}

public static Func<RC_158d774b1951665b144a20e40b8bb511, ssConectaProveedores.RestRecords.JSONRC_158d774b1951665b144a20e40b8bb511> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_158d774b1951665b144a20e40b8bb511 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_158d774b1951665b144a20e40b8bb511 FromStructure(RC_158d774b1951665b144a20e40b8bb511 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_158d774b1951665b144a20e40b8bb511(s, config);
}

}


