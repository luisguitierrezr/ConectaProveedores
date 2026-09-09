using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserInvoiceOrderRequestFileApprovalOrderRequestFileApprovalLevelInvoiceStatusApprovalStatusOrderRequestFileOrderMainEntraRoleStorageRecord
public class JSONRC_0a31a39e5189fa78e8cbab87cf47752b : AbstractRESTStructure<RC_0a31a39e5189fa78e8cbab87cf47752b> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("OrderRequestFileApproval")]
[JsonPropertyName("OrderRequestFileApproval")]
public ssConectaProveedores.RestRecords.JSONEN_1710c672f4d7138b664ee1411114271eEntityRecord AttrOrderRequestFileApproval;

[JsonProperty("OrderRequestFileApprovalLevel")]
[JsonPropertyName("OrderRequestFileApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_80af67ecab8f43d464cc57955285a024EntityRecord AttrOrderRequestFileApprovalLevel;

[JsonProperty("InvoiceStatus")]
[JsonPropertyName("InvoiceStatus")]
public ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord AttrInvoiceStatus;

[JsonProperty("ApprovalStatus")]
[JsonPropertyName("ApprovalStatus")]
public ssConectaProveedores.RestRecords.JSONEN_e97ac0d21205ff90ab42100bba6097baEntityRecord AttrApprovalStatus;

[JsonProperty("OrderRequestFile")]
[JsonPropertyName("OrderRequestFile")]
public ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord AttrOrderRequestFile;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("EntraRole")]
[JsonPropertyName("EntraRole")]
public ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrEntraRole;

[JsonProperty("Storage")]
[JsonPropertyName("Storage")]
public ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

public JSONRC_0a31a39e5189fa78e8cbab87cf47752b() { }

public JSONRC_0a31a39e5189fa78e8cbab87cf47752b (RC_0a31a39e5189fa78e8cbab87cf47752b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrOrderRequestFileApproval = ConvertToRestWithoutDefaults(s.ssENOrderRequestFileApproval, new EN_1710c672f4d7138b664ee1411114271eEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1710c672f4d7138b664ee1411114271eEntityRecord.FromStructure, config);
AttrOrderRequestFileApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderRequestFileApprovalLevel, new EN_80af67ecab8f43d464cc57955285a024EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_80af67ecab8f43d464cc57955285a024EntityRecord.FromStructure, config);
AttrInvoiceStatus = ConvertToRestWithoutDefaults(s.ssENInvoiceStatus, new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure, config);
AttrApprovalStatus = ConvertToRestWithoutDefaults(s.ssENApprovalStatus, new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.FromStructure, config);
AttrOrderRequestFile = ConvertToRestWithoutDefaults(s.ssENOrderRequestFile, new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrEntraRole = ConvertToRestWithoutDefaults(s.ssENEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrOrderRequestFileApproval = ssConectaProveedores.RestRecords.JSONEN_1710c672f4d7138b664ee1411114271eEntityRecord.FromStructure(s.ssENOrderRequestFileApproval, config);
AttrOrderRequestFileApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_80af67ecab8f43d464cc57955285a024EntityRecord.FromStructure(s.ssENOrderRequestFileApprovalLevel, config);
AttrInvoiceStatus = ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure(s.ssENInvoiceStatus, config);
AttrApprovalStatus = ssConectaProveedores.RestRecords.JSONEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.FromStructure(s.ssENApprovalStatus, config);
AttrOrderRequestFile = ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure(s.ssENOrderRequestFile, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENEntraRole, config);
AttrStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_0a31a39e5189fa78e8cbab87cf47752b, RC_0a31a39e5189fa78e8cbab87cf47752b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0a31a39e5189fa78e8cbab87cf47752b s) => ToStructure(s, config);
}
public static RC_0a31a39e5189fa78e8cbab87cf47752b ToStructure(ssConectaProveedores.RestRecords.JSONRC_0a31a39e5189fa78e8cbab87cf47752b obj, IBehaviorsConfiguration config) { 
  RC_0a31a39e5189fa78e8cbab87cf47752b s = new RC_0a31a39e5189fa78e8cbab87cf47752b();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENOrderRequestFileApproval = ssConectaProveedores.RestRecords.JSONEN_1710c672f4d7138b664ee1411114271eEntityRecord.ToStructure(obj.AttrOrderRequestFileApproval, config);
  s.ssENOrderRequestFileApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_80af67ecab8f43d464cc57955285a024EntityRecord.ToStructure(obj.AttrOrderRequestFileApprovalLevel, config);
  s.ssENInvoiceStatus = ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.ToStructure(obj.AttrInvoiceStatus, config);
  s.ssENApprovalStatus = ssConectaProveedores.RestRecords.JSONEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.ToStructure(obj.AttrApprovalStatus, config);
  s.ssENOrderRequestFile = ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.ToStructure(obj.AttrOrderRequestFile, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrEntraRole, config);
  s.ssENStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage, config);
  }
  return s;
}

public static Func<RC_0a31a39e5189fa78e8cbab87cf47752b, ssConectaProveedores.RestRecords.JSONRC_0a31a39e5189fa78e8cbab87cf47752b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0a31a39e5189fa78e8cbab87cf47752b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0a31a39e5189fa78e8cbab87cf47752b FromStructure(RC_0a31a39e5189fa78e8cbab87cf47752b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0a31a39e5189fa78e8cbab87cf47752b(s, config);
}

}


