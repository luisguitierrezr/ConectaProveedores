using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderApprovalOrderMainOrderApprovalLevelRecord
public class JSONRC_7074703fd377ca40d733f2d5d8d3fde2 : AbstractRESTStructure<RC_7074703fd377ca40d733f2d5d8d3fde2> {
[JsonProperty("OrderApproval")]
[JsonPropertyName("OrderApproval")]
public ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord AttrOrderApproval;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderApprovalLevel")]
[JsonPropertyName("OrderApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord AttrOrderApprovalLevel;

public JSONRC_7074703fd377ca40d733f2d5d8d3fde2() { }

public JSONRC_7074703fd377ca40d733f2d5d8d3fde2 (RC_7074703fd377ca40d733f2d5d8d3fde2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderApproval = ConvertToRestWithoutDefaults(s.ssENOrderApproval, new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderApprovalLevel, new EN_6b660d05e4c0025dff47119642875ca2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure, config);
  } else {
AttrOrderApproval = ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure(s.ssENOrderApproval, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure(s.ssENOrderApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_7074703fd377ca40d733f2d5d8d3fde2, RC_7074703fd377ca40d733f2d5d8d3fde2> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_7074703fd377ca40d733f2d5d8d3fde2 s) => ToStructure(s, config);
}
public static RC_7074703fd377ca40d733f2d5d8d3fde2 ToStructure(ssConectaProveedores.RestRecords.JSONRC_7074703fd377ca40d733f2d5d8d3fde2 obj, IBehaviorsConfiguration config) { 
  RC_7074703fd377ca40d733f2d5d8d3fde2 s = new RC_7074703fd377ca40d733f2d5d8d3fde2();
  if(obj != null) {
  s.ssENOrderApproval = ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.ToStructure(obj.AttrOrderApproval, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENOrderApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.ToStructure(obj.AttrOrderApprovalLevel, config);
  }
  return s;
}

public static Func<RC_7074703fd377ca40d733f2d5d8d3fde2, ssConectaProveedores.RestRecords.JSONRC_7074703fd377ca40d733f2d5d8d3fde2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7074703fd377ca40d733f2d5d8d3fde2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_7074703fd377ca40d733f2d5d8d3fde2 FromStructure(RC_7074703fd377ca40d733f2d5d8d3fde2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_7074703fd377ca40d733f2d5d8d3fde2(s, config);
}

}


