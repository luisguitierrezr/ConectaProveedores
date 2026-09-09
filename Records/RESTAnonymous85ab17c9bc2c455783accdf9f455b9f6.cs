using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderApprovalOrderMainRecord
public class RESTRC_158d774b1951665b144a20e40b8bb511 : AbstractRESTStructure<RC_158d774b1951665b144a20e40b8bb511> {
[JsonProperty("OrderApproval")]
public ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord AttrOrderApproval;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public RESTRC_158d774b1951665b144a20e40b8bb511() { }

public RESTRC_158d774b1951665b144a20e40b8bb511 (RC_158d774b1951665b144a20e40b8bb511 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderApproval = ConvertToRestWithoutDefaults(s.ssENOrderApproval, new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrOrderApproval = ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure(s.ssENOrderApproval, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static RC_158d774b1951665b144a20e40b8bb511 ToStructure(ssConectaProveedores.RestRecords.RESTRC_158d774b1951665b144a20e40b8bb511 obj) { 
  RC_158d774b1951665b144a20e40b8bb511 s = new RC_158d774b1951665b144a20e40b8bb511();
  if(obj != null) {
  s.ssENOrderApproval = ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.ToStructure(obj.AttrOrderApproval);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  }
  return s;
}

public static Func<RC_158d774b1951665b144a20e40b8bb511, ssConectaProveedores.RestRecords.RESTRC_158d774b1951665b144a20e40b8bb511> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_158d774b1951665b144a20e40b8bb511 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_158d774b1951665b144a20e40b8bb511 FromStructure(RC_158d774b1951665b144a20e40b8bb511 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_158d774b1951665b144a20e40b8bb511(s, config);
}

}


