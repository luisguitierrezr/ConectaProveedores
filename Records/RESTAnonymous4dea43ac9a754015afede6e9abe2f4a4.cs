using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRequestFileApprovalOrderRequestFileApprovalLevelOrderRequestFileRecord
public class RESTRC_a8588ebdb39bb2eab61d2bf4ba981fa2 : AbstractRESTStructure<RC_a8588ebdb39bb2eab61d2bf4ba981fa2> {
[JsonProperty("OrderRequestFileApproval")]
public ssConectaProveedores.RestRecords.RESTEN_1710c672f4d7138b664ee1411114271eEntityRecord AttrOrderRequestFileApproval;

[JsonProperty("OrderRequestFileApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord AttrOrderRequestFileApprovalLevel;

[JsonProperty("OrderRequestFile")]
public ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord AttrOrderRequestFile;

public RESTRC_a8588ebdb39bb2eab61d2bf4ba981fa2() { }

public RESTRC_a8588ebdb39bb2eab61d2bf4ba981fa2 (RC_a8588ebdb39bb2eab61d2bf4ba981fa2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderRequestFileApproval = ConvertToRestWithoutDefaults(s.ssENOrderRequestFileApproval, new EN_1710c672f4d7138b664ee1411114271eEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_1710c672f4d7138b664ee1411114271eEntityRecord.FromStructure, config);
AttrOrderRequestFileApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderRequestFileApprovalLevel, new EN_80af67ecab8f43d464cc57955285a024EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord.FromStructure, config);
AttrOrderRequestFile = ConvertToRestWithoutDefaults(s.ssENOrderRequestFile, new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure, config);
  } else {
AttrOrderRequestFileApproval = ssConectaProveedores.RestRecords.RESTEN_1710c672f4d7138b664ee1411114271eEntityRecord.FromStructure(s.ssENOrderRequestFileApproval, config);
AttrOrderRequestFileApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord.FromStructure(s.ssENOrderRequestFileApprovalLevel, config);
AttrOrderRequestFile = ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure(s.ssENOrderRequestFile, config);
  }
}

public static RC_a8588ebdb39bb2eab61d2bf4ba981fa2 ToStructure(ssConectaProveedores.RestRecords.RESTRC_a8588ebdb39bb2eab61d2bf4ba981fa2 obj) { 
  RC_a8588ebdb39bb2eab61d2bf4ba981fa2 s = new RC_a8588ebdb39bb2eab61d2bf4ba981fa2();
  if(obj != null) {
  s.ssENOrderRequestFileApproval = ssConectaProveedores.RestRecords.RESTEN_1710c672f4d7138b664ee1411114271eEntityRecord.ToStructure(obj.AttrOrderRequestFileApproval);
  s.ssENOrderRequestFileApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord.ToStructure(obj.AttrOrderRequestFileApprovalLevel);
  s.ssENOrderRequestFile = ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.ToStructure(obj.AttrOrderRequestFile);
  }
  return s;
}

public static Func<RC_a8588ebdb39bb2eab61d2bf4ba981fa2, ssConectaProveedores.RestRecords.RESTRC_a8588ebdb39bb2eab61d2bf4ba981fa2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a8588ebdb39bb2eab61d2bf4ba981fa2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a8588ebdb39bb2eab61d2bf4ba981fa2 FromStructure(RC_a8588ebdb39bb2eab61d2bf4ba981fa2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a8588ebdb39bb2eab61d2bf4ba981fa2(s, config);
}

}


