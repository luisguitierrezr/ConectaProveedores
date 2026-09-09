using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRequestFileApprovalOrderRequestFileApprovalLevelRecord
public class RESTRC_b93868933f6a016605b24812ac8e5133 : AbstractRESTStructure<RC_b93868933f6a016605b24812ac8e5133> {
[JsonProperty("OrderRequestFileApproval")]
public ssConectaProveedores.RestRecords.RESTEN_1710c672f4d7138b664ee1411114271eEntityRecord AttrOrderRequestFileApproval;

[JsonProperty("OrderRequestFileApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord AttrOrderRequestFileApprovalLevel;

public RESTRC_b93868933f6a016605b24812ac8e5133() { }

public RESTRC_b93868933f6a016605b24812ac8e5133 (RC_b93868933f6a016605b24812ac8e5133 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderRequestFileApproval = ConvertToRestWithoutDefaults(s.ssENOrderRequestFileApproval, new EN_1710c672f4d7138b664ee1411114271eEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_1710c672f4d7138b664ee1411114271eEntityRecord.FromStructure, config);
AttrOrderRequestFileApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderRequestFileApprovalLevel, new EN_80af67ecab8f43d464cc57955285a024EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord.FromStructure, config);
  } else {
AttrOrderRequestFileApproval = ssConectaProveedores.RestRecords.RESTEN_1710c672f4d7138b664ee1411114271eEntityRecord.FromStructure(s.ssENOrderRequestFileApproval, config);
AttrOrderRequestFileApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord.FromStructure(s.ssENOrderRequestFileApprovalLevel, config);
  }
}

public static RC_b93868933f6a016605b24812ac8e5133 ToStructure(ssConectaProveedores.RestRecords.RESTRC_b93868933f6a016605b24812ac8e5133 obj) { 
  RC_b93868933f6a016605b24812ac8e5133 s = new RC_b93868933f6a016605b24812ac8e5133();
  if(obj != null) {
  s.ssENOrderRequestFileApproval = ssConectaProveedores.RestRecords.RESTEN_1710c672f4d7138b664ee1411114271eEntityRecord.ToStructure(obj.AttrOrderRequestFileApproval);
  s.ssENOrderRequestFileApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord.ToStructure(obj.AttrOrderRequestFileApprovalLevel);
  }
  return s;
}

public static Func<RC_b93868933f6a016605b24812ac8e5133, ssConectaProveedores.RestRecords.RESTRC_b93868933f6a016605b24812ac8e5133> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b93868933f6a016605b24812ac8e5133 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b93868933f6a016605b24812ac8e5133 FromStructure(RC_b93868933f6a016605b24812ac8e5133 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b93868933f6a016605b24812ac8e5133(s, config);
}

}


