using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessApprovalProcessMatrixRegionRecord
public class JSONRC_01911a773916dfcf99bb546f23183cea : AbstractRESTStructure<RC_01911a773916dfcf99bb546f23183cea> {
[JsonProperty("ApprovalProcess")]
[JsonPropertyName("ApprovalProcess")]
public ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

[JsonProperty("ApprovalProcessMatrix")]
[JsonPropertyName("ApprovalProcessMatrix")]
public ssConectaProveedores.RestRecords.JSONEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord AttrApprovalProcessMatrix;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_01911a773916dfcf99bb546f23183cea() { }

public JSONRC_01911a773916dfcf99bb546f23183cea (RC_01911a773916dfcf99bb546f23183cea s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
AttrApprovalProcessMatrix = ConvertToRestWithoutDefaults(s.ssENApprovalProcessMatrix, new EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
AttrApprovalProcessMatrix = ssConectaProveedores.RestRecords.JSONEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord.FromStructure(s.ssENApprovalProcessMatrix, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_01911a773916dfcf99bb546f23183cea, RC_01911a773916dfcf99bb546f23183cea> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_01911a773916dfcf99bb546f23183cea s) => ToStructure(s, config);
}
public static RC_01911a773916dfcf99bb546f23183cea ToStructure(ssConectaProveedores.RestRecords.JSONRC_01911a773916dfcf99bb546f23183cea obj, IBehaviorsConfiguration config) { 
  RC_01911a773916dfcf99bb546f23183cea s = new RC_01911a773916dfcf99bb546f23183cea();
  if(obj != null) {
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess, config);
  s.ssENApprovalProcessMatrix = ssConectaProveedores.RestRecords.JSONEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord.ToStructure(obj.AttrApprovalProcessMatrix, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_01911a773916dfcf99bb546f23183cea, ssConectaProveedores.RestRecords.JSONRC_01911a773916dfcf99bb546f23183cea> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_01911a773916dfcf99bb546f23183cea s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_01911a773916dfcf99bb546f23183cea FromStructure(RC_01911a773916dfcf99bb546f23183cea s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_01911a773916dfcf99bb546f23183cea(s, config);
}

}


