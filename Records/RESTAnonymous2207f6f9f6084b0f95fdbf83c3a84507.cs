using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessApprovalProcessMatrixRegionRecord
public class RESTRC_01911a773916dfcf99bb546f23183cea : AbstractRESTStructure<RC_01911a773916dfcf99bb546f23183cea> {
[JsonProperty("ApprovalProcess")]
public ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

[JsonProperty("ApprovalProcessMatrix")]
public ssConectaProveedores.RestRecords.RESTEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord AttrApprovalProcessMatrix;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_01911a773916dfcf99bb546f23183cea() { }

public RESTRC_01911a773916dfcf99bb546f23183cea (RC_01911a773916dfcf99bb546f23183cea s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
AttrApprovalProcessMatrix = ConvertToRestWithoutDefaults(s.ssENApprovalProcessMatrix, new EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrApprovalProcess = ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
AttrApprovalProcessMatrix = ssConectaProveedores.RestRecords.RESTEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord.FromStructure(s.ssENApprovalProcessMatrix, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_01911a773916dfcf99bb546f23183cea ToStructure(ssConectaProveedores.RestRecords.RESTRC_01911a773916dfcf99bb546f23183cea obj) { 
  RC_01911a773916dfcf99bb546f23183cea s = new RC_01911a773916dfcf99bb546f23183cea();
  if(obj != null) {
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess);
  s.ssENApprovalProcessMatrix = ssConectaProveedores.RestRecords.RESTEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord.ToStructure(obj.AttrApprovalProcessMatrix);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_01911a773916dfcf99bb546f23183cea, ssConectaProveedores.RestRecords.RESTRC_01911a773916dfcf99bb546f23183cea> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_01911a773916dfcf99bb546f23183cea s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_01911a773916dfcf99bb546f23183cea FromStructure(RC_01911a773916dfcf99bb546f23183cea s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_01911a773916dfcf99bb546f23183cea(s, config);
}

}


