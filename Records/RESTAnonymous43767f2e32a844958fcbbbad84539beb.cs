using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessAccountingRegionRecord
public class RESTRC_65930e54edca87f73a766a2aa044190e : AbstractRESTStructure<RC_65930e54edca87f73a766a2aa044190e> {
[JsonProperty("ApprovalProcess")]
public ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

[JsonProperty("AccountingRegion")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrAccountingRegion;

public RESTRC_65930e54edca87f73a766a2aa044190e() { }

public RESTRC_65930e54edca87f73a766a2aa044190e (RC_65930e54edca87f73a766a2aa044190e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
AttrAccountingRegion = ConvertToRestWithoutDefaults(s.ssENAccountingRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrApprovalProcess = ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
AttrAccountingRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENAccountingRegion, config);
  }
}

public static RC_65930e54edca87f73a766a2aa044190e ToStructure(ssConectaProveedores.RestRecords.RESTRC_65930e54edca87f73a766a2aa044190e obj) { 
  RC_65930e54edca87f73a766a2aa044190e s = new RC_65930e54edca87f73a766a2aa044190e();
  if(obj != null) {
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess);
  s.ssENAccountingRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrAccountingRegion);
  }
  return s;
}

public static Func<RC_65930e54edca87f73a766a2aa044190e, ssConectaProveedores.RestRecords.RESTRC_65930e54edca87f73a766a2aa044190e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_65930e54edca87f73a766a2aa044190e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_65930e54edca87f73a766a2aa044190e FromStructure(RC_65930e54edca87f73a766a2aa044190e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_65930e54edca87f73a766a2aa044190e(s, config);
}

}


