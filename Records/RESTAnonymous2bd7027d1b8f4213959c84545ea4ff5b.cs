using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderApprovalOrderMainOrderApprovalLevelRecord
public class RESTRC_7074703fd377ca40d733f2d5d8d3fde2 : AbstractRESTStructure<RC_7074703fd377ca40d733f2d5d8d3fde2> {
[JsonProperty("OrderApproval")]
public ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord AttrOrderApproval;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord AttrOrderApprovalLevel;

public RESTRC_7074703fd377ca40d733f2d5d8d3fde2() { }

public RESTRC_7074703fd377ca40d733f2d5d8d3fde2 (RC_7074703fd377ca40d733f2d5d8d3fde2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderApproval = ConvertToRestWithoutDefaults(s.ssENOrderApproval, new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderApprovalLevel, new EN_6b660d05e4c0025dff47119642875ca2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure, config);
  } else {
AttrOrderApproval = ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure(s.ssENOrderApproval, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure(s.ssENOrderApprovalLevel, config);
  }
}

public static RC_7074703fd377ca40d733f2d5d8d3fde2 ToStructure(ssConectaProveedores.RestRecords.RESTRC_7074703fd377ca40d733f2d5d8d3fde2 obj) { 
  RC_7074703fd377ca40d733f2d5d8d3fde2 s = new RC_7074703fd377ca40d733f2d5d8d3fde2();
  if(obj != null) {
  s.ssENOrderApproval = ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.ToStructure(obj.AttrOrderApproval);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssENOrderApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.ToStructure(obj.AttrOrderApprovalLevel);
  }
  return s;
}

public static Func<RC_7074703fd377ca40d733f2d5d8d3fde2, ssConectaProveedores.RestRecords.RESTRC_7074703fd377ca40d733f2d5d8d3fde2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7074703fd377ca40d733f2d5d8d3fde2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_7074703fd377ca40d733f2d5d8d3fde2 FromStructure(RC_7074703fd377ca40d733f2d5d8d3fde2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_7074703fd377ca40d733f2d5d8d3fde2(s, config);
}

}


