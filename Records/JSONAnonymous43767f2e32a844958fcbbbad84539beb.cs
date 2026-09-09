using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessAccountingRegionRecord
public class JSONRC_65930e54edca87f73a766a2aa044190e : AbstractRESTStructure<RC_65930e54edca87f73a766a2aa044190e> {
[JsonProperty("ApprovalProcess")]
[JsonPropertyName("ApprovalProcess")]
public ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

[JsonProperty("AccountingRegion")]
[JsonPropertyName("AccountingRegion")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrAccountingRegion;

public JSONRC_65930e54edca87f73a766a2aa044190e() { }

public JSONRC_65930e54edca87f73a766a2aa044190e (RC_65930e54edca87f73a766a2aa044190e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
AttrAccountingRegion = ConvertToRestWithoutDefaults(s.ssENAccountingRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
AttrAccountingRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENAccountingRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_65930e54edca87f73a766a2aa044190e, RC_65930e54edca87f73a766a2aa044190e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_65930e54edca87f73a766a2aa044190e s) => ToStructure(s, config);
}
public static RC_65930e54edca87f73a766a2aa044190e ToStructure(ssConectaProveedores.RestRecords.JSONRC_65930e54edca87f73a766a2aa044190e obj, IBehaviorsConfiguration config) { 
  RC_65930e54edca87f73a766a2aa044190e s = new RC_65930e54edca87f73a766a2aa044190e();
  if(obj != null) {
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess, config);
  s.ssENAccountingRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrAccountingRegion, config);
  }
  return s;
}

public static Func<RC_65930e54edca87f73a766a2aa044190e, ssConectaProveedores.RestRecords.JSONRC_65930e54edca87f73a766a2aa044190e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_65930e54edca87f73a766a2aa044190e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_65930e54edca87f73a766a2aa044190e FromStructure(RC_65930e54edca87f73a766a2aa044190e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_65930e54edca87f73a766a2aa044190e(s, config);
}

}


