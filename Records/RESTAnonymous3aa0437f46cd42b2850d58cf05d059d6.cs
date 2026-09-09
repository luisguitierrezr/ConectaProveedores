using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRequestFileApprovalOrderRequestFileApprovalLevelOrderRequestFileOrderMainRecord
public class RESTRC_c7df2d0e3d19438989bc28bf5440baf5 : AbstractRESTStructure<RC_c7df2d0e3d19438989bc28bf5440baf5> {
[JsonProperty("OrderRequestFileApproval")]
public ssConectaProveedores.RestRecords.RESTEN_1710c672f4d7138b664ee1411114271eEntityRecord AttrOrderRequestFileApproval;

[JsonProperty("OrderRequestFileApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord AttrOrderRequestFileApprovalLevel;

[JsonProperty("OrderRequestFile")]
public ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord AttrOrderRequestFile;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public RESTRC_c7df2d0e3d19438989bc28bf5440baf5() { }

public RESTRC_c7df2d0e3d19438989bc28bf5440baf5 (RC_c7df2d0e3d19438989bc28bf5440baf5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderRequestFileApproval = ConvertToRestWithoutDefaults(s.ssENOrderRequestFileApproval, new EN_1710c672f4d7138b664ee1411114271eEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_1710c672f4d7138b664ee1411114271eEntityRecord.FromStructure, config);
AttrOrderRequestFileApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderRequestFileApprovalLevel, new EN_80af67ecab8f43d464cc57955285a024EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord.FromStructure, config);
AttrOrderRequestFile = ConvertToRestWithoutDefaults(s.ssENOrderRequestFile, new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrOrderRequestFileApproval = ssConectaProveedores.RestRecords.RESTEN_1710c672f4d7138b664ee1411114271eEntityRecord.FromStructure(s.ssENOrderRequestFileApproval, config);
AttrOrderRequestFileApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord.FromStructure(s.ssENOrderRequestFileApprovalLevel, config);
AttrOrderRequestFile = ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure(s.ssENOrderRequestFile, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static RC_c7df2d0e3d19438989bc28bf5440baf5 ToStructure(ssConectaProveedores.RestRecords.RESTRC_c7df2d0e3d19438989bc28bf5440baf5 obj) { 
  RC_c7df2d0e3d19438989bc28bf5440baf5 s = new RC_c7df2d0e3d19438989bc28bf5440baf5();
  if(obj != null) {
  s.ssENOrderRequestFileApproval = ssConectaProveedores.RestRecords.RESTEN_1710c672f4d7138b664ee1411114271eEntityRecord.ToStructure(obj.AttrOrderRequestFileApproval);
  s.ssENOrderRequestFileApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_80af67ecab8f43d464cc57955285a024EntityRecord.ToStructure(obj.AttrOrderRequestFileApprovalLevel);
  s.ssENOrderRequestFile = ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.ToStructure(obj.AttrOrderRequestFile);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  }
  return s;
}

public static Func<RC_c7df2d0e3d19438989bc28bf5440baf5, ssConectaProveedores.RestRecords.RESTRC_c7df2d0e3d19438989bc28bf5440baf5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c7df2d0e3d19438989bc28bf5440baf5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c7df2d0e3d19438989bc28bf5440baf5 FromStructure(RC_c7df2d0e3d19438989bc28bf5440baf5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c7df2d0e3d19438989bc28bf5440baf5(s, config);
}

}


