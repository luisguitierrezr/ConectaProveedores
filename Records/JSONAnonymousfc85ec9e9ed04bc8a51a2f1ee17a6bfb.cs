using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRequestFileApprovalOrderRequestFileApprovalLevelRecord
public class JSONRC_b93868933f6a016605b24812ac8e5133 : AbstractRESTStructure<RC_b93868933f6a016605b24812ac8e5133> {
[JsonProperty("OrderRequestFileApproval")]
[JsonPropertyName("OrderRequestFileApproval")]
public ssConectaProveedores.RestRecords.JSONEN_1710c672f4d7138b664ee1411114271eEntityRecord AttrOrderRequestFileApproval;

[JsonProperty("OrderRequestFileApprovalLevel")]
[JsonPropertyName("OrderRequestFileApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_80af67ecab8f43d464cc57955285a024EntityRecord AttrOrderRequestFileApprovalLevel;

public JSONRC_b93868933f6a016605b24812ac8e5133() { }

public JSONRC_b93868933f6a016605b24812ac8e5133 (RC_b93868933f6a016605b24812ac8e5133 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderRequestFileApproval = ConvertToRestWithoutDefaults(s.ssENOrderRequestFileApproval, new EN_1710c672f4d7138b664ee1411114271eEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1710c672f4d7138b664ee1411114271eEntityRecord.FromStructure, config);
AttrOrderRequestFileApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderRequestFileApprovalLevel, new EN_80af67ecab8f43d464cc57955285a024EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_80af67ecab8f43d464cc57955285a024EntityRecord.FromStructure, config);
  } else {
AttrOrderRequestFileApproval = ssConectaProveedores.RestRecords.JSONEN_1710c672f4d7138b664ee1411114271eEntityRecord.FromStructure(s.ssENOrderRequestFileApproval, config);
AttrOrderRequestFileApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_80af67ecab8f43d464cc57955285a024EntityRecord.FromStructure(s.ssENOrderRequestFileApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b93868933f6a016605b24812ac8e5133, RC_b93868933f6a016605b24812ac8e5133> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b93868933f6a016605b24812ac8e5133 s) => ToStructure(s, config);
}
public static RC_b93868933f6a016605b24812ac8e5133 ToStructure(ssConectaProveedores.RestRecords.JSONRC_b93868933f6a016605b24812ac8e5133 obj, IBehaviorsConfiguration config) { 
  RC_b93868933f6a016605b24812ac8e5133 s = new RC_b93868933f6a016605b24812ac8e5133();
  if(obj != null) {
  s.ssENOrderRequestFileApproval = ssConectaProveedores.RestRecords.JSONEN_1710c672f4d7138b664ee1411114271eEntityRecord.ToStructure(obj.AttrOrderRequestFileApproval, config);
  s.ssENOrderRequestFileApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_80af67ecab8f43d464cc57955285a024EntityRecord.ToStructure(obj.AttrOrderRequestFileApprovalLevel, config);
  }
  return s;
}

public static Func<RC_b93868933f6a016605b24812ac8e5133, ssConectaProveedores.RestRecords.JSONRC_b93868933f6a016605b24812ac8e5133> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b93868933f6a016605b24812ac8e5133 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b93868933f6a016605b24812ac8e5133 FromStructure(RC_b93868933f6a016605b24812ac8e5133 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b93868933f6a016605b24812ac8e5133(s, config);
}

}


